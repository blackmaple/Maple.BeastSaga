namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["ExcelData"."ExcelData"."FriendLoveTable"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_FriendLoveTable>, Ptr_FriendLoveTable>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("ExcelData", "ExcelData", "FriendLoveTable", "ExcelData.FriendLoveTable")]
    public partial class FriendLoveTable
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_FriendLoveTable(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_FriendLoveTable(System.IntPtr ptr) => new Ptr_FriendLoveTable(ptr);
            public static implicit operator System.IntPtr(Ptr_FriendLoveTable ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_FriendLoveTable ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."FriendLoveTable"]
        /// </summary>
        partial struct Ptr_FriendLoveTable
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.Dictionary<System.Int32 , ExcelData.FriendLoveTableItem> Dict
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , ExcelData.FriendLoveTableItem></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Dict", "System.Collections.Generic.Dictionary<System.Int32,ExcelData.FriendLoveTableItem>")]
            public partial PMonoDictionary_BeastSaga<int, FriendLoveTableItem.Ptr_FriendLoveTableItem> DICT { get; set; }

        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."FriendLoveTable"]
        /// </summary>
        partial struct Ptr_FriendLoveTable
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
        }
    }
}