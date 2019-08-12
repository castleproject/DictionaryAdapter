[assembly: System.CLSCompliantAttribute(true)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"Castle.DictionaryAdapter.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010077f5e87030dadccce6902c6adab7a987bd69cb5819991531f560785eacfc89b6fcddf6bb2a00743a7194e454c0273447fc6eec36474ba8e5a3823147d214298e4f9a631b1afee1a51ffeae4672d498f14b000e3d321453cdd8ac064de7e1cf4d222b7e81f54d4fd46725370d702a05b48738cc29d09228f1aa722ae1a9ca02fb")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETFramework,Version=v4.5", FrameworkDisplayName=".NET Framework 4.5")]
[assembly: System.Security.SecurityRulesAttribute(System.Security.SecurityRuleSet.Level2)]
namespace Castle.Components.DictionaryAdapter
{
    public abstract class AbstractDictionaryAdapter : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        protected AbstractDictionaryAdapter() { }
        public int Count { get; }
        public bool IsFixedSize { get; }
        public abstract bool IsReadOnly { get; }
        public virtual bool IsSynchronized { get; }
        public abstract object this[object key] { get; set; }
        public System.Collections.ICollection Keys { get; }
        public virtual object SyncRoot { get; }
        public System.Collections.ICollection Values { get; }
        public void Add(object key, object value) { }
        public void Clear() { }
        public abstract bool Contains(object key);
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IDictionaryEnumerator GetEnumerator() { }
        public void Remove(object key) { }
    }
    public abstract class AbstractDictionaryAdapterVisitor : Castle.Components.DictionaryAdapter.IDictionaryAdapterVisitor
    {
        protected AbstractDictionaryAdapterVisitor() { }
        protected AbstractDictionaryAdapterVisitor(Castle.Components.DictionaryAdapter.AbstractDictionaryAdapterVisitor parent) { }
        protected bool Cancelled { get; set; }
        protected virtual void VisitCollection(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, System.Type collectionItemType, object state) { }
        public virtual bool VisitDictionaryAdapter(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, object state) { }
        public virtual bool VisitDictionaryAdapter(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, System.Func<Castle.Components.DictionaryAdapter.PropertyDescriptor, bool> selector, object state) { }
        protected virtual void VisitInterface(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, object state) { }
        protected virtual void VisitProperty(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, object state) { }
    }
    public class BindingListInitializer<T> : Castle.Components.DictionaryAdapter.IValueInitializer
    {
        public BindingListInitializer(System.Func<int, object, object> addAt, System.Func<object> addNew, System.Func<int, object, object> setAt, System.Action<int> removeAt, System.Action reset) { }
        public void Initialize(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, object value) { }
    }
    public class BindingList<T> : Castle.Components.DictionaryAdapter.IBindingListSource, Castle.Components.DictionaryAdapter.IBindingList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.ICancelAddNew, System.ComponentModel.IRaiseItemChangedEvents
    {
        public BindingList() { }
        public BindingList(System.Collections.Generic.IList<T> list) { }
        public BindingList(System.ComponentModel.BindingList<T> list) { }
        public bool AllowEdit { get; set; }
        public bool AllowNew { get; set; }
        public bool AllowRemove { get; set; }
        public System.ComponentModel.IBindingList AsBindingList { get; }
        public int Count { get; }
        public System.ComponentModel.BindingList<T> InnerList { get; }
        public T this[int index] { get; set; }
        public bool RaiseListChangedEvents { get; set; }
        public event System.ComponentModel.AddingNewEventHandler AddingNew;
        public event System.ComponentModel.ListChangedEventHandler ListChanged;
        public void Add(T item) { }
        public T AddNew() { }
        public void CancelNew(int index) { }
        public void Clear() { }
        public bool Contains(T item) { }
        public void CopyTo(T[] array, int index) { }
        public void EndNew(int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public bool Remove(T item) { }
        public void RemoveAt(int index) { }
        public void ResetBindings() { }
        public void ResetItem(int index) { }
    }
    public class CascadingDictionaryAdapter : Castle.Components.DictionaryAdapter.AbstractDictionaryAdapter
    {
        public CascadingDictionaryAdapter(System.Collections.IDictionary primary, System.Collections.IDictionary secondary) { }
        public override bool IsReadOnly { get; }
        public override object this[object key] { get; set; }
        public System.Collections.IDictionary Primary { get; }
        public System.Collections.IDictionary Secondary { get; }
        public override bool Contains(object key) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class ComponentAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter
    {
        public ComponentAttribute() { }
        public bool NoPrefix { get; set; }
        public string Prefix { get; set; }
        public bool SetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, ref object value, Castle.Components.DictionaryAdapter.PropertyDescriptor property) { }
    }
    public class DefaultPropertyGetter : Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter
    {
        public DefaultPropertyGetter(System.ComponentModel.TypeConverter converter) { }
        public int ExecutionOrder { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryBehavior Copy() { }
        public object GetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, object storedValue, Castle.Components.DictionaryAdapter.PropertyDescriptor property, bool ifExists) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class DictionaryAdapterAttribute : System.Attribute
    {
        public DictionaryAdapterAttribute(System.Type interfaceType) { }
        public System.Type InterfaceType { get; }
    }
    public abstract class DictionaryAdapterBase : Castle.Components.DictionaryAdapter.IDictionaryAdapter, Castle.Components.DictionaryAdapter.IDictionaryCreate, Castle.Components.DictionaryAdapter.IDictionaryEdit, Castle.Components.DictionaryAdapter.IDictionaryNotify, Castle.Components.DictionaryAdapter.IDictionaryValidate, System.ComponentModel.IChangeTracking, System.ComponentModel.IDataErrorInfo, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.IRevertibleChangeTracking
    {
        public DictionaryAdapterBase(Castle.Components.DictionaryAdapter.DictionaryAdapterInstance instance) { }
        public bool CanEdit { get; set; }
        public bool CanNotify { get; set; }
        public bool CanValidate { get; set; }
        public string Error { get; }
        public bool IsChanged { get; }
        public bool IsEditing { get; }
        public bool IsValid { get; }
        public string this[string columnName] { get; }
        public abstract Castle.Components.DictionaryAdapter.DictionaryAdapterMeta Meta { get; }
        public bool ShouldNotify { get; }
        public bool SupportsMultiLevelEdit { get; set; }
        public Castle.Components.DictionaryAdapter.DictionaryAdapterInstance This { get; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryValidator> Validators { get; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
        public void AcceptChanges() { }
        protected void AddEditDependency(System.ComponentModel.IEditableObject editDependency) { }
        public void AddValidator(Castle.Components.DictionaryAdapter.IDictionaryValidator validator) { }
        public void BeginEdit() { }
        public void CancelEdit() { }
        protected bool ClearEditProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, string key) { }
        public void ClearProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, string key) { }
        public T Coerce<T>()
            where T :  class { }
        public object Coerce(System.Type type) { }
        public void CopyTo(Castle.Components.DictionaryAdapter.IDictionaryAdapter other) { }
        public void CopyTo(Castle.Components.DictionaryAdapter.IDictionaryAdapter other, System.Func<Castle.Components.DictionaryAdapter.PropertyDescriptor, bool> selector) { }
        public T Create<T>() { }
        public object Create(System.Type type) { }
        public T Create<T>(System.Collections.IDictionary dictionary) { }
        public object Create(System.Type type, System.Collections.IDictionary dictionary) { }
        public T Create<T>(System.Action<T> init) { }
        public T Create<T>(System.Collections.IDictionary dictionary, System.Action<T> init) { }
        protected bool EditProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, string key, object propertyValue) { }
        public void EndEdit() { }
        public override bool Equals(object obj) { }
        protected bool GetEditedProperty(string propertyName, out object propertyValue) { }
        public override int GetHashCode() { }
        public string GetKey(string propertyName) { }
        public virtual object GetProperty(string propertyName, bool ifExists) { }
        public T GetPropertyOfType<T>(string propertyName) { }
        protected void Initialize() { }
        protected void Invalidate() { }
        protected void NotifyPropertyChanged(Castle.Components.DictionaryAdapter.PropertyDescriptor property, object oldValue, object newValue) { }
        protected void NotifyPropertyChanged(string propertyName) { }
        protected bool NotifyPropertyChanging(Castle.Components.DictionaryAdapter.PropertyDescriptor property, object oldValue, object newValue) { }
        public object ReadProperty(string key) { }
        public void RejectChanges() { }
        public void ResumeEditing() { }
        public void ResumeNotifications() { }
        public virtual bool SetProperty(string propertyName, ref object value) { }
        public bool ShouldClearProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, object value) { }
        public void StoreProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, string key, object value) { }
        public void SuppressEditing() { }
        public System.IDisposable SuppressEditingBlock() { }
        public void SuppressNotifications() { }
        public System.IDisposable SuppressNotificationsBlock() { }
        protected Castle.Components.DictionaryAdapter.DictionaryAdapterBase.TrackPropertyChangeScope TrackPropertyChange(Castle.Components.DictionaryAdapter.PropertyDescriptor property, object oldValue, object newValue) { }
        protected Castle.Components.DictionaryAdapter.DictionaryAdapterBase.TrackPropertyChangeScope TrackReadonlyPropertyChanges() { }
        public Castle.Components.DictionaryAdapter.DictionaryValidateGroup ValidateGroups(params object[] groups) { }
        public class TrackPropertyChangeScope : System.IDisposable
        {
            public TrackPropertyChangeScope(Castle.Components.DictionaryAdapter.DictionaryAdapterBase adapter) { }
            public TrackPropertyChangeScope(Castle.Components.DictionaryAdapter.DictionaryAdapterBase adapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, object existingValue) { }
            public void Dispose() { }
            public bool Notify() { }
        }
    }
    public class static DictionaryAdapterExtensions
    {
        public static Castle.Components.DictionaryAdapter.IVirtual AsVirtual(this Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter) { }
    }
    public class DictionaryAdapterFactory : Castle.Components.DictionaryAdapter.IDictionaryAdapterFactory
    {
        public DictionaryAdapterFactory() { }
        public T GetAdapter<T>(System.Collections.IDictionary dictionary) { }
        public object GetAdapter(System.Type type, System.Collections.IDictionary dictionary) { }
        public object GetAdapter(System.Type type, System.Collections.IDictionary dictionary, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor) { }
        public T GetAdapter<T, R>(System.Collections.Generic.IDictionary<string, R> dictionary) { }
        public object GetAdapter<R>(System.Type type, System.Collections.Generic.IDictionary<string, R> dictionary) { }
        public T GetAdapter<T>(System.Collections.Specialized.NameValueCollection nameValues) { }
        public object GetAdapter(System.Type type, System.Collections.Specialized.NameValueCollection nameValues) { }
        public T GetAdapter<T>(System.Xml.XmlNode xmlNode) { }
        public object GetAdapter(System.Type type, System.Xml.XmlNode xmlNode) { }
        public Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type) { }
        public Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor) { }
        public Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type, Castle.Components.DictionaryAdapter.DictionaryAdapterMeta other) { }
    }
    public class DictionaryAdapterInstance
    {
        public DictionaryAdapterInstance(System.Collections.IDictionary dictionary, Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor, Castle.Components.DictionaryAdapter.IDictionaryAdapterFactory factory) { }
        public Castle.Components.DictionaryAdapter.IDictionaryCoerceStrategy CoerceStrategy { get; set; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryCopyStrategy> CopyStrategies { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryCreateStrategy CreateStrategy { get; set; }
        public Castle.Components.DictionaryAdapter.PropertyDescriptor Descriptor { get; }
        public System.Collections.IDictionary Dictionary { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryEqualityHashCodeStrategy EqualityHashCodeStrategy { get; set; }
        public System.Collections.IDictionary ExtendedProperties { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryAdapterFactory Factory { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryInitializer[] Initializers { get; }
        public System.Collections.Generic.IDictionary<string, Castle.Components.DictionaryAdapter.PropertyDescriptor> Properties { get; }
        public void AddCopyStrategy(Castle.Components.DictionaryAdapter.IDictionaryCopyStrategy copyStrategy) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Type: {Type.FullName,nq}")]
    public class DictionaryAdapterMeta
    {
        public DictionaryAdapterMeta(System.Type type, System.Type implementation, object[] behaviors, Castle.Components.DictionaryAdapter.IDictionaryMetaInitializer[] metaInitializers, Castle.Components.DictionaryAdapter.IDictionaryInitializer[] initializers, System.Collections.Generic.IDictionary<string, Castle.Components.DictionaryAdapter.PropertyDescriptor> properties, Castle.Components.DictionaryAdapter.IDictionaryAdapterFactory factory, System.Func<Castle.Components.DictionaryAdapter.DictionaryAdapterInstance, Castle.Components.DictionaryAdapter.IDictionaryAdapter> creator) { }
        public object[] Behaviors { get; }
        public System.Collections.IDictionary ExtendedProperties { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryAdapterFactory Factory { get; }
        public System.Type Implementation { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryInitializer[] Initializers { get; }
        public Castle.Components.DictionaryAdapter.IDictionaryMetaInitializer[] MetaInitializers { get; }
        public System.Collections.Generic.IDictionary<string, Castle.Components.DictionaryAdapter.PropertyDescriptor> Properties { get; }
        public System.Type Type { get; }
        public Castle.Components.DictionaryAdapter.PropertyDescriptor CreateDescriptor() { }
        public object CreateInstance(System.Collections.IDictionary dictionary, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor) { }
        public Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type) { }
    }
    public abstract class DictionaryBehaviorAttribute : System.Attribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        public const int DefaultExecutionOrder = 1073741823;
        public const int FirstExecutionOrder = 0;
        public const int LastExecutionOrder = 2147483647;
        public DictionaryBehaviorAttribute() { }
        public int ExecutionOrder { get; set; }
        public virtual Castle.Components.DictionaryAdapter.IDictionaryBehavior Copy() { }
    }
    public class DictionaryValidateGroup : Castle.Components.DictionaryAdapter.IDictionaryValidate, System.ComponentModel.IDataErrorInfo, System.ComponentModel.INotifyPropertyChanged, System.IDisposable
    {
        public DictionaryValidateGroup(object[] groups, Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter) { }
        public bool CanValidate { get; set; }
        public string Error { get; }
        public bool IsValid { get; }
        public string this[string columnName] { get; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryValidator> Validators { get; }
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        public void AddValidator(Castle.Components.DictionaryAdapter.IDictionaryValidator validator) { }
        public void Dispose() { }
        public Castle.Components.DictionaryAdapter.DictionaryValidateGroup ValidateGroups(params object[] groups) { }
    }
    public class DynamicDictionary : System.Dynamic.DynamicObject
    {
        public DynamicDictionary(System.Collections.IDictionary dictionary) { }
        public override System.Collections.Generic.IEnumerable<string> GetDynamicMemberNames() { }
        public override bool TryGetMember(System.Dynamic.GetMemberBinder binder, out object result) { }
        public override bool TrySetMember(System.Dynamic.SetMemberBinder binder, object value) { }
    }
    public class DynamicValueDelegate<T> : Castle.Components.DictionaryAdapter.DynamicValue<T>
    {
        public DynamicValueDelegate(System.Func<T> dynamicDelegate) { }
        public override T Value { get; }
    }
    public abstract class DynamicValue<T> : Castle.Components.DictionaryAdapter.IDynamicValue, Castle.Components.DictionaryAdapter.IDynamicValue<T>
    {
        protected DynamicValue() { }
        public abstract T Value { get; }
        public override string ToString() { }
    }
    public class EditableBindingList<T> : System.ComponentModel.BindingList<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable, System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.IRevertibleChangeTracking
    {
        public EditableBindingList() { }
        public EditableBindingList(System.Collections.Generic.IList<T> initial) { }
        public bool IsChanged { get; }
        public void AcceptChanges() { }
        public void BeginEdit() { }
        public void CancelEdit() { }
        public void EndEdit() { }
        public void RejectChanges() { }
    }
    public class EditableList : Castle.Components.DictionaryAdapter.EditableList<object>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList
    {
        public EditableList() { }
        public EditableList(System.Collections.Generic.IEnumerable<object> collection) { }
    }
    public class EditableList<T> : System.Collections.Generic.List<T>, System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.IRevertibleChangeTracking
    {
        public EditableList() { }
        public EditableList(System.Collections.Generic.IEnumerable<T> collection) { }
        public bool IsChanged { get; }
        public void AcceptChanges() { }
        public void BeginEdit() { }
        public void CancelEdit() { }
        public void EndEdit() { }
        public void RejectChanges() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false)]
    public class FetchAttribute : System.Attribute
    {
        public FetchAttribute() { }
        public FetchAttribute(bool fetch) { }
        public bool Fetch { get; }
    }
    public class static GenericDictionaryAdapter
    {
        public static Castle.Components.DictionaryAdapter.GenericDictionaryAdapter<TValue> ForDictionaryAdapter<TValue>(this System.Collections.Generic.IDictionary<string, TValue> dictionary) { }
    }
    public class GenericDictionaryAdapter<TValue> : Castle.Components.DictionaryAdapter.AbstractDictionaryAdapter
    {
        public GenericDictionaryAdapter(System.Collections.Generic.IDictionary<string, TValue> dictionary) { }
        public override bool IsReadOnly { get; }
        public override object this[object key] { get; set; }
        public override bool Contains(object key) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=true)]
    public class GroupAttribute : System.Attribute
    {
        public GroupAttribute(object group) { }
        public GroupAttribute(params object[] group) { }
        public object[] Group { get; }
    }
    public interface IBindingListSource
    {
        System.ComponentModel.IBindingList AsBindingList { get; }
    }
    public interface IBindingList<T> : Castle.Components.DictionaryAdapter.IBindingListSource, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable, System.ComponentModel.ICancelAddNew, System.ComponentModel.IRaiseItemChangedEvents
    {
        bool AllowEdit { get; }
        bool AllowNew { get; }
        bool AllowRemove { get; }
        bool IsSorted { get; }
        System.ComponentModel.ListSortDirection SortDirection { get; }
        System.ComponentModel.PropertyDescriptor SortProperty { get; }
        bool SupportsChangeNotification { get; }
        bool SupportsSearching { get; }
        bool SupportsSorting { get; }
        public event System.ComponentModel.ListChangedEventHandler ListChanged;
        void AddIndex(System.ComponentModel.PropertyDescriptor property);
        T AddNew();
        void ApplySort(System.ComponentModel.PropertyDescriptor property, System.ComponentModel.ListSortDirection direction);
        int Find(System.ComponentModel.PropertyDescriptor property, object key);
        void RemoveIndex(System.ComponentModel.PropertyDescriptor property);
        void RemoveSort();
    }
    public interface ICollectionAdapterObserver<T>
    {
        void OnInserted(T newValue, int index);
        bool OnInserting(T newValue);
        void OnRemoved(T oldValue, int index);
        void OnRemoving(T oldValue);
        void OnReplaced(T oldValue, T newValue, int index);
        bool OnReplacing(T oldValue, T newValue);
    }
    public interface ICollectionAdapter<T>
    {
        System.Collections.Generic.IEqualityComparer<T> Comparer { get; }
        int Count { get; }
        bool HasSnapshot { get; }
        T this[int index] { get; set; }
        int SnapshotCount { get; }
        bool Add(T value);
        T AddNew();
        void Clear();
        void ClearReferences();
        void DropSnapshot();
        T GetCurrentItem(int index);
        T GetSnapshotItem(int index);
        void Initialize(Castle.Components.DictionaryAdapter.ICollectionAdapterObserver<T> advisor);
        bool Insert(int index, T value);
        void LoadSnapshot();
        void Remove(int index);
        void SaveSnapshot();
    }
    public interface ICollectionProjection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        void Clear();
        void ClearReferences();
        void Replace(System.Collections.IEnumerable source);
    }
    public interface ICondition
    {
        bool SatisfiedBy(object value);
    }
    public interface IDictionaryAdapter : Castle.Components.DictionaryAdapter.IDictionaryCreate, Castle.Components.DictionaryAdapter.IDictionaryEdit, Castle.Components.DictionaryAdapter.IDictionaryNotify, Castle.Components.DictionaryAdapter.IDictionaryValidate, System.ComponentModel.IChangeTracking, System.ComponentModel.IDataErrorInfo, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.IRevertibleChangeTracking
    {
        Castle.Components.DictionaryAdapter.DictionaryAdapterMeta Meta { get; }
        Castle.Components.DictionaryAdapter.DictionaryAdapterInstance This { get; }
        void ClearProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, string key);
        T Coerce<T>()
            where T :  class;
        object Coerce(System.Type type);
        void CopyTo(Castle.Components.DictionaryAdapter.IDictionaryAdapter other);
        void CopyTo(Castle.Components.DictionaryAdapter.IDictionaryAdapter other, System.Func<Castle.Components.DictionaryAdapter.PropertyDescriptor, bool> selector);
        string GetKey(string propertyName);
        object GetProperty(string propertyName, bool ifExists);
        T GetPropertyOfType<T>(string propertyName);
        object ReadProperty(string key);
        bool SetProperty(string propertyName, ref object value);
        bool ShouldClearProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, object value);
        void StoreProperty(Castle.Components.DictionaryAdapter.PropertyDescriptor property, string key, object value);
    }
    public interface IDictionaryAdapterFactory
    {
        T GetAdapter<T>(System.Collections.IDictionary dictionary);
        object GetAdapter(System.Type type, System.Collections.IDictionary dictionary);
        object GetAdapter(System.Type type, System.Collections.IDictionary dictionary, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor);
        T GetAdapter<T>(System.Collections.Specialized.NameValueCollection nameValues);
        object GetAdapter(System.Type type, System.Collections.Specialized.NameValueCollection nameValues);
        T GetAdapter<T>(System.Xml.XmlNode xmlNode);
        object GetAdapter(System.Type type, System.Xml.XmlNode xmlNode);
        Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type);
        Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor);
        Castle.Components.DictionaryAdapter.DictionaryAdapterMeta GetAdapterMeta(System.Type type, Castle.Components.DictionaryAdapter.DictionaryAdapterMeta other);
    }
    public interface IDictionaryAdapterVisitor
    {
        void VisitCollection(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, System.Type collectionItemType, object state);
        bool VisitDictionaryAdapter(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, object state);
        bool VisitDictionaryAdapter(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, System.Func<Castle.Components.DictionaryAdapter.PropertyDescriptor, bool> selector, object state);
        void VisitInterface(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, object state);
        void VisitProperty(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property, object state);
    }
    public interface IDictionaryBehavior
    {
        int ExecutionOrder { get; }
        Castle.Components.DictionaryAdapter.IDictionaryBehavior Copy();
    }
    public interface IDictionaryBehaviorBuilder
    {
        object[] BuildBehaviors();
    }
    public interface IDictionaryCoerceStrategy
    {
        object Coerce(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter, System.Type type);
    }
    public interface IDictionaryCopyStrategy
    {
        bool Copy(Castle.Components.DictionaryAdapter.IDictionaryAdapter source, Castle.Components.DictionaryAdapter.IDictionaryAdapter target, ref System.Func<Castle.Components.DictionaryAdapter.PropertyDescriptor, bool> selector);
    }
    public interface IDictionaryCreate
    {
        T Create<T>();
        object Create(System.Type type);
        T Create<T>(System.Collections.IDictionary dictionary);
        object Create(System.Type type, System.Collections.IDictionary dictionary);
        T Create<T>(System.Action<T> init);
        T Create<T>(System.Collections.IDictionary dictionary, System.Action<T> init);
    }
    public interface IDictionaryCreateStrategy
    {
        object Create(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter, System.Type type, System.Collections.IDictionary dictionary);
    }
    public interface IDictionaryEdit : System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.IRevertibleChangeTracking
    {
        bool CanEdit { get; }
        bool IsEditing { get; }
        bool SupportsMultiLevelEdit { get; set; }
        void ResumeEditing();
        void SuppressEditing();
        System.IDisposable SuppressEditingBlock();
    }
    public interface IDictionaryEqualityHashCodeStrategy
    {
        bool Equals(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter1, Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter2);
        bool GetHashCode(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter, out int hashCode);
    }
    public interface IDictionaryInitializer : Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        void Initialize(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, object[] behaviors);
    }
    public interface IDictionaryKeyBuilder : Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        string GetKey(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, Castle.Components.DictionaryAdapter.PropertyDescriptor property);
    }
    public interface IDictionaryMetaInitializer : Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        void Initialize(Castle.Components.DictionaryAdapter.IDictionaryAdapterFactory factory, Castle.Components.DictionaryAdapter.DictionaryAdapterMeta dictionaryMeta);
        bool ShouldHaveBehavior(object behavior);
    }
    public interface IDictionaryNotify : System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging
    {
        bool CanNotify { get; }
        bool ShouldNotify { get; }
        void ResumeNotifications();
        void SuppressNotifications();
        System.IDisposable SuppressNotificationsBlock();
    }
    public interface IDictionaryPropertyGetter : Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        object GetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, object storedValue, Castle.Components.DictionaryAdapter.PropertyDescriptor property, bool ifExists);
    }
    public interface IDictionaryPropertySetter : Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        bool SetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, ref object value, Castle.Components.DictionaryAdapter.PropertyDescriptor property);
    }
    public interface IDictionaryReferenceManager
    {
        void AddReference(object keyObject, object relatedObject, bool isInGraph);
        bool IsReferenceProperty(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string propertyName);
        bool TryGetReference(object keyObject, out object inGraphObject);
    }
    public interface IDictionaryValidate : System.ComponentModel.IDataErrorInfo
    {
        bool CanValidate { get; set; }
        bool IsValid { get; }
        System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryValidator> Validators { get; }
        void AddValidator(Castle.Components.DictionaryAdapter.IDictionaryValidator validator);
        Castle.Components.DictionaryAdapter.DictionaryValidateGroup ValidateGroups(params object[] groups);
    }
    public interface IDictionaryValidator
    {
        void Invalidate(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter);
        bool IsValid(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter);
        string Validate(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter);
        string Validate(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, Castle.Components.DictionaryAdapter.PropertyDescriptor property);
    }
    public interface IDynamicValue
    {
        object GetValue();
    }
    public interface IDynamicValue<T> : Castle.Components.DictionaryAdapter.IDynamicValue
    {
        T Value { get; }
    }
    public interface IPropertyDescriptorInitializer : Castle.Components.DictionaryAdapter.IDictionaryBehavior
    {
        void Initialize(Castle.Components.DictionaryAdapter.PropertyDescriptor propertyDescriptor, object[] behaviors);
    }
    public interface IValueInitializer
    {
        void Initialize(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, object value);
    }
    public interface IVirtual
    {
        bool IsReal { get; }
        public event System.EventHandler Realized;
        void Realize();
    }
    public interface IVirtualSite<T>
    {
        void OnRealizing(T node);
    }
    public interface IVirtualTarget<TNode, TMember>
    {
        void OnRealizing(TNode node, TMember member);
    }
    public interface IVirtual<T> : Castle.Components.DictionaryAdapter.IVirtual
    {
        void AddSite(Castle.Components.DictionaryAdapter.IVirtualSite<T> site);
        T Realize();
        void RemoveSite(Castle.Components.DictionaryAdapter.IVirtualSite<T> site);
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false)]
    public class IfExistsAttribute : System.Attribute
    {
        public IfExistsAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class KeyAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder
    {
        public KeyAttribute(string key) { }
        public KeyAttribute(string[] keys) { }
        public string Key { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class KeyPrefixAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder
    {
        public KeyPrefixAttribute() { }
        public KeyPrefixAttribute(string keyPrefix) { }
        public string KeyPrefix { get; set; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=true, Inherited=true)]
    public class KeySubstitutionAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder
    {
        public KeySubstitutionAttribute(string oldValue, string newValue) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}, Adapter = {Adapter}")]
    [System.Diagnostics.DebuggerTypeProxyAttribute(typeof(Castle.Components.DictionaryAdapter.ListProjectionDebugView<T>))]
    public class ListProjection<T> : Castle.Components.DictionaryAdapter.IBindingListSource, Castle.Components.DictionaryAdapter.IBindingList<T>, Castle.Components.DictionaryAdapter.ICollectionAdapterObserver<T>, Castle.Components.DictionaryAdapter.ICollectionProjection, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IBindingList, System.ComponentModel.ICancelAddNew, System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.IRaiseItemChangedEvents, System.ComponentModel.IRevertibleChangeTracking
    {
        public ListProjection(Castle.Components.DictionaryAdapter.ICollectionAdapter<T> adapter) { }
        public Castle.Components.DictionaryAdapter.ICollectionAdapter<T> Adapter { get; }
        public System.ComponentModel.IBindingList AsBindingList { get; }
        public System.Collections.Generic.IEqualityComparer<T> Comparer { get; }
        public int Count { get; }
        public bool EventsEnabled { get; }
        public bool IsChanged { get; }
        public T this[int index] { get; set; }
        public event System.ComponentModel.ListChangedEventHandler ListChanged;
        public void AcceptChanges() { }
        public virtual bool Add(T item) { }
        public virtual T AddNew() { }
        public void BeginEdit() { }
        public void CancelEdit() { }
        public virtual void CancelNew(int index) { }
        public virtual void Clear() { }
        public virtual bool Contains(T item) { }
        public void CopyTo(T[] array, int index) { }
        public void EndEdit() { }
        public virtual void EndNew(int index) { }
        public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }
        public int IndexOf(T item) { }
        public void Insert(int index, T item) { }
        public bool IsNew(int index) { }
        protected void NotifyListChanged(System.ComponentModel.ListChangedType type, int index) { }
        protected void NotifyListReset() { }
        protected virtual void OnInserted(T newValue, int index) { }
        protected virtual bool OnInserting(T value) { }
        protected virtual void OnListChanged(System.ComponentModel.ListChangedEventArgs args) { }
        protected virtual void OnRemoved(T oldValue, int index) { }
        protected virtual void OnRemoving(T oldValue) { }
        protected virtual void OnReplaced(T oldValue, T newValue, int index) { }
        protected virtual bool OnReplacing(T oldValue, T newValue) { }
        public void RejectChanges() { }
        public virtual bool Remove(T item) { }
        public virtual void RemoveAt(int index) { }
        public void Replace(System.Collections.Generic.IEnumerable<T> items) { }
        public bool ResumeEvents() { }
        public void SuspendEvents() { }
    }
    public class MemberwiseEqualityHashCodeStrategy : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryEqualityHashCodeStrategy, Castle.Components.DictionaryAdapter.IDictionaryInitializer, System.Collections.Generic.IEqualityComparer<Castle.Components.DictionaryAdapter.IDictionaryAdapter>
    {
        public MemberwiseEqualityHashCodeStrategy() { }
        public bool Equals(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter1, Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter2) { }
        public int GetHashCode(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter) { }
        public bool GetHashCode(Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter, out int hashCode) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false)]
    public class MultiLevelEditAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryInitializer
    {
        public MultiLevelEditAttribute() { }
        public void Initialize(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, object[] behaviors) { }
    }
    public class NameValueCollectionAdapter : Castle.Components.DictionaryAdapter.AbstractDictionaryAdapter
    {
        public NameValueCollectionAdapter(System.Collections.Specialized.NameValueCollection nameValues) { }
        public override bool IsReadOnly { get; }
        public override object this[object key] { get; set; }
        public static Castle.Components.DictionaryAdapter.NameValueCollectionAdapter Adapt(System.Collections.Specialized.NameValueCollection nameValues) { }
        public override bool Contains(object key) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false)]
    public class NewGuidAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter
    {
        public NewGuidAttribute() { }
        public object GetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, object storedValue, Castle.Components.DictionaryAdapter.PropertyDescriptor property, bool ifExists) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false)]
    public class OnDemandAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter
    {
        public OnDemandAttribute() { }
        public OnDemandAttribute(System.Type type) { }
        public OnDemandAttribute(object value) { }
        public System.Type Type { get; }
        public object Value { get; }
        public object GetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, object storedValue, Castle.Components.DictionaryAdapter.PropertyDescriptor property, bool ifExists) { }
    }
    public class PropertyChangedEventArgsEx : System.ComponentModel.PropertyChangedEventArgs
    {
        public PropertyChangedEventArgsEx(string propertyName, object oldValue, object newValue) { }
        public object NewValue { get; }
        public object OldValue { get; }
    }
    public class PropertyChangingEventArgsEx : System.ComponentModel.PropertyChangingEventArgs
    {
        public PropertyChangingEventArgsEx(string propertyName, object oldValue, object newValue) { }
        public bool Cancel { get; set; }
        public object NewValue { get; }
        public object OldValue { get; }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("{Property.DeclaringType.FullName,nq}.{PropertyName,nq}")]
    public class PropertyDescriptor : Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter
    {
        protected System.Collections.Generic.List<Castle.Components.DictionaryAdapter.IDictionaryBehavior> dictionaryBehaviors;
        public PropertyDescriptor() { }
        public PropertyDescriptor(System.Reflection.PropertyInfo property, object[] annotations) { }
        public PropertyDescriptor(object[] annotations) { }
        public PropertyDescriptor(Castle.Components.DictionaryAdapter.PropertyDescriptor source, bool copyBehaviors) { }
        public object[] Annotations { get; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryBehavior> Behaviors { get; }
        public int ExecutionOrder { get; }
        public System.Collections.IDictionary ExtendedProperties { get; }
        public bool Fetch { get; set; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter> Getters { get; }
        public bool IfExists { get; set; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryInitializer> Initializers { get; }
        public bool IsDynamicProperty { get; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder> KeyBuilders { get; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryMetaInitializer> MetaInitializers { get; }
        public System.Reflection.PropertyInfo Property { get; }
        public string PropertyName { get; }
        public System.Type PropertyType { get; }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryPropertySetter> Setters { get; }
        public System.Collections.IDictionary State { get; }
        public bool SuppressNotifications { get; set; }
        public System.ComponentModel.TypeConverter TypeConverter { get; }
        public Castle.Components.DictionaryAdapter.PropertyDescriptor AddBehavior(Castle.Components.DictionaryAdapter.IDictionaryBehavior behavior) { }
        public Castle.Components.DictionaryAdapter.PropertyDescriptor AddBehaviors(params Castle.Components.DictionaryAdapter.IDictionaryBehavior[] behaviors) { }
        public Castle.Components.DictionaryAdapter.PropertyDescriptor AddBehaviors(System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.IDictionaryBehavior> behaviors) { }
        public Castle.Components.DictionaryAdapter.IDictionaryBehavior Copy() { }
        public Castle.Components.DictionaryAdapter.PropertyDescriptor CopyBehaviors(Castle.Components.DictionaryAdapter.PropertyDescriptor other) { }
        public string GetKey(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor) { }
        public object GetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, object storedValue, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor, bool ifExists) { }
        public static void MergeBehavior<T>(ref System.Collections.Generic.List<T> dictionaryBehaviors, T behavior)
            where T :  class, Castle.Components.DictionaryAdapter.IDictionaryBehavior { }
        public bool SetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, ref object value, Castle.Components.DictionaryAdapter.PropertyDescriptor descriptor) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All)]
    public class ReferenceAttribute : System.Attribute
    {
        public ReferenceAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=true)]
    public class RemoveIfAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter
    {
        public RemoveIfAttribute() { }
        public RemoveIfAttribute(params object[] values) { }
        public RemoveIfAttribute(object[] values, System.Type comparerType) { }
        protected RemoveIfAttribute(Castle.Components.DictionaryAdapter.ICondition condition) { }
        public System.Type Condition { set; }
    }
    public class RemoveIfEmptyAttribute : Castle.Components.DictionaryAdapter.RemoveIfAttribute
    {
        public RemoveIfEmptyAttribute() { }
    }
    public class SetProjection<T> : Castle.Components.DictionaryAdapter.ListProjection<T>, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.ISet<T>, System.Collections.IEnumerable
    {
        public SetProjection(Castle.Components.DictionaryAdapter.ICollectionAdapter<T> adapter) { }
        public override bool Add(T item) { }
        public override void Clear() { }
        public override bool Contains(T item) { }
        public override void EndNew(int index) { }
        public void ExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        public void IntersectWith(System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsProperSubsetOf(System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsProperSupersetOf(System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsSubsetOf(System.Collections.Generic.IEnumerable<T> other) { }
        public bool IsSupersetOf(System.Collections.Generic.IEnumerable<T> other) { }
        protected override bool OnInserting(T value) { }
        protected override bool OnReplacing(T oldValue, T newValue) { }
        public bool Overlaps(System.Collections.Generic.IEnumerable<T> other) { }
        public override bool Remove(T item) { }
        public override void RemoveAt(int index) { }
        public bool SetEquals(System.Collections.Generic.IEnumerable<T> other) { }
        public void SymmetricExceptWith(System.Collections.Generic.IEnumerable<T> other) { }
        public void UnionWith(System.Collections.Generic.IEnumerable<T> other) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false, Inherited=false)]
    public class StringFormatAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter
    {
        public StringFormatAttribute(string format, string properties) { }
        public string Format { get; }
        public string Properties { get; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class StringListAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter
    {
        public StringListAttribute() { }
        public char Separator { get; set; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false)]
    public class StringStorageAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter
    {
        public StringStorageAttribute() { }
        public bool SetPropertyValue(Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter, string key, ref object value, Castle.Components.DictionaryAdapter.PropertyDescriptor property) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class StringValuesAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter
    {
        public StringValuesAttribute() { }
        public string Format { get; set; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.All, AllowMultiple=false)]
    public class SuppressNotificationsAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IPropertyDescriptorInitializer
    {
        public SuppressNotificationsAttribute() { }
        public void Initialize(Castle.Components.DictionaryAdapter.PropertyDescriptor propertyDescriptor, object[] behaviors) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false, Inherited=true)]
    public class TypeKeyPrefixAttribute : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryKeyBuilder
    {
        public TypeKeyPrefixAttribute() { }
    }
    public abstract class VirtualObject<TNode> : Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.IVirtual<TNode>
    {
        protected VirtualObject() { }
        protected VirtualObject(Castle.Components.DictionaryAdapter.IVirtualSite<TNode> site) { }
        public abstract bool IsReal { get; }
        public event System.EventHandler Realized;
        protected void AddSite(Castle.Components.DictionaryAdapter.IVirtualSite<TNode> site) { }
        protected virtual void OnRealized() { }
        public TNode Realize() { }
        protected void RemoveSite(Castle.Components.DictionaryAdapter.IVirtualSite<TNode> site) { }
        protected abstract bool TryRealize(out TNode node);
    }
    public sealed class VirtualSite<TNode, TMember> : Castle.Components.DictionaryAdapter.IVirtualSite<TNode>, System.IEquatable<Castle.Components.DictionaryAdapter.VirtualSite<TNode, TMember>>
    {
        public VirtualSite(Castle.Components.DictionaryAdapter.IVirtualTarget<TNode, TMember> target, TMember member) { }
        public TMember Member { get; }
        public Castle.Components.DictionaryAdapter.IVirtualTarget<TNode, TMember> Target { get; }
        public override bool Equals(object obj) { }
        public bool Equals(Castle.Components.DictionaryAdapter.VirtualSite<TNode, TMember> other) { }
        public override int GetHashCode() { }
        public void OnRealizing(TNode node) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=false)]
    public class VolatileAttribute : System.Attribute
    {
        public VolatileAttribute() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Interface | System.AttributeTargets.All)]
    public class XmlDefaultsAttribute : System.Attribute
    {
        public XmlDefaultsAttribute() { }
        public bool IsNullable { get; set; }
        public bool Qualified { get; set; }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=true)]
    public class XmlNamespaceAttribute : System.Attribute
    {
        public XmlNamespaceAttribute(string namespaceUri, string prefix) { }
        public bool Default { get; set; }
        public string NamespaceUri { get; }
        public string Prefix { get; }
        public bool Root { get; set; }
    }
}
namespace Castle.Components.DictionaryAdapter.Xml
{
    public class CompiledXPath
    {
        public int Depth { get; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPathStep FirstStep { get; }
        public bool IsCreatable { get; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPathStep LastStep { get; }
        public System.Xml.XPath.XPathExpression Path { get; }
        public void SetContext(System.Xml.Xsl.XsltContext context) { }
    }
    public class CompiledXPathNode
    {
        public System.Collections.Generic.IList<Castle.Components.DictionaryAdapter.Xml.CompiledXPathNode> Dependencies { get; }
        public bool IsAttribute { get; }
        public bool IsSelfReference { get; }
        public bool IsSimple { get; }
        public string LocalName { get; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPathNode NextNode { get; }
        public string Prefix { get; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPathNode PreviousNode { get; }
        public System.Xml.XPath.XPathExpression Value { get; }
    }
    public class CompiledXPathStep : Castle.Components.DictionaryAdapter.Xml.CompiledXPathNode
    {
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPathStep NextStep { get; }
        public System.Xml.XPath.XPathExpression Path { get; }
    }
    [System.FlagsAttribute()]
    public enum CursorFlags
    {
        None = 0,
        Elements = 1,
        Attributes = 2,
        Multiple = 4,
        Mutable = 8,
        AllNodes = 3,
    }
    public class static CursorFlagsExtensions
    {
        public static bool AllowsMultipleItems(this Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public static bool IncludesAttributes(this Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public static bool IncludesElements(this Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public static Castle.Components.DictionaryAdapter.Xml.CursorFlags MutableIf(this Castle.Components.DictionaryAdapter.Xml.CursorFlags flags, bool mutable) { }
        public static bool SupportsMutation(this Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
    }
    public sealed class DefaultXmlReferenceFormat : Castle.Components.DictionaryAdapter.Xml.IXmlReferenceFormat
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.DefaultXmlReferenceFormat Instance;
        public void ClearIdentity(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public void ClearReference(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public void SetIdentity(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, int id) { }
        public void SetReference(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, int id) { }
        public bool TryGetIdentity(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, out int id) { }
        public bool TryGetReference(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, out int id) { }
    }
    public class static DictionaryAdapterExtensions
    {
        public static object CreateChildAdapter(this Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, System.Type type, Castle.Components.DictionaryAdapter.Xml.XmlAdapter adapter) { }
        public static object CreateChildAdapter(this Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, System.Type type, Castle.Components.DictionaryAdapter.Xml.XmlAdapter adapter, System.Collections.IDictionary dictionary) { }
        public static Castle.Components.DictionaryAdapter.Xml.XmlAccessor GetAccessor(this Castle.Components.DictionaryAdapter.PropertyDescriptor property) { }
        public static Castle.Components.DictionaryAdapter.Xml.XmlMetadata GetXmlMeta(this Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta) { }
        public static string GetXmlType(this Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta) { }
        public static bool HasAccessor(this Castle.Components.DictionaryAdapter.PropertyDescriptor property) { }
        public static bool HasXmlMeta(this Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta) { }
        public static bool HasXmlType(this Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta) { }
        public static void SetAccessor(this Castle.Components.DictionaryAdapter.PropertyDescriptor property, Castle.Components.DictionaryAdapter.Xml.XmlAccessor accessor) { }
        public static void SetXmlMeta(this Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta, Castle.Components.DictionaryAdapter.Xml.XmlMetadata xmlMeta) { }
        public static void SetXmlType(this Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta, string value) { }
    }
    public interface IConfigurable<T>
    {
        void Configure(T value);
    }
    public interface IRealizableSource
    {
        Castle.Components.DictionaryAdapter.Xml.IRealizable<T> AsRealizable<T>();
    }
    public interface IRealizable<T> : Castle.Components.DictionaryAdapter.Xml.IRealizableSource
    {
        bool IsReal { get; }
        T Value { get; }
    }
    public interface IXmlAccessor
    {
        System.Type ClrType { get; }
        Castle.Components.DictionaryAdapter.Xml.IXmlContext Context { get; }
        bool IsNillable { get; }
        bool IsReference { get; }
        Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer Serializer { get; }
        Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType);
        object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool nodeExists, bool orStub);
        void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlCursor cursor, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool hasCurrent, object oldValue, ref object newValue);
    }
    public interface IXmlBehaviorSemantics<T>
    {
        System.Type GetClrType(T behavior);
        string GetLocalName(T behavior);
        string GetNamespaceUri(T behavior);
    }
    public interface IXmlCollectionAccessor : Castle.Components.DictionaryAdapter.Xml.IXmlAccessor
    {
        void GetCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, System.Collections.IList values);
        Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, bool mutable);
    }
    public interface IXmlContext : Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource
    {
        string ChildNamespaceUri { get; }
        void AddFunction(Castle.Components.DictionaryAdapter.Xml.XPathFunctionAttribute attribute);
        void AddVariable(Castle.Components.DictionaryAdapter.Xml.XPathVariableAttribute attribute);
        Castle.Components.DictionaryAdapter.Xml.IXmlContext Clone();
        void Enlist(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path);
        Castle.Components.DictionaryAdapter.Xml.XmlName GetDefaultXsiType(System.Type clrType);
        System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType> GetIncludedTypes(System.Type baseType);
        bool IsReservedNamespaceUri(string namespaceUri);
    }
    public interface IXmlCursor : Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlIterator, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        void Coerce(System.Type type);
        void Create(System.Type type);
        void MoveTo(Castle.Components.DictionaryAdapter.Xml.IXmlNode node);
        void MoveToEnd();
        void Remove();
        void RemoveAllNext();
        void Reset();
    }
    public interface IXmlIdentity
    {
        Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
    }
    public interface IXmlIncludedType
    {
        System.Type ClrType { get; }
        Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
    }
    public interface IXmlIncludedTypeMap
    {
        Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType Default { get; }
        bool TryGet(Castle.Components.DictionaryAdapter.Xml.XmlName xsiType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType);
        bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType);
    }
    public interface IXmlIterator : Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        bool MoveNext();
    }
    public interface IXmlKnownType : Castle.Components.DictionaryAdapter.Xml.IXmlIdentity
    {
        System.Type ClrType { get; }
    }
    public interface IXmlKnownTypeMap
    {
        Castle.Components.DictionaryAdapter.Xml.IXmlKnownType Default { get; }
        bool TryGet(Castle.Components.DictionaryAdapter.Xml.IXmlIdentity xmlNode, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType);
        bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType);
    }
    public interface IXmlNamespaceSource
    {
        string GetAttributePrefix(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, string namespaceUri);
        string GetElementPrefix(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, string namespaceUri);
    }
    public interface IXmlNode : Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType
    {
        bool IsAttribute { get; }
        bool IsElement { get; }
        bool IsNil { get; set; }
        Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource Namespaces { get; }
        Castle.Components.DictionaryAdapter.Xml.IXmlNode Parent { get; }
        Castle.Components.DictionaryAdapter.Xml.CompiledXPath Path { get; }
        object UnderlyingObject { get; }
        string Value { get; set; }
        string Xml { get; }
        void Clear();
        void DefineNamespace(string prefix, string namespaceUri, bool root);
        object Evaluate(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path);
        string GetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name);
        string LookupNamespaceUri(string prefix);
        string LookupPrefix(string namespaceUri);
        System.Xml.XmlReader ReadSubtree();
        Castle.Components.DictionaryAdapter.Xml.IXmlNode Save();
        Castle.Components.DictionaryAdapter.Xml.IXmlCursor Select(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap includedTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags);
        Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectChildren(Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap knownTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags);
        Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectSelf(System.Type clrType);
        Castle.Components.DictionaryAdapter.Xml.IXmlIterator SelectSubtree();
        void SetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name, string value);
        bool UnderlyingPositionEquals(Castle.Components.DictionaryAdapter.Xml.IXmlNode node);
        System.Xml.XmlWriter WriteAttributes();
        System.Xml.XmlWriter WriteChildren();
    }
    public interface IXmlNodeSource
    {
        Castle.Components.DictionaryAdapter.Xml.IXmlNode Node { get; }
    }
    public interface IXmlPropertyAccessor : Castle.Components.DictionaryAdapter.Xml.IXmlAccessor
    {
        object GetPropertyValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool orStub);
        void SetPropertyValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, object oldValue, ref object newValue);
    }
    public interface IXmlReferenceFormat
    {
        void ClearIdentity(Castle.Components.DictionaryAdapter.Xml.IXmlNode node);
        void ClearReference(Castle.Components.DictionaryAdapter.Xml.IXmlNode node);
        void SetIdentity(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, int id);
        void SetReference(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, int id);
        bool TryGetIdentity(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, out int id);
        bool TryGetReference(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, out int id);
    }
    public class static RealizableExtensions
    {
        public static Castle.Components.DictionaryAdapter.Xml.IRealizable<T> RequireRealizable<T>(this Castle.Components.DictionaryAdapter.Xml.IRealizableSource obj) { }
    }
    public class SingletonDispenser<TKey, TItem>
        where TItem :  class
    {
        public SingletonDispenser(System.Func<TKey, TItem> factory) { }
        public TItem this[TKey key] { get; set; }
    }
    public class SysXmlCursor : Castle.Components.DictionaryAdapter.Xml.SysXmlNode, Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlCursor, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlIterator, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        protected static readonly System.StringComparer DefaultComparer;
        public SysXmlCursor(Castle.Components.DictionaryAdapter.Xml.IXmlNode parent, Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap knownTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public override System.Type ClrType { get; }
        public bool HasCurrent { get; }
        public override bool IsAttribute { get; }
        public override bool IsElement { get; }
        public override bool IsNil { get; set; }
        public override bool IsReal { get; }
        public override Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public override string Value { get; set; }
        public override string Xml { get; }
        public override Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
        public event System.EventHandler Realized;
        protected virtual bool AdvanceToFirstAttribute() { }
        protected virtual bool AdvanceToFirstElement() { }
        public void Coerce(System.Type clrType) { }
        public void Create(System.Type type) { }
        public override object Evaluate(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path) { }
        public void MakeNext(System.Type clrType) { }
        public bool MoveNext() { }
        public void MoveTo(Castle.Components.DictionaryAdapter.Xml.IXmlNode position) { }
        public void MoveToEnd() { }
        protected virtual void OnRealized() { }
        protected override void Realize() { }
        public void Remove() { }
        public void RemoveAllNext() { }
        public void Reset() { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlNode Save() { }
        protected enum State
        {
            Empty = -4,
            End = -3,
            AttributePrimed = -2,
            ElementPrimed = -1,
            Initial = 0,
            Element = 1,
            Attribute = 2,
        }
    }
    public class static SysXmlExtensions
    {
        public static void DefineNamespace(this System.Xml.XmlElement node, string prefix, string namespaceUri) { }
        public static System.Xml.XmlElement FindRoot(this System.Xml.XmlElement node) { }
        public static bool IsNamespace(this System.Xml.XmlAttribute attribute) { }
        public static bool IsXsiType(this System.Xml.XmlAttribute attribute) { }
    }
    public class SysXmlNode : Castle.Components.DictionaryAdapter.Xml.XmlNodeBase, Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IRealizable<System.Xml.XPath.XPathNavigator>, Castle.Components.DictionaryAdapter.Xml.IRealizable<System.Xml.XmlNode>, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        protected System.Xml.XmlNode node;
        protected SysXmlNode(Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.IXmlNode parent) { }
        public SysXmlNode(System.Xml.XmlNode node, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces) { }
        public virtual bool IsAttribute { get; }
        public virtual bool IsElement { get; }
        public virtual bool IsNil { get; set; }
        public virtual Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public object UnderlyingObject { get; }
        public virtual string Value { get; set; }
        public virtual string Xml { get; }
        public virtual Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
        public void Clear() { }
        public void DefineNamespace(string prefix, string namespaceUri, bool root) { }
        public virtual object Evaluate(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path) { }
        public string GetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name) { }
        public System.Xml.XmlNode GetNode() { }
        public string LookupNamespaceUri(string prefix) { }
        public string LookupPrefix(string namespaceUri) { }
        public System.Xml.XmlReader ReadSubtree() { }
        public virtual Castle.Components.DictionaryAdapter.Xml.IXmlNode Save() { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor Select(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap includedTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectChildren(Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap knownTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectSelf(System.Type clrType) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlIterator SelectSubtree() { }
        public void SetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name, string value) { }
        public bool UnderlyingPositionEquals(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public System.Xml.XmlWriter WriteAttributes() { }
        public System.Xml.XmlWriter WriteChildren() { }
    }
    public class SysXmlSubtreeIterator : Castle.Components.DictionaryAdapter.Xml.SysXmlNode, Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlIterator, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        public SysXmlSubtreeIterator(Castle.Components.DictionaryAdapter.Xml.IXmlNode parent, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces) { }
        public bool MoveNext() { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlNode Save() { }
    }
    public class static Try
    {
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public static bool Failure<T>(out T result) { }
        [System.Diagnostics.DebuggerHiddenAttribute()]
        public static bool Success<T>(out T result, T value) { }
    }
    public class static TypeExtensions
    {
        public static System.Type GetCollectionItemType(this System.Type type) { }
        public static System.Type GetComponentType(this object obj) { }
        public static System.Type NonNullable(this System.Type type) { }
    }
    public class static Wsdl
    {
        public const string NamespaceUri = "http://microsoft.com/wsdl/types/";
        public const string Prefix = "wsdl";
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=true)]
    public class XPathAttribute : System.Attribute
    {
        public XPathAttribute(string path) { }
        public XPathAttribute(string get, string set) { }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPath GetPath { get; }
        public bool Nullable { get; set; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPath SetPath { get; }
    }
    public class XPathBehaviorAccessor : Castle.Components.DictionaryAdapter.Xml.XmlAccessor, Castle.Components.DictionaryAdapter.Xml.IConfigurable<Castle.Components.DictionaryAdapter.Xml.XPathAttribute>, Castle.Components.DictionaryAdapter.Xml.IConfigurable<Castle.Components.DictionaryAdapter.Xml.XPathFunctionAttribute>, Castle.Components.DictionaryAdapter.Xml.IConfigurable<Castle.Components.DictionaryAdapter.Xml.XPathVariableAttribute>, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap
    {
        protected XPathBehaviorAccessor(System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public void Configure(Castle.Components.DictionaryAdapter.Xml.XPathAttribute attribute) { }
        public void Configure(Castle.Components.DictionaryAdapter.Xml.XPathVariableAttribute attribute) { }
        public void Configure(Castle.Components.DictionaryAdapter.Xml.XPathFunctionAttribute attribute) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType) { }
        public override object GetPropertyValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool orStub) { }
        public override bool IsPropertyDefined(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode) { }
        public override void Prepare() { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool create) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool create) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool create) { }
        public override void SetPropertyValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, object oldValue, ref object value) { }
        public bool TryGet(Castle.Components.DictionaryAdapter.Xml.XmlName xsiType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
        public bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
    }
    public class static XPathCompiler
    {
        public static Castle.Components.DictionaryAdapter.Xml.CompiledXPath Compile(string path) { }
    }
    public class static XPathExtensions
    {
        public static System.Xml.XPath.XPathNavigator CreateNavigatorSafe(this System.Xml.XPath.IXPathNavigable source) { }
        public static void DeleteChildren(this System.Xml.XPath.XPathNavigator node) { }
        public static System.Xml.XPath.XPathNavigator GetParent(this System.Xml.XPath.XPathNavigator navigator) { }
        public static System.Xml.XPath.XPathNavigator GetRootElement(this System.Xml.XPath.XPathNavigator navigator) { }
        public static bool MoveToLastAttribute(this System.Xml.XPath.XPathNavigator navigator) { }
        public static bool MoveToLastChild(this System.Xml.XPath.XPathNavigator navigator) { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=true)]
    public abstract class XPathFunctionAttribute : System.Attribute, System.Xml.Xsl.IXsltContextFunction
    {
        public static readonly System.Xml.XPath.XPathResultType[] NoArgs;
        protected XPathFunctionAttribute() { }
        public virtual System.Xml.XPath.XPathResultType[] ArgTypes { get; }
        public virtual int Maxargs { get; }
        public virtual int Minargs { get; }
        public abstract Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public abstract System.Xml.XPath.XPathResultType ReturnType { get; }
        public abstract object Invoke(System.Xml.Xsl.XsltContext context, object[] args, System.Xml.XPath.XPathNavigator node);
    }
    public class XPathNode : Castle.Components.DictionaryAdapter.Xml.XmlNodeBase, Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IRealizable<System.Xml.XPath.XPathNavigator>, Castle.Components.DictionaryAdapter.Xml.IRealizable<System.Xml.XmlNode>, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        protected System.Xml.XPath.XPathNavigator node;
        protected readonly Castle.Components.DictionaryAdapter.Xml.CompiledXPath xpath;
        protected XPathNode(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.IXmlNode parent) { }
        public XPathNode(System.Xml.XPath.XPathNavigator node, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces) { }
        public virtual bool IsAttribute { get; }
        public virtual bool IsElement { get; }
        public virtual bool IsNil { get; set; }
        public virtual Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public override Castle.Components.DictionaryAdapter.Xml.CompiledXPath Path { get; }
        public object UnderlyingObject { get; }
        public virtual string Value { get; set; }
        public virtual string Xml { get; }
        public virtual Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
        public virtual void Clear() { }
        public void DefineNamespace(string prefix, string namespaceUri, bool root) { }
        public virtual object Evaluate(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path) { }
        public string GetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name) { }
        public string LookupNamespaceUri(string prefix) { }
        public string LookupPrefix(string namespaceUri) { }
        public virtual System.Xml.XmlReader ReadSubtree() { }
        public virtual Castle.Components.DictionaryAdapter.Xml.IXmlNode Save() { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor Select(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap includedTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectChildren(Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap knownTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectSelf(System.Type clrType) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlIterator SelectSubtree() { }
        public void SetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name, string value) { }
        public bool UnderlyingPositionEquals(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public virtual System.Xml.XmlWriter WriteAttributes() { }
        public virtual System.Xml.XmlWriter WriteChildren() { }
    }
    public class XPathReadOnlyCursor : Castle.Components.DictionaryAdapter.Xml.XPathNode, Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlCursor, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlIterator, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        public XPathReadOnlyCursor(Castle.Components.DictionaryAdapter.Xml.IXmlNode parent, Castle.Components.DictionaryAdapter.Xml.CompiledXPath path, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap includedTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public void Coerce(System.Type type) { }
        public void Create(System.Type type) { }
        public void MakeNext(System.Type type) { }
        public bool MoveNext() { }
        public void MoveTo(Castle.Components.DictionaryAdapter.Xml.IXmlNode position) { }
        public void MoveToEnd() { }
        public void Remove() { }
        public void RemoveAllNext() { }
        public void Reset() { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlNode Save() { }
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Property | System.AttributeTargets.Interface | System.AttributeTargets.All, AllowMultiple=true)]
    public abstract class XPathVariableAttribute : System.Attribute, System.Xml.Xsl.IXsltContextVariable
    {
        protected XPathVariableAttribute() { }
        public abstract Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public abstract System.Xml.XPath.XPathResultType VariableType { get; }
        public abstract object Evaluate(System.Xml.Xsl.XsltContext context);
    }
    public class static XRef
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlName Id;
        public const string NamespaceUri = "urn:schemas-castle-org:xml-reference";
        public const string Prefix = "x";
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlName Ref;
        public static string GetId(this Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public static string GetReference(this Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public static void SetId(this Castle.Components.DictionaryAdapter.Xml.IXmlCursor node, string id) { }
        public static void SetReference(this Castle.Components.DictionaryAdapter.Xml.IXmlCursor cursor, string id) { }
    }
    public abstract class XmlAccessor : Castle.Components.DictionaryAdapter.Xml.IXmlAccessor, Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor, Castle.Components.DictionaryAdapter.Xml.IXmlPropertyAccessor
    {
        protected Castle.Components.DictionaryAdapter.Xml.XmlAccessor.States state;
        protected XmlAccessor(System.Type clrType, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public System.Type ClrType { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlContext Context { get; set; }
        public bool IsCollection { get; }
        public virtual bool IsIgnored { get; }
        public bool IsNillable { get; }
        public bool IsReference { get; }
        public bool IsVolatile { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer Serializer { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
        protected Castle.Components.DictionaryAdapter.Xml.IXmlContext CloneContext() { }
        public virtual void ConfigureNillable(bool nillable) { }
        public virtual void ConfigureReference(bool isReference) { }
        public void ConfigureVolatile(bool isVolatile) { }
        public virtual Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType) { }
        public void GetCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, System.Collections.IList values) { }
        protected Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetDefaultCollectionAccessor(System.Type itemType) { }
        public virtual object GetPropertyValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool orStub) { }
        public object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool nodeExists, bool orStub) { }
        public virtual bool IsPropertyDefined(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode) { }
        public virtual void Prepare() { }
        protected void RemoveCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, object value) { }
        public virtual Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, bool mutable) { }
        public virtual Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, bool mutable) { }
        public virtual Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, bool mutable) { }
        public virtual void SetPropertyValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, object oldValue, ref object value) { }
        public virtual void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlCursor cursor, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool hasCurrent, object oldValue, ref object newValue) { }
        [System.FlagsAttribute()]
        protected enum States
        {
            Nillable = 1,
            Volatile = 2,
            Reference = 4,
            ConfiguredContext = 8,
            ConfiguredLocalName = 16,
            ConfiguredNamespaceUri = 32,
            ConfiguredKnownTypes = 64,
        }
    }
    public delegate TAccessor XmlAccessorFactory<TAccessor>(string name, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context);
    public class XmlAdapter : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryCopyStrategy, Castle.Components.DictionaryAdapter.IDictionaryCreateStrategy, Castle.Components.DictionaryAdapter.IDictionaryInitializer, Castle.Components.DictionaryAdapter.IDictionaryPropertyGetter, Castle.Components.DictionaryAdapter.IDictionaryPropertySetter, Castle.Components.DictionaryAdapter.IDictionaryReferenceManager, Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IXmlNodeSource
    {
        public XmlAdapter() { }
        public XmlAdapter(System.Xml.XmlNode node) { }
        public XmlAdapter(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references) { }
        public bool IsReal { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlNode Node { get; }
        public event System.EventHandler Realized;
        public override Castle.Components.DictionaryAdapter.IDictionaryBehavior Copy() { }
        public static Castle.Components.DictionaryAdapter.Xml.XmlAdapter For(object obj) { }
        public static Castle.Components.DictionaryAdapter.Xml.XmlAdapter For(object obj, bool required) { }
        public bool HasProperty(string propertyName, Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter) { }
        public static bool IsPropertyDefined(string propertyName, Castle.Components.DictionaryAdapter.IDictionaryAdapter dictionaryAdapter) { }
        protected virtual void OnRealized() { }
    }
    public class XmlArrayBehaviorAccessor : Castle.Components.DictionaryAdapter.Xml.XmlNodeAccessor, Castle.Components.DictionaryAdapter.Xml.IConfigurable<System.Xml.Serialization.XmlArrayAttribute>, Castle.Components.DictionaryAdapter.Xml.IConfigurable<System.Xml.Serialization.XmlArrayItemAttribute>
    {
        public XmlArrayBehaviorAccessor(string name, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public void Configure(System.Xml.Serialization.XmlArrayAttribute attribute) { }
        public void Configure(System.Xml.Serialization.XmlArrayItemAttribute attribute) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType) { }
        public override void Prepare() { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
    }
    public class XmlArraySerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlArraySerializer Instance;
        protected XmlArraySerializer() { }
        public override bool CanGetStub { get; }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetStub(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlAttributeBehaviorAccessor : Castle.Components.DictionaryAdapter.Xml.XmlNodeAccessor, Castle.Components.DictionaryAdapter.Xml.IConfigurable<System.Xml.Serialization.XmlAttributeAttribute>
    {
        public XmlAttributeBehaviorAccessor(string name, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public void Configure(System.Xml.Serialization.XmlAttributeAttribute attribute) { }
        public override void ConfigureNillable(bool nillable) { }
        public override void ConfigureReference(bool isReference) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
    }
    public abstract class XmlCollectionSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        protected XmlCollectionSerializer() { }
        public override bool CanGetStub { get; }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public abstract System.Type ListTypeConstructor { get; }
        public override object GetStub(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlComponentSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlComponentSerializer Instance;
        protected XmlComponentSerializer() { }
        public override bool CanGetStub { get; }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetStub(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlContext : Castle.Components.DictionaryAdapter.Xml.XmlContextBase, Castle.Components.DictionaryAdapter.Xml.IXmlContext, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource
    {
        public XmlContext(Castle.Components.DictionaryAdapter.Xml.XmlMetadata metadata) { }
        protected XmlContext(Castle.Components.DictionaryAdapter.Xml.XmlContext parent) { }
        public string ChildNamespaceUri { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlContext Clone() { }
        public Castle.Components.DictionaryAdapter.Xml.XmlName GetDefaultXsiType(System.Type clrType) { }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType> GetIncludedTypes(System.Type baseType) { }
        public bool IsReservedNamespaceUri(string namespaceUri) { }
    }
    public class XmlContextBase : System.Xml.Xsl.XsltContext, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource
    {
        public XmlContextBase() { }
        protected XmlContextBase(Castle.Components.DictionaryAdapter.Xml.XmlContextBase parent) { }
        public override bool Whitespace { get; }
        public void AddFunction(string prefix, string name, System.Xml.Xsl.IXsltContextFunction function) { }
        public void AddFunction(Castle.Components.DictionaryAdapter.Xml.XPathFunctionAttribute attribute) { }
        public void AddFunction(Castle.Components.DictionaryAdapter.Xml.XmlName name, System.Xml.Xsl.IXsltContextFunction function) { }
        public void AddNamespace(Castle.Components.DictionaryAdapter.XmlNamespaceAttribute attribute) { }
        public override void AddNamespace(string prefix, string uri) { }
        public void AddVariable(string prefix, string name, System.Xml.Xsl.IXsltContextVariable variable) { }
        public void AddVariable(Castle.Components.DictionaryAdapter.Xml.XPathVariableAttribute attribute) { }
        public void AddVariable(Castle.Components.DictionaryAdapter.Xml.XmlName name, System.Xml.Xsl.IXsltContextVariable variable) { }
        public override int CompareDocument(string baseUriA, string baseUriB) { }
        public void Enlist(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path) { }
        public string GetAttributePrefix(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, string namespaceUri) { }
        public string GetElementPrefix(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, string namespaceUri) { }
        public override string LookupNamespace(string prefix) { }
        public override string LookupPrefix(string uri) { }
        public override bool PreserveWhitespace(System.Xml.XPath.XPathNavigator node) { }
        public override System.Xml.Xsl.IXsltContextFunction ResolveFunction(string prefix, string name, System.Xml.XPath.XPathResultType[] argTypes) { }
        public override System.Xml.Xsl.IXsltContextVariable ResolveVariable(string prefix, string name) { }
    }
    public class XmlCustomSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlCustomSerializer Instance;
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlDefaultBehaviorAccessor : Castle.Components.DictionaryAdapter.Xml.XmlNodeAccessor
    {
        public XmlDefaultBehaviorAccessor(System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public XmlDefaultBehaviorAccessor(string name, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
    }
    public class XmlDefaultSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly System.Xml.Serialization.XmlRootAttribute Root;
        public XmlDefaultSerializer(System.Type type) { }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlDynamicSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlDynamicSerializer Instance;
        protected XmlDynamicSerializer() { }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlElementBehaviorAccessor : Castle.Components.DictionaryAdapter.Xml.XmlNodeAccessor, Castle.Components.DictionaryAdapter.Xml.IConfigurable<System.Xml.Serialization.XmlElementAttribute>, Castle.Components.DictionaryAdapter.Xml.IXmlBehaviorSemantics<System.Xml.Serialization.XmlElementAttribute>
    {
        public XmlElementBehaviorAccessor(string name, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public void Configure(System.Xml.Serialization.XmlElementAttribute attribute) { }
        public System.Type GetClrType(System.Xml.Serialization.XmlElementAttribute attribute) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType) { }
        public string GetLocalName(System.Xml.Serialization.XmlElementAttribute attribute) { }
        public string GetNamespaceUri(System.Xml.Serialization.XmlElementAttribute attribute) { }
        public override void Prepare() { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlCursor cursor, Castle.Components.DictionaryAdapter.IDictionaryAdapter parentObject, Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager references, bool hasCurrent, object oldValue, ref object newValue) { }
    }
    public class XmlEnumerationSerializer : Castle.Components.DictionaryAdapter.Xml.XmlStringSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlEnumerationSerializer Instance;
        protected XmlEnumerationSerializer() { }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
    }
    public class XmlIgnoreBehaviorAccessor : Castle.Components.DictionaryAdapter.Xml.XmlAccessor
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlIgnoreBehaviorAccessor Instance;
        public override bool IsIgnored { get; }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCollectionAccessor GetCollectionAccessor(System.Type itemType) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionItems(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectCollectionNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool mutable) { }
    }
    public class XmlIncludedType : Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType
    {
        public XmlIncludedType(Castle.Components.DictionaryAdapter.Xml.XmlName xsiType, System.Type clrType) { }
        public XmlIncludedType(string localName, string namespaceUri, System.Type clrType) { }
        public System.Type ClrType { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
    }
    public class static XmlIncludedTypeMapExtensions
    {
        public static Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType Require(this Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap includedTypes, System.Type clrType) { }
    }
    public class XmlIncludedTypeSet : Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap, System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType>, System.Collections.IEnumerable
    {
        public static readonly System.Collections.Generic.IList<Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType> DefaultEntries;
        public XmlIncludedTypeSet() { }
        public void Add(Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
        public System.Collections.Generic.IEnumerator<Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType> GetEnumerator() { }
        public bool TryGet(Castle.Components.DictionaryAdapter.Xml.XmlName xsiType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
        public bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
    }
    public class XmlKnownType : Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType
    {
        public XmlKnownType(Castle.Components.DictionaryAdapter.Xml.XmlName name, Castle.Components.DictionaryAdapter.Xml.XmlName xsiType, System.Type clrType) { }
        public XmlKnownType(string nameLocalName, string nameNamespaceUri, string xsiTypeLocalName, string xsiTypeNamespaceUri, System.Type clrType) { }
        public System.Type ClrType { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
    }
    public class static XmlKnownTypeMapExtensions
    {
        public static Castle.Components.DictionaryAdapter.Xml.IXmlKnownType Require(this Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap map, System.Type clrType) { }
    }
    public class XmlKnownTypeSet : Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap, System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.Xml.IXmlKnownType>, System.Collections.IEnumerable
    {
        public XmlKnownTypeSet(System.Type defaultType) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlKnownType Default { get; }
        public void Add(Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType, bool overwrite) { }
        public void AddXsiTypeDefaults() { }
        public System.Collections.Generic.IEnumerator<Castle.Components.DictionaryAdapter.Xml.IXmlKnownType> GetEnumerator() { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlKnownType[] ToArray() { }
        public bool TryGet(Castle.Components.DictionaryAdapter.Xml.IXmlIdentity xmlIdentity, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType) { }
        public bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType) { }
    }
    public class XmlListSerializer : Castle.Components.DictionaryAdapter.Xml.XmlCollectionSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlListSerializer Instance;
        protected XmlListSerializer() { }
        public override System.Type ListTypeConstructor { get; }
    }
    public class XmlMetadata : Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap
    {
        protected static readonly System.StringComparer NameComparer;
        public XmlMetadata(Castle.Components.DictionaryAdapter.DictionaryAdapterMeta meta, System.Collections.Generic.IEnumerable<string> reservedNamespaceUris) { }
        public string ChildNamespaceUri { get; }
        public System.Type ClrType { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlContext Context { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlIncludedTypeSet IncludedTypes { get; }
        public System.Nullable<bool> IsNullable { get; }
        public System.Nullable<bool> IsReference { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPath Path { get; }
        public System.Nullable<bool> Qualified { get; }
        public System.Collections.Generic.IEnumerable<string> ReservedNamespaceUris { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName GetDefaultXsiType(System.Type clrType) { }
        public System.Collections.Generic.IEnumerable<Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType> GetIncludedTypes(System.Type baseType) { }
        public bool IsReservedNamespaceUri(string namespaceUri) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectBase(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public bool TryGet(Castle.Components.DictionaryAdapter.Xml.IXmlIdentity xmlIdentity, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType) { }
        public bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType) { }
        public bool TryGet(Castle.Components.DictionaryAdapter.Xml.XmlName xsiType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
        public bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlIncludedType includedType) { }
    }
    public class XmlMetadataBehavior : Castle.Components.DictionaryAdapter.DictionaryBehaviorAttribute, Castle.Components.DictionaryAdapter.IDictionaryBehavior, Castle.Components.DictionaryAdapter.IDictionaryMetaInitializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlMetadataBehavior Default;
        public XmlMetadataBehavior() { }
        public System.Collections.Generic.IEnumerable<string> ReservedNamespaceUris { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlMetadataBehavior AddReservedNamespaceUri(string uri) { }
    }
    public struct XmlName : System.IEquatable<Castle.Components.DictionaryAdapter.Xml.XmlName>
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlName Empty;
        public XmlName(string localName, string namespaceUri) { }
        public string LocalName { get; }
        public string NamespaceUri { get; }
        public bool Equals(Castle.Components.DictionaryAdapter.Xml.XmlName other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public static Castle.Components.DictionaryAdapter.Xml.XmlName ParseQName(string text) { }
        public override string ToString() { }
        public Castle.Components.DictionaryAdapter.Xml.XmlName WithNamespaceUri(string namespaceUri) { }
        public static bool ==(Castle.Components.DictionaryAdapter.Xml.XmlName x, Castle.Components.DictionaryAdapter.Xml.XmlName y) { }
        public static bool !=(Castle.Components.DictionaryAdapter.Xml.XmlName x, Castle.Components.DictionaryAdapter.Xml.XmlName y) { }
    }
    public class XmlNameComparer : System.Collections.Generic.IEqualityComparer<Castle.Components.DictionaryAdapter.Xml.XmlName>
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlNameComparer Default;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlNameComparer IgnoreCase;
        public bool Equals(Castle.Components.DictionaryAdapter.Xml.XmlName x, Castle.Components.DictionaryAdapter.Xml.XmlName y) { }
        public int GetHashCode(Castle.Components.DictionaryAdapter.Xml.XmlName name) { }
    }
    public abstract class XmlNodeAccessor : Castle.Components.DictionaryAdapter.Xml.XmlAccessor, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap
    {
        protected static readonly System.StringComparer NameComparer;
        protected XmlNodeAccessor(System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        protected XmlNodeAccessor(string name, System.Type type, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        protected Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap KnownTypes { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        protected void ConfigureKnownTypesFromAttributes<T>(System.Collections.Generic.IEnumerable<T> attributes, Castle.Components.DictionaryAdapter.Xml.IXmlBehaviorSemantics<T> semantics) { }
        protected void ConfigureKnownTypesFromParent(Castle.Components.DictionaryAdapter.Xml.XmlNodeAccessor accessor) { }
        protected void ConfigureLocalName(string localName) { }
        protected void ConfigureNamespaceUri(string namespaceUri) { }
        protected virtual bool IsMatch(Castle.Components.DictionaryAdapter.Xml.IXmlIdentity xmlIdentity) { }
        protected virtual bool IsMatch(System.Type clrType) { }
        public override void Prepare() { }
        public bool TryGet(Castle.Components.DictionaryAdapter.Xml.IXmlIdentity xmlName, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType) { }
        public bool TryGet(System.Type clrType, out Castle.Components.DictionaryAdapter.Xml.IXmlKnownType knownType) { }
    }
    public abstract class XmlNodeBase : Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource
    {
        protected System.Type type;
        protected XmlNodeBase(Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.IXmlNode parent) { }
        public virtual System.Type ClrType { get; }
        public virtual bool IsReal { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource Namespaces { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlNode Parent { get; }
        public virtual Castle.Components.DictionaryAdapter.Xml.CompiledXPath Path { get; }
        public event System.EventHandler Realized;
        protected virtual void Realize() { }
    }
    public class XmlPositionComparer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlPositionComparer Instance;
        public XmlPositionComparer() { }
        public bool Equals(Castle.Components.DictionaryAdapter.Xml.IXmlNode nodeA, Castle.Components.DictionaryAdapter.Xml.IXmlNode nodeB) { }
    }
    public class XmlReferenceManager
    {
        public XmlReferenceManager(Castle.Components.DictionaryAdapter.Xml.IXmlNode root, Castle.Components.DictionaryAdapter.Xml.IXmlReferenceFormat format) { }
        public void Add(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, object keyValue, object newValue, bool isInGraph) { }
        public void OnAssignedValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, object givenValue, object storedValue, object token) { }
        public bool OnAssigningNull(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, object oldValue) { }
        public bool OnAssigningValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, object oldValue, ref object newValue, out object token) { }
        public void OnGetCompleted(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, object value, object token) { }
        public bool OnGetStarting(ref Castle.Components.DictionaryAdapter.Xml.IXmlNode node, ref object value, out object token) { }
        public bool TryGet(object keyObject, out object inGraphObject) { }
        public void UnionWith(Castle.Components.DictionaryAdapter.Xml.XmlReferenceManager other) { }
    }
    public class XmlSelfAccessor : Castle.Components.DictionaryAdapter.Xml.XmlAccessor
    {
        public XmlSelfAccessor(System.Type clrType, Castle.Components.DictionaryAdapter.Xml.IXmlContext context) { }
        public override void ConfigureNillable(bool nillable) { }
        public override Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectPropertyNode(Castle.Components.DictionaryAdapter.Xml.IXmlNode parentNode, bool mutable) { }
    }
    public class XmlSelfCursor : Castle.Components.DictionaryAdapter.IVirtual, Castle.Components.DictionaryAdapter.Xml.IRealizableSource, Castle.Components.DictionaryAdapter.Xml.IXmlCursor, Castle.Components.DictionaryAdapter.Xml.IXmlIdentity, Castle.Components.DictionaryAdapter.Xml.IXmlIterator, Castle.Components.DictionaryAdapter.Xml.IXmlKnownType, Castle.Components.DictionaryAdapter.Xml.IXmlNode
    {
        public XmlSelfCursor(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, System.Type clrType) { }
        public System.Type ClrType { get; }
        public Castle.Components.DictionaryAdapter.Xml.CursorFlags Flags { get; }
        public bool IsAttribute { get; }
        public bool IsElement { get; }
        public bool IsNil { get; set; }
        public bool IsReal { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName Name { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource Namespaces { get; }
        public Castle.Components.DictionaryAdapter.Xml.IXmlNode Parent { get; }
        public Castle.Components.DictionaryAdapter.Xml.CompiledXPath Path { get; }
        public object UnderlyingObject { get; }
        public string Value { get; set; }
        public string Xml { get; }
        public Castle.Components.DictionaryAdapter.Xml.XmlName XsiType { get; }
        public event System.EventHandler Realized;
        public Castle.Components.DictionaryAdapter.Xml.IRealizable<T> AsRealizable<T>() { }
        public void Clear() { }
        public void Coerce(System.Type type) { }
        public void Create(System.Type type) { }
        public void DefineNamespace(string prefix, string namespaceUri, bool root) { }
        public object Evaluate(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path) { }
        public string GetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name) { }
        public string LookupNamespaceUri(string prefix) { }
        public string LookupPrefix(string namespaceUri) { }
        public void MakeNext(System.Type type) { }
        public bool MoveNext() { }
        public void MoveTo(Castle.Components.DictionaryAdapter.Xml.IXmlNode position) { }
        public void MoveToEnd() { }
        public System.Xml.XmlReader ReadSubtree() { }
        public void Realize() { }
        public void Remove() { }
        public void RemoveAllNext() { }
        public void Reset() { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlNode Save() { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor Select(Castle.Components.DictionaryAdapter.Xml.CompiledXPath path, Castle.Components.DictionaryAdapter.Xml.IXmlIncludedTypeMap knownTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectChildren(Castle.Components.DictionaryAdapter.Xml.IXmlKnownTypeMap knownTypes, Castle.Components.DictionaryAdapter.Xml.IXmlNamespaceSource namespaces, Castle.Components.DictionaryAdapter.Xml.CursorFlags flags) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlCursor SelectSelf(System.Type clrType) { }
        public Castle.Components.DictionaryAdapter.Xml.IXmlIterator SelectSubtree() { }
        public void SetAttribute(Castle.Components.DictionaryAdapter.Xml.XmlName name, string value) { }
        public bool UnderlyingPositionEquals(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public System.Xml.XmlWriter WriteAttributes() { }
        public System.Xml.XmlWriter WriteChildren() { }
    }
    public class XmlSetSerializer : Castle.Components.DictionaryAdapter.Xml.XmlCollectionSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlSetSerializer Instance;
        protected XmlSetSerializer() { }
        public override System.Type ListTypeConstructor { get; }
    }
    public class static XmlSimpleSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForBoolean;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForByte;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForByteArray;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForChar;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForDateTime;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForDateTimeOffset;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForDecimal;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForDouble;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForGuid;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForInt16;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForInt32;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForInt64;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForSByte;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForSingle;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForTimeSpan;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForUInt16;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForUInt32;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForUInt64;
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer ForUri;
    }
    public class XmlSimpleSerializer<T> : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public XmlSimpleSerializer(System.Func<T, string> getString, System.Func<string, T> getObject) { }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlStringSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlStringSerializer Instance;
        protected XmlStringSerializer() { }
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class XmlSubtreeReader : System.Xml.XmlReader
    {
        public XmlSubtreeReader(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, System.Xml.Serialization.XmlRootAttribute root) { }
        public XmlSubtreeReader(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, string rootLocalName, string rootNamespaceUri) { }
        public override int AttributeCount { get; }
        public override string BaseURI { get; }
        public override int Depth { get; }
        public override bool EOF { get; }
        public bool IsAtRootElement { get; }
        public bool IsDisposed { get; }
        public override bool IsEmptyElement { get; }
        public override string LocalName { get; }
        public override System.Xml.XmlNameTable NameTable { get; }
        public override string NamespaceURI { get; }
        public override System.Xml.XmlNodeType NodeType { get; }
        public override string Prefix { get; }
        public override System.Xml.ReadState ReadState { get; }
        protected System.Xml.XmlReader Reader { get; }
        public override string Value { get; }
        public override void Close() { }
        protected override void Dispose(bool managed) { }
        public override string GetAttribute(int i) { }
        public override string GetAttribute(string name) { }
        public override string GetAttribute(string name, string namespaceURI) { }
        public override string LookupNamespace(string prefix) { }
        public override bool MoveToAttribute(string name) { }
        public override bool MoveToAttribute(string name, string ns) { }
        public override bool MoveToElement() { }
        public override bool MoveToFirstAttribute() { }
        public override bool MoveToNextAttribute() { }
        public override bool Read() { }
        public override bool ReadAttributeValue() { }
        public override void ResolveEntity() { }
    }
    public class XmlSubtreeWriter : System.Xml.XmlWriter
    {
        public XmlSubtreeWriter(Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public override System.Xml.WriteState WriteState { get; }
        public override void Close() { }
        protected override void Dispose(bool managed) { }
        public override void Flush() { }
        public override string LookupPrefix(string ns) { }
        public override void WriteBase64(byte[] buffer, int index, int count) { }
        public override void WriteCData(string text) { }
        public override void WriteCharEntity(char ch) { }
        public override void WriteChars(char[] buffer, int index, int count) { }
        public override void WriteComment(string text) { }
        public override void WriteDocType(string name, string pubid, string sysid, string subset) { }
        public override void WriteEndAttribute() { }
        public override void WriteEndDocument() { }
        public override void WriteEndElement() { }
        public override void WriteEntityRef(string name) { }
        public override void WriteFullEndElement() { }
        public override void WriteProcessingInstruction(string name, string text) { }
        public override void WriteRaw(string data) { }
        public override void WriteRaw(char[] buffer, int index, int count) { }
        public override void WriteStartAttribute(string prefix, string localName, string ns) { }
        public override void WriteStartDocument(bool standalone) { }
        public override void WriteStartDocument() { }
        public override void WriteStartElement(string prefix, string localName, string ns) { }
        public override void WriteString(string text) { }
        public override void WriteSurrogateCharEntity(char lowChar, char highChar) { }
        public override void WriteWhitespace(string ws) { }
    }
    public enum XmlTypeKind
    {
        Simple = 0,
        Complex = 1,
        Collection = 2,
    }
    public abstract class XmlTypeSerializer
    {
        protected XmlTypeSerializer() { }
        public virtual bool CanGetStub { get; }
        public abstract Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public static Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer For(System.Type type) { }
        public virtual object GetStub(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public abstract object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor);
        public abstract void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value);
    }
    public class XmlXmlNodeSerializer : Castle.Components.DictionaryAdapter.Xml.XmlTypeSerializer
    {
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlXmlNodeSerializer Instance;
        public override Castle.Components.DictionaryAdapter.Xml.XmlTypeKind Kind { get; }
        public override object GetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor) { }
        public override void SetValue(Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.IDictionaryAdapter parent, Castle.Components.DictionaryAdapter.Xml.IXmlAccessor accessor, object oldValue, ref object value) { }
    }
    public class static Xmlns
    {
        public const string NamespaceUri = "http://www.w3.org/2000/xmlns/";
        public const string Prefix = "xmlns";
    }
    public class static Xsd
    {
        public const string NamespaceUri = "http://www.w3.org/2001/XMLSchema";
        public const string Prefix = "xsd";
    }
    public class static Xsi
    {
        public const string NamespaceUri = "http://www.w3.org/2001/XMLSchema-instance";
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlName Nil;
        public const string NilValue = "true";
        public const string Prefix = "xsi";
        public static readonly Castle.Components.DictionaryAdapter.Xml.XmlName Type;
        public static Castle.Components.DictionaryAdapter.Xml.XmlName GetXsiType(this Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public static bool IsXsiNil(this Castle.Components.DictionaryAdapter.Xml.IXmlNode node) { }
        public static void SetXsiNil(this Castle.Components.DictionaryAdapter.Xml.IXmlNode node, bool nil) { }
        public static void SetXsiType(this Castle.Components.DictionaryAdapter.Xml.IXmlNode node, Castle.Components.DictionaryAdapter.Xml.XmlName xsiType) { }
    }
}
namespace Castle.Core
{
    public sealed class ReflectionBasedDictionaryAdapter : System.Collections.ICollection, System.Collections.IDictionary, System.Collections.IEnumerable
    {
        public ReflectionBasedDictionaryAdapter(object target) { }
        public int Count { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public object this[object key] { get; set; }
        public System.Collections.ICollection Keys { get; }
        public object SyncRoot { get; }
        public System.Collections.ICollection Values { get; }
        public void Add(object key, object value) { }
        public void Clear() { }
        public bool Contains(object key) { }
        public System.Collections.IEnumerator GetEnumerator() { }
        public static void Read(System.Collections.IDictionary targetDictionary, object valuesAsAnonymousObject) { }
        public void Remove(object key) { }
    }
    public sealed class StringObjectDictionaryAdapter : System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.Generic.IDictionary<string, object>, System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, object>>, System.Collections.IEnumerable
    {
        public StringObjectDictionaryAdapter(System.Collections.IDictionary dictionary) { }
        public int Count { get; }
        public bool IsFixedSize { get; }
        public bool IsReadOnly { get; }
        public bool IsSynchronized { get; }
        public object this[object key] { get; set; }
        public System.Collections.ICollection Keys { get; }
        public object SyncRoot { get; }
        public System.Collections.ICollection Values { get; }
        public void Add(object key, object value) { }
        public void Clear() { }
        public bool Contains(object key) { }
        public void CopyTo(System.Array array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { }
        public void Remove(object key) { }
    }
}