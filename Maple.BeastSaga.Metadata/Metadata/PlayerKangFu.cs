using Maple.MonoGameAssistant.Core;
using Maple.MonoGameAssistant.MetadataCollections;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerKangFu"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerKangFu>, Ptr_PlayerKangFu>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerKangFu", "PlayerKangFu")]
    public partial class PlayerKangFu
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerKangFu(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerKangFu(System.IntPtr ptr) => new Ptr_PlayerKangFu(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerKangFu ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_PlayerKangFu ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerKangFu"]
        /// </summary>
        partial struct Ptr_PlayerKangFu
        {
            /// <summary>
            /// 0x10 KangFuDataSet _KangFuData
            /// class ["Model.Runtime".""."KangFuDataSet"]
            /// </summary>
            /// <returns>class KangFuDataSet</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_KangFuData", "KangFuDataSet")]
            public partial KangFuDataSet.Ptr_KangFuDataSet _KANG_FU_DATA { get; set; }


            /// <summary>
            /// 0x18 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
            public partial nint _NAME { get; set; }


            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> HaveShanHaiLu
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("HaveShanHaiLu", "System.Collections.Generic.List<System.String>")]
            public partial SysPtrList<PMonoString> HAVE_SHAN_HAI_LU { get; set; }


            /// <summary>
            /// 0x28 System.Int32 _Lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Lv", "System.Int32")]
           public partial System.Int32 _LV { get; set; } 
*/

            /// <summary>
            /// 0x2C DressType _DressType
            /// enum ["Model.Runtime".""."DressType"]
            /// </summary>
            /// <returns>enum DressType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressType", "DressType")]
           public partial DressType _DRESS_TYPE { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Single _Exp
            /// struct ["mscorlib"."System"."Single"]
            /// </summary>
            /// <returns>struct System.Single</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Exp", "System.Single")]
           public partial System.Single _EXP { get; set; } 
*/

            /// <summary>
            /// 0x34 System.Int32 _AddLv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_AddLv", "System.Int32")]
           public partial System.Int32 _ADD_LV { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerKangFu"]
        /// </summary>
        partial struct Ptr_PlayerKangFu
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
            ///   System.Boolean AddShanHaiLu(ShanHaiLuDataSet shanHaiLuDataSet)
            /// </summary>
            /// <param name = "shanHaiLuDataSet">class ShanHaiLuDataSet</param>
            /// <returns>struct System.Boolean</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("AddShanHaiLu", "System.Boolean", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ShanHaiLuDataSet", 0)]
            public partial System.Boolean ADD_SHAN_HAI_LU(nint shanHaiLuDataSet); 
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
            ///   System.Collections.Generic.List<ShanHaiLuDataSet> GetShanHaiLu()
            /// </summary>
            /// <returns>class System.Collections.Generic.List<ShanHaiLuDataSet></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShanHaiLu", "System.Collections.Generic.List<ShanHaiLuDataSet>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint GET_SHAN_HAI_LU(); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> GetShanHaiLuSkills(ShanHaiLuDataSet shanHaiLuDataSet)
            /// </summary>
            /// <param name = "shanHaiLuDataSet">class ShanHaiLuDataSet</param>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShanHaiLuSkills", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ShanHaiLuDataSet", 0)]
            public partial nint GET_SHAN_HAI_LU_SKILLS(nint shanHaiLuDataSet); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> GetShanHaiLuSkills(ShanHaiLuDataSet shanHaiLuDataSet, System.Collections.Generic.Dictionary<SkillDataSet , System.Single> changzhuSkill)
            /// </summary>
            /// <param name = "shanHaiLuDataSet">class ShanHaiLuDataSet</param>
            /// <param name = "changzhuSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShanHaiLuSkills", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ShanHaiLuDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 1)]
            public partial nint GET_SHAN_HAI_LU_SKILLS(nint shanHaiLuDataSet, nint changzhuSkill); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , SkillDataInfo> GetShanHaiLuSkillsBuff(ShanHaiLuDataSet shanHaiLuDataSet, System.Collections.Generic.Dictionary<SkillDataSet , System.Single> changzhuSkill)
            /// </summary>
            /// <param name = "shanHaiLuDataSet">class ShanHaiLuDataSet</param>
            /// <param name = "changzhuSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , SkillDataInfo></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("GetShanHaiLuSkillsBuff", "System.Collections.Generic.Dictionary<SkillDataSet,SkillDataInfo>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ShanHaiLuDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 1)]
            public partial nint GET_SHAN_HAI_LU_SKILLS_BUFF(nint shanHaiLuDataSet, nint changzhuSkill); 
*/
            /// <summary>
            ///   System.Single KangFuAttack()
            /// </summary>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("KangFuAttack", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial System.Single KANG_FU_ATTACK(); 
*/
            /// <summary>
            ///   System.Void SetData(KangFuDataSet kangFuDataSet, System.Int32 lv)
            /// </summary>
            /// <param name = "kangFuDataSet">class KangFuDataSet</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("KangFuDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_DATA(nint kangFuDataSet, System.Int32 lv); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> SkillCalculate()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillCalculate", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SKILL_CALCULATE(); 
*/
            /// <summary>
            ///   System.Single SkillChangZhu(System.Collections.Generic.Dictionary<SkillDataSet , System.Single> changzhuSkill, System.String skillName)
            /// </summary>
            /// <param name = "changzhuSkill">class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></param>
            /// <param name = "skillName">class System.String</param>
            /// <returns>struct System.Single</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillChangZhu", "System.Single", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.String", 1)]
            public partial System.Single SKILL_CHANG_ZHU(nint changzhuSkill, nint skillName); 
*/
        }
    }
}