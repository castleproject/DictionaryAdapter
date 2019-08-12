# Castle DictionaryAdapter

<img align="right" src="docs/images/castle-logo.png">

Castle DictionaryAdapter on the fly generates strongly-typed wrappers around untyped dictionaries, or chunks of XML (like config file), optionally adding support for change notification, cancelation, error notification and other features.

See the [documentation](docs/README.md).

## Releases

[![NuGet](https://img.shields.io/nuget/v/Castle.DictionaryAdapter.svg)](https://www.nuget.org/packages/Castle.DictionaryAdapter/)

See the [Releases](https://github.com/castleproject/DictionaryAdapter/releases).

Debugging symbols are available in symbol packages in the AppVeyor build artifacts since version 4.1.0. :construction:

## License

Castle DictionaryAdapter is &copy; 2004-2019 Castle Project. It is free software, and may be redistributed under the terms of the [Apache 2.0](http://opensource.org/licenses/Apache-2.0) license.

## Contributing

Browse the [contributing section](https://github.com/castleproject/Home#its-community-driven) of our _Home_ repository to get involved.

## Building

| Platforms       | Build Status   | NuGet Feed     |
|-----------------|----------------|----------------|
| Windows & Linux | :construction: | :construction: |

### On Windows

```
build.cmd
```

Compilation requires an up-to-date .NET Core SDK, MSBuild 15+ (which should be included in the former), and reference assemblies for the .NET Framework versions 3.5, 4.0, and 4.5.

Running the unit tests additionally requires the .NET Framework 4.6.1+ as well as the .NET Core 1.1 runtime to be installed.

Most of these requirements should be covered by Visual Studio 2017.

### On Linux

```
./build.sh
```

Compilation requires an up-to-date .NET Core SDK, as well as Mono for the .NET Framework reference assemblies. We recommend Mono 5.10+, though older versions (4.6.1+) might still work as well.

Running the unit tests additionally requires the .NET Core 1.1 runtime to be installed.

:information_source: **Mono runtime support:** Castle Core runs with minor limitations and defects on Mono 4.0.2+ (however 4.6.1+ is highly recommended, or 5.10+ if your code uses new C# 7.x language features such as `in` parameters).

We test against up-to-date Mono versions in order to fix known defects as soon as possible. Because of this, if you are using an older Mono version than our Continuous Integration (CI) build, you might see some unit tests fail.

For known Mono defects, check [our issue tracker](https://github.com/castleproject/Core/issues?utf8=%E2%9C%93&q=is%3Aissue%20is%3Aopen%20mono), as well as unit tests marked with `[ExcludeOnFramework(Framework.Mono, ...)]` in the source code.

### Conditional Compilation Symbols

The following conditional compilation symbols (vertical) are currently defined for each of the build configurations (horizontal):

Symbol                              | NET35              | NET40              | NET45              | .NET Core
----------------------------------- | ------------------ | ------------------ | ------------------ | ------------------
`FEATURE_BINDINGLIST`               | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`FEATURE_DICTIONARYADAPTER_XML`     | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`FEATURE_IDATAERRORINFO`            | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`FEATURE_ISUPPORTINITIALIZE`        | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`FEATURE_LEGACY_REFLECTION_API`     | :white_check_mark: | :white_check_mark: | :no_entry_sign:    | :no_entry_sign:
`FEATURE_LISTSORT`                  | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`FEATURE_NETCORE_REFLECTION_API`    | :no_entry_sign:    | :no_entry_sign:    | :no_entry_sign:    | :white_check_mark:
`FEATURE_SECURITY_PERMISSIONS`      | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`FEATURE_SERIALIZATION`             | :white_check_mark: | :white_check_mark: | :white_check_mark: | :no_entry_sign:
---                                 |                    |                    |                    | 
`DOTNET35`                          | :white_check_mark: | :no_entry_sign:    | :no_entry_sign:    | :no_entry_sign:
`DOTNET40`                          | :no_entry_sign:    | :white_check_mark: | :white_check_mark: | :no_entry_sign:
`DOTNET45`                          | :no_entry_sign:    | :no_entry_sign:    | :white_check_mark: | :no_entry_sign:

* `FEATURE_BINDINGLIST` - enables support features that make use of System.ComponentModel.BindingList.
* `FEATURE_DICTIONARYADAPTER_XML` - enable DictionaryAdapter Xml features.
* `FEATURE_IDATAERRORINFO` - enables code that depends on System.ComponentModel.IDataErrorInfo.
* `FEATURE_ISUPPORTINITIALIZE` - enables support for features that make use of System.ComponentModel.ISupportInitialize.
* `FEATURE_LEGACY_REFLECTION_API` - provides a shim for .NET 3.5/4.0 that emulates the `TypeInfo` API available in .NET 4.5+ and .NET Core.
* `FEATURE_LISTSORT` - enables support for features that make use of System.ComponentModel.ListSortDescription.
* `FEATURE_NETCORE_REFLECTION_API` - provides shims to implement missing functionality in .NET Core that has no alternatives.
* `FEATURE_SECURITY_PERMISSIONS` - enables the use of CAS and Security[Critical|SafeCritical|Transparent].
* `FEATURE_SERIALIZATION` - enables support for serialization of dynamic proxies and other types.
