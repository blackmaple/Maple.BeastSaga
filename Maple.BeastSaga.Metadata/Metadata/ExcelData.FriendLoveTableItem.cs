using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["ExcelData"."ExcelData"."FriendLoveTableItem"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_FriendLoveTableItem>, Ptr_FriendLoveTableItem>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("ExcelData", "ExcelData", "FriendLoveTableItem", "ExcelData.FriendLoveTableItem")]
    public partial class FriendLoveTableItem
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_FriendLoveTableItem(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_FriendLoveTableItem(System.IntPtr ptr) => new Ptr_FriendLoveTableItem(ptr);
            public static implicit operator System.IntPtr(Ptr_FriendLoveTableItem ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_FriendLoveTableItem ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."FriendLoveTableItem"]
        /// </summary>
        partial struct Ptr_FriendLoveTableItem
        {
            /// <summary>
            /// 0x10 System.String name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
         
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name", "System.String")]
            public partial PMonoString NAME { get; set; } 
 

            /// <summary>
            /// 0x18 System.String name2
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("name2", "System.String")]
            public partial PMonoString NAME2 { get; set; } 
 

            /// <summary>
            /// 0x20 System.String conversation
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("conversation", "System.String")]
            public partial nint CONVERSATION { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 id
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
         
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("id", "System.Int32")]
            public partial System.Int32 ID { get; set; } 
 

            /// <summary>
            /// 0x2C System.Int32 lovenum
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("lovenum", "System.Int32")]
            public partial System.Int32 LOVENUM { get; set; } 
*/
        }

        /// <summary>
        /// class ["ExcelData"."ExcelData"."FriendLoveTableItem"]
        /// </summary>
        partial struct Ptr_FriendLoveTableItem
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