namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["ExcelData"."ExcelData"."YiExpItem"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_YiExpItem>, Ptr_YiExpItem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("ExcelData", "ExcelData", "YiExpItem", "ExcelData.YiExpItem")]
    public partial class YiExpItem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_YiExpItem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_YiExpItem(System.IntPtr ptr) => new Ptr_YiExpItem(ptr);
            public static implicit operator System.IntPtr(Ptr_YiExpItem ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_YiExpItem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."YiExpItem"]
        /// </summary>
        partial struct Ptr_YiExpItem
        {
            /// <summary>
            /// 0x10 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
           public partial System.Int32 ID { get; set; } 
*/

            /// <summary>
            /// 0x14 System.Int32 levelexp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("levelexp", "System.Int32")]
           public partial System.Int32 LEVELEXP { get; set; } 
*/

            /// <summary>
            /// 0x18 System.Int32 totalexp
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("totalexp", "System.Int32")]
            public partial System.Int32 TOTALEXP { get; set; }

        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."YiExpItem"]
        /// </summary>
        partial struct Ptr_YiExpItem
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