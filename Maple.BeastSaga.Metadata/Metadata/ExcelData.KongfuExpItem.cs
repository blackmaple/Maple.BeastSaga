namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["ExcelData"."ExcelData"."KongfuExpItem"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_KongfuExpItem>, Ptr_KongfuExpItem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("ExcelData", "ExcelData", "KongfuExpItem", "ExcelData.KongfuExpItem")]
    public partial class KongfuExpItem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_KongfuExpItem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_KongfuExpItem(System.IntPtr ptr) => new Ptr_KongfuExpItem(ptr);
            public static implicit operator System.IntPtr(Ptr_KongfuExpItem ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_KongfuExpItem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."KongfuExpItem"]
        /// </summary>
        partial struct Ptr_KongfuExpItem
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
        /// class ["ExcelData"."ExcelData"."KongfuExpItem"]
        /// </summary>
        partial struct Ptr_KongfuExpItem
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