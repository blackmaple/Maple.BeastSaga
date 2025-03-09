using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerKangFuSkill"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerKangFuSkill>, Ptr_PlayerKangFuSkill>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerKangFuSkill", "PlayerKangFuSkill")]
    public partial class PlayerKangFuSkill
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerKangFuSkill(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerKangFuSkill(System.IntPtr ptr) => new Ptr_PlayerKangFuSkill(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerKangFuSkill ptr) => ptr.m_Pointer;
            public static implicit operator bool (Ptr_PlayerKangFuSkill ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerKangFuSkill"]
        /// </summary>
        partial struct Ptr_PlayerKangFuSkill
        {
            /// <summary>
            /// 0x10 UniqueSkillDataSet _UniqueSkillData
            /// class ["Model.Runtime".""."UniqueSkillDataSet"]
            /// </summary>
            /// <returns>class UniqueSkillDataSet</returns>
          
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_UniqueSkillData", "UniqueSkillDataSet")]
            public partial UniqueSkillDataSet.Ptr_UniqueSkillDataSet _UNIQUE_SKILL_DATA { get; set; } 
 

            /// <summary>
            /// 0x18 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
             
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
            public partial PMonoString _NAME { get; set; } 
 

            /// <summary>
            /// 0x20 System.Int32 _Lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Lv", "System.Int32")]
            public partial System.Int32 _LV { get; set; } 
*/

            /// <summary>
            /// 0x24 DressType _DressType
            /// enum ["Model.Runtime".""."DressType"]
            /// </summary>
            /// <returns>enum DressType</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressType", "DressType")]
            public partial DressType _DRESS_TYPE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerKangFuSkill"]
        /// </summary>
        partial struct Ptr_PlayerKangFuSkill
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
            ///   System.Void SetData(UniqueSkillDataSet uniqueSkillDataSet, System.Int32 lv)
            /// </summary>
            /// <param name = "uniqueSkillDataSet">class UniqueSkillDataSet</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("UniqueSkillDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_DATA(nint uniqueSkillDataSet, System.Int32 lv); 
*/
            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> SkillCalculate()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillCalculate", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial nint SKILL_CALCULATE(); 
*/
        }
    }
}