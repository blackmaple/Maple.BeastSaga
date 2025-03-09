using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."SaveFriendData"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_SaveFriendData>, Ptr_SaveFriendData>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "SaveFriendData", "SaveFriendData")]
    public partial class SaveFriendData
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_SaveFriendData(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_SaveFriendData(System.IntPtr ptr) => new Ptr_SaveFriendData(ptr);
            public static implicit operator System.IntPtr(Ptr_SaveFriendData ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_SaveFriendData ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."SaveFriendData"]
        /// </summary>
        partial struct Ptr_SaveFriendData
        {
            /// <summary>
            /// 0x10 System.Collections.Generic.Dictionary<System.String , FriendData> AddFriends
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , FriendData></returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddFriends", "System.Collections.Generic.Dictionary<System.String,FriendData>")]
            public partial  PMonoDictionary_BeastSaga<PMonoString,FriendData.Ptr_FriendData> ADD_FRIENDS { get; set; } 
 

            /// <summary>
            /// 0x18 System.Collections.Generic.Dictionary<System.String , FriendData> LeaveFriends
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , FriendData></returns>
            
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LeaveFriends", "System.Collections.Generic.Dictionary<System.String,FriendData>")]
            public partial PMonoDictionary_BeastSaga<PMonoString, FriendData.Ptr_FriendData> LEAVE_FRIENDS { get; set; } 
 

            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> LeaveAllFriends
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("LeaveAllFriends", "System.Collections.Generic.List<System.String>")]
            public partial nint LEAVE_ALL_FRIENDS { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.List<System.String> AddAllFriends
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("AddAllFriends", "System.Collections.Generic.List<System.String>")]
            public partial nint ADD_ALL_FRIENDS { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<System.String> BattleFriend
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("BattleFriend", "System.Collections.Generic.List<System.String>")]
            public partial nint BATTLE_FRIEND { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."SaveFriendData"]
        /// </summary>
        partial struct Ptr_SaveFriendData
        {
            /// <summary>
            ///   System.Void .ctor()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute(".ctor", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CTOR(); 
*/
            /// <summary>
            ///   System.Void CheckData(System.Boolean isAdd)
            /// </summary>
            /// <param name = "isAdd">struct System.Boolean</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Boolean", 0)]
            public partial void CHECK_DATA(System.Boolean isAdd); 
*/
        }
    }
}