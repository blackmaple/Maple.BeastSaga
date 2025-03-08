namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."ProNumDictionary"]
    /// [SerializableDictionary<PlayerProType , System.Int32>]=>[SerializableDictionaryBase<PlayerProType , System.Int32 , System.Int32>]=>[SerializableDictionaryBase]=>[System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_ProNumDictionary>, Ptr_ProNumDictionary>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "ProNumDictionary", "ProNumDictionary")]
    public partial class ProNumDictionary
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ProNumDictionary(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ProNumDictionary(System.IntPtr ptr) => new Ptr_ProNumDictionary(ptr);
            public static implicit operator System.IntPtr(Ptr_ProNumDictionary ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_ProNumDictionary ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."ProNumDictionary"]
        /// </summary>
        partial struct Ptr_ProNumDictionary
        {
            /// <summary>
            /// 0x10 SerializableDictionaryBase.Dictionary<PlayerProType , System.Int32> m_dict
            /// class ["Model.Runtime".""."Dictionary`2"]
            /// </summary>
            /// <returns>class SerializableDictionaryBase.Dictionary<PlayerProType , System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_dict", "SerializableDictionaryBase.Dictionary<PlayerProType,System.Int32>")]
            public partial nint M_DICT { get; set; } 
*/

            /// <summary>
            /// 0x18 PlayerProType[] m_keys
            /// class ["Model.Runtime".""."PlayerProType[]"]
            /// </summary>
            /// <returns>class PlayerProType[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_keys", "PlayerProType[]")]
            public partial nint M_KEYS { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Int32[] m_values
            /// class ["mscorlib"."System"."Int32[]"]
            /// </summary>
            /// <returns>class System.Int32[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("m_values", "System.Int32[]")]
            public partial nint M_VALUES { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."ProNumDictionary"]
        /// </summary>
        partial struct Ptr_ProNumDictionary
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CTOR(); 
*/
        }

        /// <summary>
        /// abstract class ["Model.Runtime".""."SerializableDictionaryBase"]
        /// </summary>
        partial struct Ptr_ProNumDictionary
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CTOR(); 
*/
        }

        /// <summary>
        /// abstract class ["Model.Runtime".""."SerializableDictionaryBase`3"]
        /// </summary>
        partial struct Ptr_ProNumDictionary
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IDictionary<PlayerProType , System.Int32> dict)
            /// </summary>
            /// <param name = "dict">interface System.Collections.Generic.IDictionary<PlayerProType , System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<PlayerProType,System.Int32>", 0)]
            public partial void CTOR(nint dict); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.SerializationInfo", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 1)]
            public partial void CTOR(nint info, System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Void Add(PlayerProType key, System.Int32 value)
            /// </summary>
            /// <param name = "key">enum PlayerProType</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void ADD(PlayerProType key, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void Add(System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32> item)
            /// </summary>
            /// <param name = "item">struct System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<PlayerProType,System.Int32>", 0)]
            public partial void ADD(System.Collections.Generic.KeyValuePair<PlayerProType, System.Int32> item); 
*/
            /// <summary>
            ///   System.Void Add(System.Object key, System.Object value)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void ADD(nint key, nint value); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CLEAR(); 
*/
            /// <summary>
            ///   System.Boolean Contains(System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32> item)
            /// </summary>
            /// <param name = "item">struct System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<PlayerProType,System.Int32>", 0)]
            public partial System.Boolean CONTAINS(System.Collections.Generic.KeyValuePair<PlayerProType, System.Int32> item); 
*/
            /// <summary>
            ///   System.Boolean Contains(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean CONTAINS(nint key); 
*/
            /// <summary>
            ///   System.Boolean ContainsKey(PlayerProType key)
            /// </summary>
            /// <param name = "key">enum PlayerProType</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ContainsKey", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            public partial System.Boolean CONTAINS_KEY(PlayerProType key); 
*/
            /// <summary>
            ///   System.Void CopyFrom(System.Collections.Generic.IDictionary<PlayerProType , System.Int32> dict)
            /// </summary>
            /// <param name = "dict">interface System.Collections.Generic.IDictionary<PlayerProType , System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyFrom", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<PlayerProType,System.Int32>", 0)]
            public partial void COPY_FROM(nint dict); 
*/
            /// <summary>
            ///   System.Void CopyTo(System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32>[] array, System.Int32 arrayIndex)
            /// </summary>
            /// <param name = "array">class System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32>[]</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<PlayerProType,System.Int32>[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void COPY_TO(nint array, System.Int32 arrayIndex); 
*/
            /// <summary>
            ///   System.Void CopyTo(System.Array array, System.Int32 index)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void COPY_TO(nint array, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 get_Count()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Count", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Int32 GET_COUNT(); 
*/
            /// <summary>
            ///   System.Boolean get_IsFixedSize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsFixedSize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Boolean GET_IS_FIXED_SIZE(); 
*/
            /// <summary>
            ///   System.Boolean get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Boolean GET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Boolean get_IsSynchronized()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_IsSynchronized", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial System.Boolean GET_IS_SYNCHRONIZED(); 
*/
            /// <summary>
            ///   System.Int32 get_Item(PlayerProType key)
            /// </summary>
            /// <param name = "key">enum PlayerProType</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            public partial System.Int32 GET_ITEM(PlayerProType key); 
*/
            /// <summary>
            ///   System.Object get_Item(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial nint GET_ITEM(nint key); 
*/
            /// <summary>
            ///   System.Collections.Generic.ICollection<PlayerProType> get_Keys()
            /// </summary>
            /// <returns>interface System.Collections.Generic.ICollection<PlayerProType></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Keys", "System.Collections.Generic.ICollection<PlayerProType>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint GET_KEYS(); 
*/
            /// <summary>
            ///   System.Object get_SyncRoot()
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_SyncRoot", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint GET_SYNC_ROOT(); 
*/
            /// <summary>
            ///   System.Collections.Generic.ICollection<System.Int32> get_Values()
            /// </summary>
            /// <returns>interface System.Collections.Generic.ICollection<System.Int32></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Values", "System.Collections.Generic.ICollection<System.Int32>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint GET_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32>> GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32>></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<PlayerProType,System.Int32>>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetObjectData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.SerializationInfo", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 1)]
            public partial void GET_OBJECT_DATA(nint info, System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///  abstract System.Int32 GetValue(System.Int32[] storage, System.Int32 i)
            /// </summary>
            /// <param name = "storage">class System.Int32[]</param>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public abstract partial System.Int32 GET_VALUE(nint storage, System.Int32 i); 
*/
            /// <summary>
            ///   System.Void OnAfterDeserialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnAfterDeserialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void ON_AFTER_DESERIALIZE(); 
*/
            /// <summary>
            ///   System.Void OnBeforeSerialize()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnBeforeSerialize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void ON_BEFORE_SERIALIZE(); 
*/
            /// <summary>
            ///   System.Void OnDeserialization(System.Object sender)
            /// </summary>
            /// <param name = "sender">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("OnDeserialization", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial void ON_DESERIALIZATION(nint sender); 
*/
            /// <summary>
            ///   System.Boolean Remove(PlayerProType key)
            /// </summary>
            /// <param name = "key">enum PlayerProType</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            public partial System.Boolean REMOVE(PlayerProType key); 
*/
            /// <summary>
            ///   System.Boolean Remove(System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32> item)
            /// </summary>
            /// <param name = "item">struct System.Collections.Generic.KeyValuePair<PlayerProType , System.Int32></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.KeyValuePair<PlayerProType,System.Int32>", 0)]
            public partial System.Boolean REMOVE(System.Collections.Generic.KeyValuePair<PlayerProType, System.Int32> item); 
*/
            /// <summary>
            ///   System.Void Remove(System.Object key)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial void REMOVE(nint key); 
*/
            /// <summary>
            ///   System.Void set_Item(PlayerProType key, System.Int32 value)
            /// </summary>
            /// <param name = "key">enum PlayerProType</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_ITEM(PlayerProType key, System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Item(System.Object key, System.Object value)
            /// </summary>
            /// <param name = "key">class System.Object</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void SET_ITEM(nint key, nint value); 
*/
            /// <summary>
            ///  abstract System.Void SetValue(System.Int32[] storage, System.Int32 i, System.Int32 value)
            /// </summary>
            /// <param name = "storage">class System.Int32[]</param>
            /// <param name = "i">struct System.Int32</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public abstract partial void SET_VALUE(nint storage, System.Int32 i, System.Int32 value); 
*/
            /// <summary>
            ///   System.Collections.ICollection System.Collections.IDictionary.get_Keys()
            /// </summary>
            /// <returns>interface System.Collections.ICollection</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_Keys", "System.Collections.ICollection", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARYGET_KEYS(); 
*/
            /// <summary>
            ///   System.Collections.ICollection System.Collections.IDictionary.get_Values()
            /// </summary>
            /// <returns>interface System.Collections.ICollection</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.get_Values", "System.Collections.ICollection", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARYGET_VALUES(); 
*/
            /// <summary>
            ///   System.Collections.IDictionaryEnumerator System.Collections.IDictionary.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IDictionaryEnumerator</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IDictionary.GetEnumerator", "System.Collections.IDictionaryEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint SYSTEM_COLLECTIONS_I_DICTIONARY_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerable.GetEnumerator", "System.Collections.IEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial nint SYSTEM_COLLECTIONS_I_ENUMERABLE_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Boolean TryGetValue(PlayerProType key, System.Int32& value)
            /// </summary>
            /// <param name = "key">enum PlayerProType</param>
            /// <param name = "value">struct System.Int32&</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TryGetValue", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("PlayerProType", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32&", 1)]
            public partial System.Boolean TRY_GET_VALUE(PlayerProType key, System.Int32 &value); 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."SerializableDictionary`2"]
        /// </summary>
        partial struct Ptr_ProNumDictionary
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IDictionary<PlayerProType , System.Int32> dict)
            /// </summary>
            /// <param name = "dict">interface System.Collections.Generic.IDictionary<PlayerProType , System.Int32></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IDictionary<PlayerProType,System.Int32>", 0)]
            public partial void CTOR(nint dict); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            /// </summary>
            /// <param name = "info">class System.Runtime.Serialization.SerializationInfo</param>
            /// <param name = "context">struct System.Runtime.Serialization.StreamingContext</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.SerializationInfo", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Runtime.Serialization.StreamingContext", 1)]
            public partial void CTOR(nint info, System.Runtime.Serialization.StreamingContext context); 
*/
            /// <summary>
            ///   System.Int32 GetValue(System.Int32[] storage, System.Int32 i)
            /// </summary>
            /// <param name = "storage">class System.Int32[]</param>
            /// <param name = "i">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetValue", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 GET_VALUE(nint storage, System.Int32 i); 
*/
            /// <summary>
            ///   System.Void SetValue(System.Int32[] storage, System.Int32 i, System.Int32 value)
            /// </summary>
            /// <param name = "storage">class System.Int32[]</param>
            /// <param name = "i">struct System.Int32</param>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetValue", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition), typeof(System.Runtime.CompilerServices.CallConvCdecl)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial void SET_VALUE(nint storage, System.Int32 i, System.Int32 value); 
*/
        }
    }
}