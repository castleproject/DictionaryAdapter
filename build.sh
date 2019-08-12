#!/bin/bash
# ****************************************************************************
# Copyright 2004-2017 Castle Project - http://www.castleproject.org/
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# 
#     http://www.apache.org/licenses/LICENSE-2.0
# 
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# ****************************************************************************

DOTNETPATH=$(which dotnet)
if [ ! -f "$DOTNETPATH" ]; then
	echo "Please install Microsoft/netcore from: https://www.microsoft.com/net/core"
	exit 1
fi
MONOPATH=$(which mono)

if [ ! -f "$MONOPATH" ]; then
	echo "Please install Xamarin/mono from: http://www.mono-project.com/docs/getting-started/install/"
	exit 1
fi

# This lets `dotnet` know where to find Mono's reference assemblies when compiling for the `net461` platform:
export FrameworkPathOverride=$(dirname $MONOPATH)/../lib/mono/4.6.1-api/

dotnet restore ./src/Castle.DictionaryAdapter/Castle.DictionaryAdapter.csproj
dotnet restore ./src/Castle.DictionaryAdapter.Tests/Castle.DictionaryAdapter.Tests.csproj

# Linux/Darwin
OSNAME=$(uname -s)
echo "OSNAME: $OSNAME"

dotnet build ./src/Castle.DictionaryAdapter.Tests/Castle.DictionaryAdapter.Tests.csproj /p:Configuration=Release || exit 1

echo --------------------
echo Running NET461 Tests
echo --------------------

mono ./src/Castle.DictionaryAdapter.Tests/bin/Release/net461/Castle.DictionaryAdapter.Tests.exe --result=DesktopClrTestResults.xml;format=nunit3

echo ---------------------------
echo Running NETCOREAPP1.1 Tests
echo ---------------------------

dotnet ./src/Castle.DictionaryAdapter.Tests/bin/Release/netcoreapp1.1/Castle.DictionaryAdapter.Tests.dll --result=NetCoreClrTestResults.xml;format=nunit3

# Ensure that all test runs produced a protocol file:
if [[ !( -f NetCoreClrTestResults.xml &&
         -f DesktopClrTestResults.xml ) ]]; then
    echo "Incomplete test results. Some test runs might not have terminated properly. Failing the build."
    exit 1
fi

# Unit test failure
NETCORE_FAILCOUNT=$(grep -F "One or more child tests had errors" NetCoreClrTestResults.xml | wc -l)
if [ $NETCORE_FAILCOUNT -ne 0 ]
then
    echo "NetCore Tests have failed, failing the build"
    exit 1
fi

MONO_FAILCOUNT=$(grep -F "One or more child tests had errors" DesktopClrTestResults.xml | wc -l)
if [ $MONO_FAILCOUNT -ne 0 ]
then
    echo "DesktopClr Tests have failed, failing the build"
    exit 1
fi
