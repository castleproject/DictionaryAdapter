[assembly: System.CLSCompliantAttribute(true)]
[assembly: System.Runtime.CompilerServices.InternalsVisibleToAttribute(@"Castle.DictionaryAdapter.Tests, PublicKey=002400000480000094000000060200000024000052534131000400000100010077f5e87030dadccce6902c6adab7a987bd69cb5819991531f560785eacfc89b6fcddf6bb2a00743a7194e454c0273447fc6eec36474ba8e5a3823147d214298e4f9a631b1afee1a51ffeae4672d498f14b000e3d321453cdd8ac064de7e1cf4d222b7e81f54d4fd46725370d702a05b48738cc29d09228f1aa722ae1a9ca02fb")]
[assembly: System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly: System.Runtime.Versioning.TargetFrameworkAttribute(".NETStandard,Version=v1.5", FrameworkDisplayName="")]
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