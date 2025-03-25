using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataExtensions.MetadataObject;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["mscorlib"."System.Collections.Generic"."List`1"]
    /// [System.Object]
    /// [System.Collections.Generic.IList<EquipDataSet>]=>[System.Collections.Generic.ICollection<EquipDataSet>]=>[System.Collections.Generic.IEnumerable<EquipDataSet>]=>[System.Collections.IEnumerable]=>[System.Collections.IList]=>[System.Collections.ICollection]=>[System.Collections.Generic.IReadOnlyList<EquipDataSet>]=>[System.Collections.Generic.IReadOnlyCollection<EquipDataSet>]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassParentMetadataAttribute(typeof(Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.GenericClassMetadataCollector<>), typeof(ListGeneric<>.Ptr_ListGeneric))]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.GenericClassModelMetadataAttribute()]
    public partial class ListGeneric<TVALUE>
        where TVALUE : unmanaged
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_ListGeneric(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_ListGeneric(System.IntPtr ptr) => new Ptr_ListGeneric(ptr);
            public static implicit operator System.IntPtr(Ptr_ListGeneric ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_ListGeneric ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."List`1"]
        /// </summary>
        partial struct Ptr_ListGeneric
        {
            /// <summary>
            /// 0x0 System.Int32 DefaultCapacity
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           public const System.Int32 DEFAULT_CAPACITY = 4; 
*/
            /// <summary>
            /// 0x0 EquipDataSet[] s_emptyArray
            /// class ["Model.Runtime".""."EquipDataSet[]"]
            /// </summary>
            /// <returns>class EquipDataSet[]</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("s_emptyArray", "EquipDataSet[]")]
           public static partial nint S_EMPTY_ARRAY { get; set; } 
*/

            /// <summary>
            /// 0x10 EquipDataSet[] _items
            /// class ["Model.Runtime".""."EquipDataSet[]"]
            /// </summary>
            /// <returns>class EquipDataSet[]</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_items", default)]
            public partial PMonoArray<TVALUE> _ITEMS { get; set; }


            /// <summary>
            /// 0x18 System.Int32 _size
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_size", "System.Int32")]
            public partial System.Int32 _SIZE { get; set; }


            /// <summary>
            /// 0x1C System.Int32 _version
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_version", "System.Int32")]
           public partial System.Int32 _VERSION { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Object _syncRoot
            /// class ["mscorlib"."System"."Object"]
            /// </summary>
            /// <returns>class System.Object</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_syncRoot", "System.Object")]
           public partial nint _SYNC_ROOT { get; set; } 
*/
        }

        /// <summary>
        /// class ["mscorlib"."System.Collections.Generic"."List`1"]
        /// </summary>
        partial struct Ptr_ListGeneric
        {
            /// <summary>
            /// static  System.Void .cctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".cctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public static partial void CCTOR(); 
*/
            /// <summary>
            /// static  System.Boolean IsCompatibleObject(System.Object value)
            /// </summary>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IsCompatibleObject", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public static partial System.Boolean IS_COMPATIBLE_OBJECT(nint value); 
*/
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Int32 capacity)
            /// </summary>
            /// <param name = "capacity">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void CTOR(System.Int32 capacity); 
*/
            /// <summary>
            ///   System.Void .ctor(System.Collections.Generic.IEnumerable<EquipDataSet> collection)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<EquipDataSet>", 0)]
            public partial void CTOR(nint collection); 
*/
            /// <summary>
            ///   System.Void Add(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Add", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial void ADD(nint item); 
*/
            /// <summary>
            ///   System.Void AddEnumerable(System.Collections.Generic.IEnumerable<EquipDataSet> enumerable)
            /// </summary>
            /// <param name = "enumerable">interface System.Collections.Generic.IEnumerable<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddEnumerable", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<EquipDataSet>", 0)]
            public partial void ADD_ENUMERABLE(nint enumerable); 
*/
            /// <summary>
            ///   System.Void AddRange(System.Collections.Generic.IEnumerable<EquipDataSet> collection)
            /// </summary>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddRange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<EquipDataSet>", 0)]
            public partial void ADD_RANGE(nint collection); 
*/
            /// <summary>
            ///   System.Void AddWithResize(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddWithResize", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial void ADD_WITH_RESIZE(nint item); 
*/
            /// <summary>
            ///   System.Collections.ObjectModel.ReadOnlyCollection<EquipDataSet> AsReadOnly()
            /// </summary>
            /// <returns>class System.Collections.ObjectModel.ReadOnlyCollection<EquipDataSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AsReadOnly", "System.Collections.ObjectModel.ReadOnlyCollection<EquipDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint AS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Int32 BinarySearch(System.Int32 index, System.Int32 count, EquipDataSet item, System.Collections.Generic.IComparer<EquipDataSet> comparer)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "item">class EquipDataSet</param>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BinarySearch", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<EquipDataSet>", 3)]
            public partial System.Int32 BINARY_SEARCH(System.Int32 index, System.Int32 count, nint item, nint comparer); 
*/
            /// <summary>
            ///   System.Int32 BinarySearch(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BinarySearch", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial System.Int32 BINARY_SEARCH(nint item); 
*/
            /// <summary>
            ///   System.Int32 BinarySearch(EquipDataSet item, System.Collections.Generic.IComparer<EquipDataSet> comparer)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("BinarySearch", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<EquipDataSet>", 1)]
            public partial System.Int32 BINARY_SEARCH(nint item, nint comparer); 
*/
            /// <summary>
            ///   System.Void Clear()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Clear", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR(); 
*/
            /// <summary>
            ///   System.Boolean Contains(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial System.Boolean CONTAINS(nint item); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<TOutput> ConvertAll(System.Converter<EquipDataSet , TOutput> converter)
            /// </summary>
            /// <param name = "converter">class System.Converter<EquipDataSet , TOutput></param>
            /// <returns>class System.Collections.Generic.List<TOutput></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ConvertAll", "System.Collections.Generic.List<TOutput>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Converter<EquipDataSet,TOutput>", 0)]
            public partial nint CONVERT_ALL(nint converter); 
*/
            /// <summary>
            ///   System.Void CopyTo(EquipDataSet[] array)
            /// </summary>
            /// <param name = "array">class EquipDataSet[]</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet[]", 0)]
            public partial void COPY_TO(nint array); 
*/
            /// <summary>
            ///   System.Void CopyTo(System.Int32 index, EquipDataSet[] array, System.Int32 arrayIndex, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "array">class EquipDataSet[]</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet[]", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 3)]
            public partial void COPY_TO(System.Int32 index, nint array, System.Int32 arrayIndex, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void CopyTo(EquipDataSet[] array, System.Int32 arrayIndex)
            /// </summary>
            /// <param name = "array">class EquipDataSet[]</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet[]", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void COPY_TO(nint array, System.Int32 arrayIndex); 
*/
            /// <summary>
            ///   System.Void EnsureCapacity(System.Int32 min)
            /// </summary>
            /// <param name = "min">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("EnsureCapacity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void ENSURE_CAPACITY(System.Int32 min); 
*/
            /// <summary>
            ///   System.Boolean Exists(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Exists", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial System.Boolean EXISTS(nint match); 
*/
            /// <summary>
            ///   EquipDataSet Find(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>class EquipDataSet</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Find", "EquipDataSet", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial nint FIND(nint match); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<EquipDataSet> FindAll(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>class System.Collections.Generic.List<EquipDataSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindAll", "System.Collections.Generic.List<EquipDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial nint FIND_ALL(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindIndex(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial System.Int32 FIND_INDEX(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindIndex(System.Int32 startIndex, System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 1)]
            public partial System.Int32 FIND_INDEX(System.Int32 startIndex, nint match); 
*/
            /// <summary>
            ///   System.Int32 FindIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 2)]
            public partial System.Int32 FIND_INDEX(System.Int32 startIndex, System.Int32 count, nint match); 
*/
            /// <summary>
            ///   EquipDataSet FindLast(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>class EquipDataSet</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLast", "EquipDataSet", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial nint FIND_LAST(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindLastIndex(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLastIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial System.Int32 FIND_LAST_INDEX(nint match); 
*/
            /// <summary>
            ///   System.Int32 FindLastIndex(System.Int32 startIndex, System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLastIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 1)]
            public partial System.Int32 FIND_LAST_INDEX(System.Int32 startIndex, nint match); 
*/
            /// <summary>
            ///   System.Int32 FindLastIndex(System.Int32 startIndex, System.Int32 count, System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "startIndex">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("FindLastIndex", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 2)]
            public partial System.Int32 FIND_LAST_INDEX(System.Int32 startIndex, System.Int32 count, nint match); 
*/
            /// <summary>
            ///   System.Void ForEach(System.Action<EquipDataSet> action)
            /// </summary>
            /// <param name = "action">class System.Action<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ForEach", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Action<EquipDataSet>", 0)]
            public partial void FOR_EACH(nint action); 
*/
            /// <summary>
            ///   System.Int32 get_Capacity()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Capacity", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_CAPACITY(); 
*/
            /// <summary>
            ///   System.Int32 get_Count()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Count", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_COUNT(); 
*/
            /// <summary>
            ///   EquipDataSet get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class EquipDataSet</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("get_Item", "EquipDataSet", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint GET_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Collections.Generic.List.Enumerator<EquipDataSet> GetEnumerator()
            /// </summary>
            /// <returns>struct System.Collections.Generic.List.Enumerator<EquipDataSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetEnumerator", "System.Collections.Generic.List.Enumerator<EquipDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Collections.Generic.List.Enumerator<EquipDataSet> GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Collections.Generic.List<EquipDataSet> GetRange(System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>class System.Collections.Generic.List<EquipDataSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetRange", "System.Collections.Generic.List<EquipDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial nint GET_RANGE(System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial System.Int32 INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(EquipDataSet item, System.Int32 index)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 INDEX_OF(nint item, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 IndexOf(EquipDataSet item, System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Int32 INDEX_OF(nint item, System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void Insert(System.Int32 index, EquipDataSet item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Insert", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 1)]
            public partial void INSERT(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Void InsertRange(System.Int32 index, System.Collections.Generic.IEnumerable<EquipDataSet> collection)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "collection">interface System.Collections.Generic.IEnumerable<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InsertRange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IEnumerable<EquipDataSet>", 1)]
            public partial void INSERT_RANGE(System.Int32 index, nint collection); 
*/
            /// <summary>
            ///   System.Int32 LastIndexOf(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial System.Int32 LAST_INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Int32 LastIndexOf(EquipDataSet item, System.Int32 index)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial System.Int32 LAST_INDEX_OF(nint item, System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 LastIndexOf(EquipDataSet item, System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("LastIndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 2)]
            public partial System.Int32 LAST_INDEX_OF(nint item, System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Boolean Remove(EquipDataSet item)
            /// </summary>
            /// <param name = "item">class EquipDataSet</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Remove", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 0)]
            public partial System.Boolean REMOVE(nint item); 
*/
            /// <summary>
            ///   System.Int32 RemoveAll(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAll", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial System.Int32 REMOVE_ALL(nint match); 
*/
            /// <summary>
            ///   System.Void RemoveAt(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveAt", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void REMOVE_AT(System.Int32 index); 
*/
            /// <summary>
            ///   System.Void RemoveRange(System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RemoveRange", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void REMOVE_RANGE(System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void Reverse()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reverse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void REVERSE(); 
*/
            /// <summary>
            ///   System.Void Reverse(System.Int32 index, System.Int32 count)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Reverse", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void REVERSE(System.Int32 index, System.Int32 count); 
*/
            /// <summary>
            ///   System.Void set_Capacity(System.Int32 value)
            /// </summary>
            /// <param name = "value">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Capacity", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial void SET_CAPACITY(System.Int32 value); 
*/
            /// <summary>
            ///   System.Void set_Item(System.Int32 index, EquipDataSet value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class EquipDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("EquipDataSet", 1)]
            public partial void SET_ITEM(System.Int32 index, nint value); 
*/
            /// <summary>
            ///   System.Void Sort()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void SORT(); 
*/
            /// <summary>
            ///   System.Void Sort(System.Collections.Generic.IComparer<EquipDataSet> comparer)
            /// </summary>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<EquipDataSet>", 0)]
            public partial void SORT(nint comparer); 
*/
            /// <summary>
            ///   System.Void Sort(System.Int32 index, System.Int32 count, System.Collections.Generic.IComparer<EquipDataSet> comparer)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "count">struct System.Int32</param>
            /// <param name = "comparer">interface System.Collections.Generic.IComparer<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.IComparer<EquipDataSet>", 2)]
            public partial void SORT(System.Int32 index, System.Int32 count, nint comparer); 
*/
            /// <summary>
            ///   System.Void Sort(System.Comparison<EquipDataSet> comparison)
            /// </summary>
            /// <param name = "comparison">class System.Comparison<EquipDataSet></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("Sort", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Comparison<EquipDataSet>", 0)]
            public partial void SORT(nint comparison); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.Generic.ICollection<T>.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.ICollection<T>.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_GENERIC_I_COLLECTION_TGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Collections.Generic.IEnumerator<EquipDataSet> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.Generic.IEnumerator<EquipDataSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.Generic.IEnumerable<T>.GetEnumerator", "System.Collections.Generic.IEnumerator<EquipDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_GENERIC_I_ENUMERABLE_T_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Void System.Collections.ICollection.CopyTo(System.Array array, System.Int32 arrayIndex)
            /// </summary>
            /// <param name = "array">abstract class System.Array</param>
            /// <param name = "arrayIndex">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.CopyTo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Array", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SYSTEM_COLLECTIONS_I_COLLECTION_COPY_TO(nint array, System.Int32 arrayIndex); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.ICollection.get_IsSynchronized()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.get_IsSynchronized", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_COLLECTIONGET_IS_SYNCHRONIZED(); 
*/
            /// <summary>
            ///   System.Object System.Collections.ICollection.get_SyncRoot()
            /// </summary>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.ICollection.get_SyncRoot", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_COLLECTIONGET_SYNC_ROOT(); 
*/
            /// <summary>
            ///   System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            /// </summary>
            /// <returns>interface System.Collections.IEnumerator</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IEnumerable.GetEnumerator", "System.Collections.IEnumerator", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SYSTEM_COLLECTIONS_I_ENUMERABLE_GET_ENUMERATOR(); 
*/
            /// <summary>
            ///   System.Int32 System.Collections.IList.Add(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Add", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Int32 SYSTEM_COLLECTIONS_I_LIST_ADD(nint item); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.Contains(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Contains", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_LIST_CONTAINS(nint item); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsFixedSize()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_IsFixedSize", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_LISTGET_IS_FIXED_SIZE(); 
*/
            /// <summary>
            ///   System.Boolean System.Collections.IList.get_IsReadOnly()
            /// </summary>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_IsReadOnly", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Boolean SYSTEM_COLLECTIONS_I_LISTGET_IS_READ_ONLY(); 
*/
            /// <summary>
            ///   System.Object System.Collections.IList.get_Item(System.Int32 index)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <returns>class System.Object</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.get_Item", "System.Object", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            public partial nint SYSTEM_COLLECTIONS_I_LISTGET_ITEM(System.Int32 index); 
*/
            /// <summary>
            ///   System.Int32 System.Collections.IList.IndexOf(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.IndexOf", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial System.Int32 SYSTEM_COLLECTIONS_I_LIST_INDEX_OF(nint item); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.Insert(System.Int32 index, System.Object item)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Insert", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void SYSTEM_COLLECTIONS_I_LIST_INSERT(System.Int32 index, nint item); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.Remove(System.Object item)
            /// </summary>
            /// <param name = "item">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.Remove", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 0)]
            public partial void SYSTEM_COLLECTIONS_I_LIST_REMOVE(nint item); 
*/
            /// <summary>
            ///   System.Void System.Collections.IList.set_Item(System.Int32 index, System.Object value)
            /// </summary>
            /// <param name = "index">struct System.Int32</param>
            /// <param name = "value">class System.Object</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("System.Collections.IList.set_Item", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Object", 1)]
            public partial void SYSTEM_COLLECTIONS_I_LISTSET_ITEM(System.Int32 index, nint value); 
*/
            /// <summary>
            ///   EquipDataSet[] ToArray()
            /// </summary>
            /// <returns>class EquipDataSet[]</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ToArray", "EquipDataSet[]", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint TO_ARRAY(); 
*/
            /// <summary>
            ///   System.Void TrimExcess()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TrimExcess", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void TRIM_EXCESS(); 
*/
            /// <summary>
            ///   System.Boolean TrueForAll(System.Predicate<EquipDataSet> match)
            /// </summary>
            /// <param name = "match">class System.Predicate<EquipDataSet></param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("TrueForAll", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Predicate<EquipDataSet>", 0)]
            public partial System.Boolean TRUE_FOR_ALL(nint match); 
*/
        }

        partial struct Ptr_ListGeneric : ISysPtrList<TVALUE>
        {
            public PMonoArray<TVALUE> Items => _ITEMS;

            public int Size => _SIZE;
        }
    }
}