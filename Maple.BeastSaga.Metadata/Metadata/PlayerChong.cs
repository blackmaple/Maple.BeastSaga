namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerChong"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerChong>, Ptr_PlayerChong>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerChong", "PlayerChong")]
    public partial class PlayerChong
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerChong(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerChong(System.IntPtr ptr) => new Ptr_PlayerChong(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerChong ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_PlayerChong ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerChong"]
        /// </summary>
        partial struct Ptr_PlayerChong
        {
            /// <summary>
            /// 0x10 ChongDataSet _DataSet
            /// class ["Model.Runtime".""."ChongDataSet"]
            /// </summary>
            /// <returns>class ChongDataSet</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DataSet", "ChongDataSet")]
            public partial ChongDataSet.Ptr_ChongDataSet _DATA_SET { get; set; }


            /// <summary>
            /// 0x18 System.String d_dataname
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("d_dataname", "System.String")]
           public partial nint D_DATANAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.String _CustomName
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_CustomName", "System.String")]
           public partial nint _CUSTOM_NAME { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.String , System.Single> _Skill
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Skill", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
           public partial nint _SKILL { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.Dictionary<System.String , System.Single> _Preference
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.String , System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Preference", "System.Collections.Generic.Dictionary<System.String,System.Single>")]
           public partial nint _PREFERENCE { get; set; } 
*/

            /// <summary>
            /// 0x38 System.String _Icon
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Icon", "System.String")]
           public partial nint _ICON { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String path_icon
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("path_icon", "System.String")]
           public partial nint PATH_ICON { get; set; } 
*/

            /// <summary>
            /// 0x48 UnityEngine.Texture _Texture
            /// class ["UnityEngine.CoreModule"."UnityEngine"."Texture"]
            /// </summary>
            /// <returns>class UnityEngine.Texture</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Texture", "UnityEngine.Texture")]
           public partial nint _TEXTURE { get; set; } 
*/

            /// <summary>
            /// 0x50 System.String tou
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("tou", "System.String")]
           public partial nint TOU { get; set; } 
*/

            /// <summary>
            /// 0x58 System.String xiong
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("xiong", "System.String")]
           public partial nint XIONG { get; set; } 
*/

            /// <summary>
            /// 0x60 System.String fu
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("fu", "System.String")]
           public partial nint FU { get; set; } 
*/

            /// <summary>
            /// 0x68 System.String chi
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("chi", "System.String")]
           public partial nint CHI { get; set; } 
*/

            /// <summary>
            /// 0x70 System.Int32 _Foster
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Foster", "System.Int32")]
           public partial System.Int32 _FOSTER { get; set; } 
*/

            /// <summary>
            /// 0x74 System.Int32 _FosterMax
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_FosterMax", "System.Int32")]
           public partial System.Int32 _FOSTER_MAX { get; set; } 
*/

            /// <summary>
            /// 0x78 System.Int32 _TotalProperty
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_TotalProperty", "System.Int32")]
           public partial System.Int32 _TOTAL_PROPERTY { get; set; } 
*/

            /// <summary>
            /// 0x7C System.Int32 Power
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Power", "System.Int32")]
           public partial System.Int32 POWER { get; set; } 
*/

            /// <summary>
            /// 0x80 System.Int32 Agility
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("Agility", "System.Int32")]
           public partial System.Int32 AGILITY { get; set; } 
*/

            /// <summary>
            /// 0x84 System.Int32 PhysicalPower
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("PhysicalPower", "System.Int32")]
           public partial System.Int32 PHYSICAL_POWER { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerChong"]
        /// </summary>
        partial struct Ptr_PlayerChong
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
            ///   System.Void CheckDataSet()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("CheckDataSet", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CHECK_DATA_SET(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> GetPreference()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetPreference", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_PREFERENCE(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> GetSkill()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetSkill", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SKILL(); 
*/
            /// <summary>
            ///   System.Int32 GetTotalProperty()
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetTotalProperty", "System.Int32", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Int32 GET_TOTAL_PROPERTY(); 
*/
            /// <summary>
            ///   System.Void InitIcon()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitIcon", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void INIT_ICON(); 
*/
            /// <summary>
            ///   System.Void ProChangeSpine(SkillDataSet dataset)
            /// </summary>
            /// <param name = "dataset">class SkillDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ProChangeSpine", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("SkillDataSet", 0)]
            public partial void PRO_CHANGE_SPINE(nint dataset); 
*/
            /// <summary>
            ///   System.Void RefreshSkillVaule(System.Collections.Generic.Dictionary<SkillDataSet , System.Single> list)
            /// </summary>
            /// <param name = "list">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("RefreshSkillVaule", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 0)]
            public partial void REFRESH_SKILL_VAULE(nint list); 
*/
            /// <summary>
            ///   System.Void SetData(ChongDataSet data)
            /// </summary>
            /// <param name = "data">class ChongDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ChongDataSet", 0)]
            public partial void SET_DATA(nint data); 
*/
        }
    }
}