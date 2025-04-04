using Maple.MonoGameAssistant.Core;

namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerLifePerk"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerLifePerk>, Ptr_PlayerLifePerk>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerLifePerk", "PlayerLifePerk")]
    public partial class PlayerLifePerk
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerLifePerk(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerLifePerk(System.IntPtr ptr) => new Ptr_PlayerLifePerk(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerLifePerk ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_PlayerLifePerk ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerLifePerk"]
        /// </summary>
        partial struct Ptr_PlayerLifePerk
        {
            /// <summary>
            /// 0x10 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
            public partial PMonoString _NAME { get; set; }


            /// <summary>
            /// 0x18 LifePerkDataSet _LifePerkDataSet
            /// class ["Model.Runtime".""."LifePerkDataSet"]
            /// </summary>
            /// <returns>class LifePerkDataSet</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_LifePerkDataSet", "LifePerkDataSet")]
            public partial LifePerkDataSet.Ptr_LifePerkDataSet _LIFE_PERK_DATA_SET { get; set; }

        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerLifePerk"]
        /// </summary>
        partial struct Ptr_PlayerLifePerk
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
            ///   System.Void InitData(LifePerkDataSet lifeData)
            /// </summary>
            /// <param name = "lifeData">class LifePerkDataSet</param>
            /// <returns>struct System.Void</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("InitData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("LifePerkDataSet", 0)]
            public partial void INIT_DATA(nint lifeData);

            /// <summary>
            ///   System.Collections.Generic.Dictionary<SkillDataSet , System.Single> SkillTotalCalculate()
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<SkillDataSet , System.Single></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SkillTotalCalculate", "System.Collections.Generic.Dictionary<SkillDataSet,System.Single>", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
           public partial nint SKILL_TOTAL_CALCULATE(); 
*/
        }
    }
}