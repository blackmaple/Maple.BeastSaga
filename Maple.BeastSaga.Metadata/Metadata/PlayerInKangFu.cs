namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerInKangFu"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerInKangFu>, Ptr_PlayerInKangFu>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerInKangFu", "PlayerInKangFu")]
    public partial class PlayerInKangFu
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerInKangFu(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerInKangFu(System.IntPtr ptr) => new Ptr_PlayerInKangFu(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerInKangFu ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_PlayerInKangFu ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerInKangFu"]
        /// </summary>
        partial struct Ptr_PlayerInKangFu
        {
            /// <summary>
            /// 0x10 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
            public partial nint _NAME { get; set; }


            /// <summary>
            /// 0x18 InKangFuDataSet _InKangFuData
            /// class ["Model.Runtime".""."InKangFuDataSet"]
            /// </summary>
            /// <returns>class InKangFuDataSet</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_InKangFuData", "InKangFuDataSet")]
            public partial InKangFuDataSet.Ptr_InKangFuDataSet _IN_KANG_FU_DATA { get; set; }


            /// <summary>
            /// 0x20 System.Collections.Generic.List<System.String> _DressKangFu
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressKangFu", "System.Collections.Generic.List<System.String>")]
           public partial nint _DRESS_KANG_FU { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Collections.Generic.Dictionary<System.Int32 , System.String> _DressQuickKangFu
            /// class ["mscorlib"."System.Collections.Generic"."Dictionary`2"]
            /// </summary>
            /// <returns>class System.Collections.Generic.Dictionary<System.Int32 , System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressQuickKangFu", "System.Collections.Generic.Dictionary<System.Int32,System.String>")]
           public partial nint _DRESS_QUICK_KANG_FU { get; set; } 
*/

            /// <summary>
            /// 0x30 System.Collections.Generic.List<System.String> _DressBigLoop
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressBigLoop", "System.Collections.Generic.List<System.String>")]
           public partial nint _DRESS_BIG_LOOP { get; set; } 
*/

            /// <summary>
            /// 0x38 System.Collections.Generic.List<System.String> _DressSmallLoop
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<System.String></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressSmallLoop", "System.Collections.Generic.List<System.String>")]
           public partial nint _DRESS_SMALL_LOOP { get; set; } 
*/

            /// <summary>
            /// 0x40 System.String _DressKangFuQing
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressKangFuQing", "System.String")]
           public partial nint _DRESS_KANG_FU_QING { get; set; } 
*/

            /// <summary>
            /// 0x48 System.Int32 _Lv
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Lv", "System.Int32")]
           public partial System.Int32 _LV { get; set; } 
*/

            /// <summary>
            /// 0x4C DressType _DressType
            /// enum ["Model.Runtime".""."DressType"]
            /// </summary>
            /// <returns>enum DressType</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DressType", "DressType")]
           public partial DressType _DRESS_TYPE { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerInKangFu"]
        /// </summary>
        partial struct Ptr_PlayerInKangFu
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
            ///   System.Void SetData(InKangFuDataSet inkangfuData, System.Int32 lv)
            /// </summary>
            /// <param name = "inkangfuData">class InKangFuDataSet</param>
            /// <param name = "lv">struct System.Int32</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("InKangFuDataSet", 0)]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Int32", 1)]
            public partial void SET_DATA(nint inkangfuData, System.Int32 lv); 
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
            ///   System.Void UpdateBigLoop(System.Collections.Generic.List<System.String> bigLoopInfo)
            /// </summary>
            /// <param name = "bigLoopInfo">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateBigLoop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            public partial void UPDATE_BIG_LOOP(nint bigLoopInfo); 
*/
            /// <summary>
            ///   System.Void UpdateKangFuInfo(System.Collections.Generic.List<System.String> kangFuInfo)
            /// </summary>
            /// <param name = "kangFuInfo">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateKangFuInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            public partial void UPDATE_KANG_FU_INFO(nint kangFuInfo); 
*/
            /// <summary>
            ///   System.Void UpdateKangFuQuckInfo(System.Collections.Generic.Dictionary<System.Int32 , System.String> dressQuickKangFu)
            /// </summary>
            /// <param name = "dressQuickKangFu">class System.Collections.Generic.Dictionary<System.Int32 , System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateKangFuQuckInfo", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.Dictionary<System.Int32,System.String>", 0)]
            public partial void UPDATE_KANG_FU_QUCK_INFO(nint dressQuickKangFu); 
*/
            /// <summary>
            ///   System.Void UpdateSmallLoop(System.Collections.Generic.List<System.String> smallLoopInfo)
            /// </summary>
            /// <param name = "smallLoopInfo">class System.Collections.Generic.List<System.String></param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("UpdateSmallLoop", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("System.Collections.Generic.List<System.String>", 0)]
            public partial void UPDATE_SMALL_LOOP(nint smallLoopInfo); 
*/
        }
    }
}