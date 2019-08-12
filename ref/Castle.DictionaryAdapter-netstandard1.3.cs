[assembly: System.CLSCompliantAttribute(true)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"Castle.DictionaryAdapter.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010077f5e87030dadccce6902c6adab7a987bd69cb5819991531f560785eacfc89b6fcddf6bb2a00743a7194e454c0273447fc6eec36474ba8e5a3823147d214298e4f9a631b1afee1a51ffeae4672d498f14b000e3d321453cdd8ac064de7e1cf4d222b7e81f54d4fd46725370d702a05b48738cc29d09228f1aa722ae1a9ca02fb")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETStandard,Version=v1.3", FrameworkDisplayName="")]
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
    public abstract class DictionaryAdapterBase : Castle.Components.DictionaryAdapter.IDictionaryAdapter, Castle.Components.DictionaryAdapter.IDictionaryCreate, Castle.Components.DictionaryAdapter.IDictionaryEdit, Castle.Components.DictionaryAdapter.IDictionaryNotify, Castle.Components.DictionaryAdapter.IDictionaryValidate, System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.IRevertibleChangeTracking
    {
        public DictionaryAdapterBase(Castle.Components.DictionaryAdapter.DictionaryAdapterInstance instance) { }
        public bool CanEdit { get; set; }
        public bool CanNotify { get; set; }
        public bool CanValidate { get; set; }
        public bool IsChanged { get; }
        public bool IsEditing { get; }
        public bool IsValid { get; }
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
    public class DictionaryValidateGroup : Castle.Components.DictionaryAdapter.IDictionaryValidate, System.ComponentModel.INotifyPropertyChanged, System.IDisposable
    {
        public DictionaryValidateGroup(object[] groups, Castle.Components.DictionaryAdapter.IDictionaryAdapter adapter) { }
        public bool CanValidate { get; set; }
        public bool IsValid { get; }
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
    public interface IBindingList<T> : System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.IEnumerable
    {
        bool AllowEdit { get; }
        bool AllowNew { get; }
        bool AllowRemove { get; }
        bool IsSorted { get; }
        System.ComponentModel.PropertyDescriptor SortProperty { get; }
        bool SupportsChangeNotification { get; }
        bool SupportsSearching { get; }
        bool SupportsSorting { get; }
        void AddIndex(System.ComponentModel.PropertyDescriptor property);
        T AddNew();
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
    public interface IDictionaryAdapter : Castle.Components.DictionaryAdapter.IDictionaryCreate, Castle.Components.DictionaryAdapter.IDictionaryEdit, Castle.Components.DictionaryAdapter.IDictionaryNotify, Castle.Components.DictionaryAdapter.IDictionaryValidate, System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.INotifyPropertyChanged, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.IRevertibleChangeTracking
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
    public interface IDictionaryValidate
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
    public class ListProjection<T> : Castle.Components.DictionaryAdapter.IBindingList<T>, Castle.Components.DictionaryAdapter.ICollectionAdapterObserver<T>, Castle.Components.DictionaryAdapter.ICollectionProjection, System.Collections.Generic.ICollection<T>, System.Collections.Generic.IEnumerable<T>, System.Collections.Generic.IList<T>, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IList, System.ComponentModel.IChangeTracking, System.ComponentModel.IEditableObject, System.ComponentModel.IRevertibleChangeTracking
    {
        public ListProjection(Castle.Components.DictionaryAdapter.ICollectionAdapter<T> adapter) { }
        public Castle.Components.DictionaryAdapter.ICollectionAdapter<T> Adapter { get; }
        public System.Collections.Generic.IEqualityComparer<T> Comparer { get; }
        public int Count { get; }
        public bool EventsEnabled { get; }
        public bool IsChanged { get; }
        public T this[int index] { get; set; }
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
        [System.Diagnostics.ConditionalAttribute("NOP")]
        protected void NotifyListChanged(Castle.Components.DictionaryAdapter.ListProjection<T>.ListChangedType type, int index) { }
        [System.Diagnostics.ConditionalAttribute("NOP")]
        protected void NotifyListReset() { }
        protected virtual void OnInserted(T newValue, int index) { }
        protected virtual bool OnInserting(T value) { }
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
        protected enum ListChangedType<T>
        {
            ItemAdded = 0,
            ItemChanged = 1,
            ItemDeleted = 2,
        }
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
namespace Castle.Core.Configuration
{
    public abstract class AbstractConfiguration : Castle.Core.Configuration.IConfiguration
    {
        protected AbstractConfiguration() { }
        public virtual Castle.Core.Configuration.ConfigurationAttributeCollection Attributes { get; }
        public virtual Castle.Core.Configuration.ConfigurationCollection Children { get; }
        public string Name { get; set; }
        public string Value { get; set; }
        public virtual object GetValue(System.Type type, object defaultValue) { }
    }
    public class ConfigurationAttributeCollection : System.Collections.Specialized.NameValueCollection
    {
        public ConfigurationAttributeCollection() { }
    }
    public class ConfigurationCollection : System.Collections.Generic.List<Castle.Core.Configuration.IConfiguration>
    {
        public ConfigurationCollection() { }
        public ConfigurationCollection(System.Collections.Generic.IEnumerable<Castle.Core.Configuration.IConfiguration> value) { }
        public Castle.Core.Configuration.IConfiguration this[string name] { get; }
    }
    public interface IConfiguration
    {
        Castle.Core.Configuration.ConfigurationAttributeCollection Attributes { get; }
        Castle.Core.Configuration.ConfigurationCollection Children { get; }
        string Name { get; }
        string Value { get; }
        object GetValue(System.Type type, object defaultValue);
    }
    public class MutableConfiguration : Castle.Core.Configuration.AbstractConfiguration
    {
        public MutableConfiguration(string name) { }
        public MutableConfiguration(string name, string value) { }
        public new string Value { get; set; }
        public Castle.Core.Configuration.MutableConfiguration Attribute(string name, string value) { }
        public static Castle.Core.Configuration.MutableConfiguration Create(string name) { }
        public Castle.Core.Configuration.MutableConfiguration CreateChild(string name) { }
        public Castle.Core.Configuration.MutableConfiguration CreateChild(string name, string value) { }
    }
}
namespace Castle.Core.Configuration.Xml
{
    public class XmlConfigurationDeserializer
    {
        public XmlConfigurationDeserializer() { }
        public Castle.Core.Configuration.IConfiguration Deserialize(System.Xml.XmlNode node) { }
        public static string GetConfigValue(string value) { }
        public static Castle.Core.Configuration.IConfiguration GetDeserializedNode(System.Xml.XmlNode node) { }
        public static bool IsTextNode(System.Xml.XmlNode node) { }
    }
}
namespace Castle.Core
{
    public interface IServiceEnabledComponent
    {
        void Service(System.IServiceProvider provider);
    }
    public interface IServiceProviderEx : System.IServiceProvider
    {
        T GetService<T>()
            where T :  class;
    }
    public interface IServiceProviderExAccessor
    {
        Castle.Core.IServiceProviderEx ServiceProvider { get; }
    }
    public class Pair<TFirst, TSecond> : System.IEquatable<Castle.Core.Pair<TFirst, TSecond>>
    {
        public Pair(TFirst first, TSecond second) { }
        public TFirst First { get; }
        public TSecond Second { get; }
        public bool Equals(Castle.Core.Pair<TFirst, TSecond> other) { }
        public override bool Equals(object obj) { }
        public override int GetHashCode() { }
        public override string ToString() { }
    }
    public class static ProxyServices
    {
        public static bool IsDynamicProxy(System.Type type) { }
    }
    public class ReferenceEqualityComparer<T> : System.Collections.Generic.IEqualityComparer<T>, System.Collections.IEqualityComparer
    {
        public static Castle.Core.ReferenceEqualityComparer<T> Instance { get; }
        public int GetHashCode(object obj) { }
    }
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
namespace Castle.Core.Internal
{
    public class static AttributesUtil
    {
        public static T GetAttribute<T>(this System.Type type)
            where T : System.Attribute { }
        public static T GetAttribute<T>(this System.Reflection.MemberInfo member)
            where T : System.Attribute { }
        public static System.AttributeUsageAttribute GetAttributeUsage(this System.Type attributeType) { }
        public static System.Collections.Generic.IEnumerable<T> GetAttributes<T>(this System.Type type)
            where T : System.Attribute { }
        public static System.Collections.Generic.IEnumerable<T> GetAttributes<T>(this System.Reflection.MemberInfo member)
            where T : System.Attribute { }
        public static T GetTypeAttribute<T>(this System.Type type)
            where T : System.Attribute { }
        public static T[] GetTypeAttributes<T>(System.Type type)
            where T : System.Attribute { }
        public static System.Type GetTypeConverter(System.Reflection.MemberInfo member) { }
    }
    public class static CollectionExtensions
    {
        public static bool AreEquivalent<T>(System.Collections.Generic.IList<T> listA, System.Collections.Generic.IList<T> listB) { }
        public static T Find<T>(this T[] items, System.Predicate<T> predicate) { }
        public static T[] FindAll<T>(this T[] items, System.Predicate<T> predicate) { }
        public static int GetContentsHashCode<T>(System.Collections.Generic.IList<T> list) { }
        public static bool IsNullOrEmpty(this System.Collections.IEnumerable @this) { }
    }
    [System.ObsoleteAttribute("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and rela" +
        "ted types.")]
    public interface ILockHolder : System.IDisposable
    {
        bool LockAcquired { get; }
    }
    [System.ObsoleteAttribute("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and rela" +
        "ted types.")]
    public interface IUpgradeableLockHolder : Castle.Core.Internal.ILockHolder, System.IDisposable
    {
        Castle.Core.Internal.ILockHolder Upgrade();
        Castle.Core.Internal.ILockHolder Upgrade(bool waitForLock);
    }
    public class InternalsVisible
    {
        public const string ToCastleCore = @"Castle.Core, PublicKey=002400000480000094000000060200000024000052534131000400000100010077F5E87030DADCCCE6902C6ADAB7A987BD69CB5819991531F560785EACFC89B6FCDDF6BB2A00743A7194E454C0273447FC6EEC36474BA8E5A3823147D214298E4F9A631B1AFEE1A51FFEAE4672D498F14B000E3D321453CDD8AC064DE7E1CF4D222B7E81F54D4FD46725370D702A05B48738CC29D09228F1AA722AE1A9CA02FB";
        public const string ToDynamicProxyGenAssembly2 = @"DynamicProxyGenAssembly2, PublicKey=0024000004800000940000000602000000240000525341310004000001000100c547cac37abd99c8db225ef2f6c8a3602f3b3606cc9891605d02baa56104f4cfc0734aa39b93bf7852f7d9266654753cc297e7d2edfe0bac1cdcf9f717241550e0a7b191195b7667bb4f64bcb8e2121380fd1d9d46ad2d92d2d15605093924cceaf74c4861eff62abf69b9291ed0a340e113be11e6a7d3113e92484cf7045cc7";
        public InternalsVisible() { }
    }
    [System.ObsoleteAttribute("Consider using `System.Threading.ReaderWriterLockSlim` instead of `Lock` and rela" +
        "ted types.")]
    public abstract class Lock
    {
        protected Lock() { }
        public static Castle.Core.Internal.Lock Create() { }
        public abstract Castle.Core.Internal.ILockHolder ForReading();
        public abstract Castle.Core.Internal.ILockHolder ForReading(bool waitForLock);
        public abstract Castle.Core.Internal.IUpgradeableLockHolder ForReadingUpgradeable();
        public abstract Castle.Core.Internal.IUpgradeableLockHolder ForReadingUpgradeable(bool waitForLock);
        public abstract Castle.Core.Internal.ILockHolder ForWriting();
        public abstract Castle.Core.Internal.ILockHolder ForWriting(bool waitForLock);
    }
}
namespace Castle.Core.Logging
{
    public abstract class AbstractExtendedLoggerFactory : Castle.Core.Logging.IExtendedLoggerFactory, Castle.Core.Logging.ILoggerFactory
    {
        protected AbstractExtendedLoggerFactory() { }
        public virtual Castle.Core.Logging.IExtendedLogger Create(System.Type type) { }
        public abstract Castle.Core.Logging.IExtendedLogger Create(string name);
        public virtual Castle.Core.Logging.IExtendedLogger Create(System.Type type, Castle.Core.Logging.LoggerLevel level) { }
        public abstract Castle.Core.Logging.IExtendedLogger Create(string name, Castle.Core.Logging.LoggerLevel level);
        protected static System.IO.FileInfo GetConfigFile(string fileName) { }
    }
    public abstract class AbstractLoggerFactory : Castle.Core.Logging.ILoggerFactory
    {
        protected AbstractLoggerFactory() { }
        public virtual Castle.Core.Logging.ILogger Create(System.Type type) { }
        public virtual Castle.Core.Logging.ILogger Create(System.Type type, Castle.Core.Logging.LoggerLevel level) { }
        public abstract Castle.Core.Logging.ILogger Create(string name);
        public abstract Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level);
        protected static System.IO.FileInfo GetConfigFile(string fileName) { }
    }
    public class ConsoleFactory : Castle.Core.Logging.ILoggerFactory
    {
        public ConsoleFactory() { }
        public ConsoleFactory(Castle.Core.Logging.LoggerLevel level) { }
        public Castle.Core.Logging.ILogger Create(System.Type type) { }
        public Castle.Core.Logging.ILogger Create(string name) { }
        public Castle.Core.Logging.ILogger Create(System.Type type, Castle.Core.Logging.LoggerLevel level) { }
        public Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level) { }
    }
    public class ConsoleLogger : Castle.Core.Logging.LevelFilteredLogger
    {
        public ConsoleLogger() { }
        public ConsoleLogger(Castle.Core.Logging.LoggerLevel logLevel) { }
        public ConsoleLogger(string name) { }
        public ConsoleLogger(string name, Castle.Core.Logging.LoggerLevel logLevel) { }
        public override Castle.Core.Logging.ILogger CreateChildLogger(string loggerName) { }
        protected override void Log(Castle.Core.Logging.LoggerLevel loggerLevel, string loggerName, string message, System.Exception exception) { }
    }
    public interface IContextProperties
    {
        object this[string key] { get; set; }
    }
    public interface IContextStack
    {
        int Count { get; }
        void Clear();
        string Pop();
        System.IDisposable Push(string message);
    }
    public interface IContextStacks
    {
        Castle.Core.Logging.IContextStack this[string key] { get; }
    }
    public interface IExtendedLogger : Castle.Core.Logging.ILogger
    {
        Castle.Core.Logging.IContextProperties GlobalProperties { get; }
        Castle.Core.Logging.IContextProperties ThreadProperties { get; }
        Castle.Core.Logging.IContextStacks ThreadStacks { get; }
    }
    public interface IExtendedLoggerFactory : Castle.Core.Logging.ILoggerFactory
    {
        Castle.Core.Logging.IExtendedLogger Create(System.Type type);
        Castle.Core.Logging.IExtendedLogger Create(string name);
        Castle.Core.Logging.IExtendedLogger Create(System.Type type, Castle.Core.Logging.LoggerLevel level);
        Castle.Core.Logging.IExtendedLogger Create(string name, Castle.Core.Logging.LoggerLevel level);
    }
    public interface ILogger
    {
        bool IsDebugEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsTraceEnabled { get; }
        bool IsWarnEnabled { get; }
        Castle.Core.Logging.ILogger CreateChildLogger(string loggerName);
        void Debug(string message);
        void Debug(System.Func<string> messageFactory);
        void Debug(string message, System.Exception exception);
        void DebugFormat(string format, params object[] args);
        void DebugFormat(System.Exception exception, string format, params object[] args);
        void DebugFormat(System.IFormatProvider formatProvider, string format, params object[] args);
        void DebugFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args);
        void Error(string message);
        void Error(System.Func<string> messageFactory);
        void Error(string message, System.Exception exception);
        void ErrorFormat(string format, params object[] args);
        void ErrorFormat(System.Exception exception, string format, params object[] args);
        void ErrorFormat(System.IFormatProvider formatProvider, string format, params object[] args);
        void ErrorFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args);
        void Fatal(string message);
        void Fatal(System.Func<string> messageFactory);
        void Fatal(string message, System.Exception exception);
        void FatalFormat(string format, params object[] args);
        void FatalFormat(System.Exception exception, string format, params object[] args);
        void FatalFormat(System.IFormatProvider formatProvider, string format, params object[] args);
        void FatalFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args);
        void Info(string message);
        void Info(System.Func<string> messageFactory);
        void Info(string message, System.Exception exception);
        void InfoFormat(string format, params object[] args);
        void InfoFormat(System.Exception exception, string format, params object[] args);
        void InfoFormat(System.IFormatProvider formatProvider, string format, params object[] args);
        void InfoFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args);
        void Trace(string message);
        void Trace(System.Func<string> messageFactory);
        void Trace(string message, System.Exception exception);
        void TraceFormat(string format, params object[] args);
        void TraceFormat(System.Exception exception, string format, params object[] args);
        void TraceFormat(System.IFormatProvider formatProvider, string format, params object[] args);
        void TraceFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args);
        void Warn(string message);
        void Warn(System.Func<string> messageFactory);
        void Warn(string message, System.Exception exception);
        void WarnFormat(string format, params object[] args);
        void WarnFormat(System.Exception exception, string format, params object[] args);
        void WarnFormat(System.IFormatProvider formatProvider, string format, params object[] args);
        void WarnFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args);
    }
    public interface ILoggerFactory
    {
        Castle.Core.Logging.ILogger Create(System.Type type);
        Castle.Core.Logging.ILogger Create(string name);
        Castle.Core.Logging.ILogger Create(System.Type type, Castle.Core.Logging.LoggerLevel level);
        Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level);
    }
    public abstract class LevelFilteredLogger : Castle.Core.Logging.ILogger
    {
        protected LevelFilteredLogger() { }
        protected LevelFilteredLogger(string name) { }
        protected LevelFilteredLogger(Castle.Core.Logging.LoggerLevel loggerLevel) { }
        protected LevelFilteredLogger(string loggerName, Castle.Core.Logging.LoggerLevel loggerLevel) { }
        public bool IsDebugEnabled { get; }
        public bool IsErrorEnabled { get; }
        public bool IsFatalEnabled { get; }
        public bool IsInfoEnabled { get; }
        public bool IsTraceEnabled { get; }
        public bool IsWarnEnabled { get; }
        public Castle.Core.Logging.LoggerLevel Level { get; set; }
        public string Name { get; }
        protected void ChangeName(string newName) { }
        public abstract Castle.Core.Logging.ILogger CreateChildLogger(string loggerName);
        public void Debug(string message) { }
        public void Debug(System.Func<string> messageFactory) { }
        public void Debug(string message, System.Exception exception) { }
        public void DebugFormat(string format, params object[] args) { }
        public void DebugFormat(System.Exception exception, string format, params object[] args) { }
        public void DebugFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void DebugFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Error(string message) { }
        public void Error(System.Func<string> messageFactory) { }
        public void Error(string message, System.Exception exception) { }
        public void ErrorFormat(string format, params object[] args) { }
        public void ErrorFormat(System.Exception exception, string format, params object[] args) { }
        public void ErrorFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void ErrorFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Fatal(string message) { }
        public void Fatal(System.Func<string> messageFactory) { }
        public void Fatal(string message, System.Exception exception) { }
        public void FatalFormat(string format, params object[] args) { }
        public void FatalFormat(System.Exception exception, string format, params object[] args) { }
        public void FatalFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void FatalFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Info(string message) { }
        public void Info(System.Func<string> messageFactory) { }
        public void Info(string message, System.Exception exception) { }
        public void InfoFormat(string format, params object[] args) { }
        public void InfoFormat(System.Exception exception, string format, params object[] args) { }
        public void InfoFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void InfoFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        protected abstract void Log(Castle.Core.Logging.LoggerLevel loggerLevel, string loggerName, string message, System.Exception exception);
        public void Trace(string message) { }
        public void Trace(System.Func<string> messageFactory) { }
        public void Trace(string message, System.Exception exception) { }
        public void TraceFormat(string format, params object[] args) { }
        public void TraceFormat(System.Exception exception, string format, params object[] args) { }
        public void TraceFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void TraceFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Warn(string message) { }
        public void Warn(System.Func<string> messageFactory) { }
        public void Warn(string message, System.Exception exception) { }
        public void WarnFormat(string format, params object[] args) { }
        public void WarnFormat(System.Exception exception, string format, params object[] args) { }
        public void WarnFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void WarnFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
    }
    public class LoggerException : System.Exception
    {
        public LoggerException() { }
        public LoggerException(string message) { }
        public LoggerException(string message, System.Exception innerException) { }
    }
    public enum LoggerLevel
    {
        Off = 0,
        Fatal = 1,
        Error = 2,
        Warn = 3,
        Info = 4,
        Debug = 5,
        Trace = 6,
    }
    public class NullLogFactory : Castle.Core.Logging.AbstractLoggerFactory
    {
        public NullLogFactory() { }
        public override Castle.Core.Logging.ILogger Create(string name) { }
        public override Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level) { }
    }
    public class NullLogger : Castle.Core.Logging.IExtendedLogger, Castle.Core.Logging.ILogger
    {
        public static readonly Castle.Core.Logging.NullLogger Instance;
        public NullLogger() { }
        public Castle.Core.Logging.IContextProperties GlobalProperties { get; }
        public bool IsDebugEnabled { get; }
        public bool IsErrorEnabled { get; }
        public bool IsFatalEnabled { get; }
        public bool IsInfoEnabled { get; }
        public bool IsTraceEnabled { get; }
        public bool IsWarnEnabled { get; }
        public Castle.Core.Logging.IContextProperties ThreadProperties { get; }
        public Castle.Core.Logging.IContextStacks ThreadStacks { get; }
        public Castle.Core.Logging.ILogger CreateChildLogger(string loggerName) { }
        public void Debug(string message) { }
        public void Debug(System.Func<string> messageFactory) { }
        public void Debug(string message, System.Exception exception) { }
        public void DebugFormat(string format, params object[] args) { }
        public void DebugFormat(System.Exception exception, string format, params object[] args) { }
        public void DebugFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void DebugFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Error(string message) { }
        public void Error(System.Func<string> messageFactory) { }
        public void Error(string message, System.Exception exception) { }
        public void ErrorFormat(string format, params object[] args) { }
        public void ErrorFormat(System.Exception exception, string format, params object[] args) { }
        public void ErrorFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void ErrorFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Fatal(string message) { }
        public void Fatal(System.Func<string> messageFactory) { }
        public void Fatal(string message, System.Exception exception) { }
        public void FatalFormat(string format, params object[] args) { }
        public void FatalFormat(System.Exception exception, string format, params object[] args) { }
        public void FatalFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void FatalFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Info(string message) { }
        public void Info(System.Func<string> messageFactory) { }
        public void Info(string message, System.Exception exception) { }
        public void InfoFormat(string format, params object[] args) { }
        public void InfoFormat(System.Exception exception, string format, params object[] args) { }
        public void InfoFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void InfoFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Trace(string message) { }
        public void Trace(System.Func<string> messageFactory) { }
        public void Trace(string message, System.Exception exception) { }
        public void TraceFormat(string format, params object[] args) { }
        public void TraceFormat(System.Exception exception, string format, params object[] args) { }
        public void TraceFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void TraceFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void Warn(string message) { }
        public void Warn(System.Func<string> messageFactory) { }
        public void Warn(string message, System.Exception exception) { }
        public void WarnFormat(string format, params object[] args) { }
        public void WarnFormat(System.Exception exception, string format, params object[] args) { }
        public void WarnFormat(System.IFormatProvider formatProvider, string format, params object[] args) { }
        public void WarnFormat(System.Exception exception, System.IFormatProvider formatProvider, string format, params object[] args) { }
    }
    public class StreamLogger : Castle.Core.Logging.LevelFilteredLogger, System.IDisposable
    {
        public StreamLogger(string name, System.IO.Stream stream) { }
        public StreamLogger(string name, System.IO.Stream stream, System.Text.Encoding encoding) { }
        public StreamLogger(string name, System.IO.Stream stream, System.Text.Encoding encoding, int bufferSize) { }
        protected StreamLogger(string name, System.IO.StreamWriter writer) { }
        public override Castle.Core.Logging.ILogger CreateChildLogger(string loggerName) { }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        protected override void Finalize() { }
        protected override void Log(Castle.Core.Logging.LoggerLevel loggerLevel, string loggerName, string message, System.Exception exception) { }
    }
    public class StreamLoggerFactory : Castle.Core.Logging.AbstractLoggerFactory
    {
        public StreamLoggerFactory() { }
        public override Castle.Core.Logging.ILogger Create(string name) { }
        public override Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level) { }
    }
    public class TraceLogger : Castle.Core.Logging.LevelFilteredLogger
    {
        public TraceLogger(string name) { }
        public TraceLogger(string name, Castle.Core.Logging.LoggerLevel level) { }
        public override Castle.Core.Logging.ILogger CreateChildLogger(string loggerName) { }
        protected override void Log(Castle.Core.Logging.LoggerLevel loggerLevel, string loggerName, string message, System.Exception exception) { }
    }
    public class TraceLoggerFactory : Castle.Core.Logging.AbstractLoggerFactory
    {
        public TraceLoggerFactory() { }
        public TraceLoggerFactory(Castle.Core.Logging.LoggerLevel level) { }
        public override Castle.Core.Logging.ILogger Create(string name) { }
        public override Castle.Core.Logging.ILogger Create(string name, Castle.Core.Logging.LoggerLevel level) { }
    }
}
namespace Castle.Core.Resource
{
    public abstract class AbstractResource : Castle.Core.Resource.IResource, System.IDisposable
    {
        protected static readonly string DefaultBasePath;
        protected AbstractResource() { }
        public virtual string FileBasePath { get; }
        public abstract Castle.Core.Resource.IResource CreateRelative(string relativePath);
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public abstract System.IO.TextReader GetStreamReader();
        public abstract System.IO.TextReader GetStreamReader(System.Text.Encoding encoding);
    }
    public abstract class AbstractStreamResource : Castle.Core.Resource.AbstractResource
    {
        protected AbstractStreamResource() { }
        public Castle.Core.Resource.StreamFactory CreateStream { get; set; }
        protected override void Finalize() { }
        public override System.IO.TextReader GetStreamReader() { }
        public override System.IO.TextReader GetStreamReader(System.Text.Encoding encoding) { }
    }
    public class AssemblyBundleResource : Castle.Core.Resource.AbstractResource
    {
        public AssemblyBundleResource(Castle.Core.Resource.CustomUri resource) { }
        public override Castle.Core.Resource.IResource CreateRelative(string relativePath) { }
        public override System.IO.TextReader GetStreamReader() { }
        public override System.IO.TextReader GetStreamReader(System.Text.Encoding encoding) { }
    }
    public class AssemblyResource : Castle.Core.Resource.AbstractStreamResource
    {
        public AssemblyResource(Castle.Core.Resource.CustomUri resource) { }
        public AssemblyResource(Castle.Core.Resource.CustomUri resource, string basePath) { }
        public AssemblyResource(string resource) { }
        public override Castle.Core.Resource.IResource CreateRelative(string relativePath) { }
        public override string ToString() { }
    }
    public class AssemblyResourceFactory : Castle.Core.Resource.IResourceFactory
    {
        public AssemblyResourceFactory() { }
        public bool Accept(Castle.Core.Resource.CustomUri uri) { }
        public Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri) { }
        public Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri, string basePath) { }
    }
    public sealed class CustomUri
    {
        public static readonly string SchemeDelimiter;
        public static readonly string UriSchemeAssembly;
        public static readonly string UriSchemeFile;
        public CustomUri(string resourceIdentifier) { }
        public string Host { get; }
        public bool IsAssembly { get; }
        public bool IsFile { get; }
        public bool IsUnc { get; }
        public string Path { get; }
        public string Scheme { get; }
    }
    public class FileResource : Castle.Core.Resource.AbstractStreamResource
    {
        public FileResource(Castle.Core.Resource.CustomUri resource) { }
        public FileResource(Castle.Core.Resource.CustomUri resource, string basePath) { }
        public FileResource(string resourceName) { }
        public FileResource(string resourceName, string basePath) { }
        public override string FileBasePath { get; }
        public override Castle.Core.Resource.IResource CreateRelative(string relativePath) { }
        public override string ToString() { }
    }
    public class FileResourceFactory : Castle.Core.Resource.IResourceFactory
    {
        public FileResourceFactory() { }
        public bool Accept(Castle.Core.Resource.CustomUri uri) { }
        public Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri) { }
        public Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri, string basePath) { }
    }
    public interface IResource : System.IDisposable
    {
        string FileBasePath { get; }
        Castle.Core.Resource.IResource CreateRelative(string relativePath);
        System.IO.TextReader GetStreamReader();
        System.IO.TextReader GetStreamReader(System.Text.Encoding encoding);
    }
    public interface IResourceFactory
    {
        bool Accept(Castle.Core.Resource.CustomUri uri);
        Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri);
        Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri, string basePath);
    }
    public class ResourceException : System.Exception
    {
        public ResourceException() { }
        public ResourceException(string message) { }
        public ResourceException(string message, System.Exception innerException) { }
    }
    public class StaticContentResource : Castle.Core.Resource.AbstractResource
    {
        public StaticContentResource(string contents) { }
        public override Castle.Core.Resource.IResource CreateRelative(string relativePath) { }
        public override System.IO.TextReader GetStreamReader() { }
        public override System.IO.TextReader GetStreamReader(System.Text.Encoding encoding) { }
    }
    public delegate System.IO.Stream StreamFactory();
    public class UncResource : Castle.Core.Resource.AbstractStreamResource
    {
        public UncResource(Castle.Core.Resource.CustomUri resource) { }
        public UncResource(Castle.Core.Resource.CustomUri resource, string basePath) { }
        public UncResource(string resourceName) { }
        public UncResource(string resourceName, string basePath) { }
        public override string FileBasePath { get; }
        public override Castle.Core.Resource.IResource CreateRelative(string relativePath) { }
        public override string ToString() { }
    }
    public class UncResourceFactory : Castle.Core.Resource.IResourceFactory
    {
        public UncResourceFactory() { }
        public bool Accept(Castle.Core.Resource.CustomUri uri) { }
        public Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri) { }
        public Castle.Core.Resource.IResource Create(Castle.Core.Resource.CustomUri uri, string basePath) { }
    }
}