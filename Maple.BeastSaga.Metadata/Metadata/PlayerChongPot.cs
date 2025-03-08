namespace Maple.BeastSaga.Metadata
{
    /// <summary>
    /// class ["Model.Runtime".""."PlayerChongPot"]
    /// [System.Object]
    /// </summary>
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassParentMetadataAttribute<Maple.MonoGameAssistant.MetadataExtensions.MetadataCollector.ClassMetadataCollector<Ptr_PlayerChongPot>, Ptr_PlayerChongPot>]
    [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassModelMetadataAttribute("Model.Runtime", "", "PlayerChongPot", "PlayerChongPot")]
    public partial class PlayerChongPot
    {
        [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public unsafe readonly partial struct Ptr_PlayerChongPot(System.IntPtr ptr) : Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.IPtrMetadata
        {
            [System.Runtime.InteropServices.MarshalAsAttribute(System.Runtime.InteropServices.UnmanagedType.SysInt)]
            readonly System.IntPtr m_Pointer = ptr;
            public System.IntPtr Ptr => m_Pointer;

            public static implicit operator Ptr_PlayerChongPot(System.IntPtr ptr) => new Ptr_PlayerChongPot(ptr);
            public static implicit operator System.IntPtr(Ptr_PlayerChongPot ptr) => ptr.m_Pointer;
            public static implicit operator bool(Ptr_PlayerChongPot ptr) => ptr.m_Pointer != System.IntPtr.Zero;
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerChongPot"]
        /// </summary>
        partial struct Ptr_PlayerChongPot
        {
            /// <summary>
            /// 0x10 ChongPotDataSet _DataSet
            /// class ["Model.Runtime".""."ChongPotDataSet"]
            /// </summary>
            /// <returns>class ChongPotDataSet</returns>

            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_DataSet", "ChongPotDataSet")]
            public partial ChongPotDataSet.Ptr_ChongPotDataSet _DATA_SET { get; set; }


            /// <summary>
            /// 0x18 System.String _Name
            /// class ["mscorlib"."System"."String"]
            /// </summary>
            /// <returns>class System.String</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_Name", "System.String")]
           public partial nint _NAME { get; set; } 
*/

            /// <summary>
            /// 0x20 System.Collections.Generic.List<PlayerChong> _PutIn
            /// class ["mscorlib"."System.Collections.Generic"."List`1"]
            /// </summary>
            /// <returns>class System.Collections.Generic.List<PlayerChong></returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_PutIn", "System.Collections.Generic.List<PlayerChong>")]
           public partial nint _PUT_IN { get; set; } 
*/

            /// <summary>
            /// 0x28 System.Int32 _StartHour
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_StartHour", "System.Int32")]
           public partial System.Int32 _START_HOUR { get; set; } 
*/

            /// <summary>
            /// 0x2C System.Int32 _StartTime
            /// struct ["mscorlib"."System"."Int32"]
            /// </summary>
            /// <returns>struct System.Int32</returns>
            /*
           [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassPropertyMetadataAttribute("_StartTime", "System.Int32")]
           public partial System.Int32 _START_TIME { get; set; } 
*/
        }

        /// <summary>
        /// class ["Model.Runtime".""."PlayerChongPot"]
        /// </summary>
        partial struct Ptr_PlayerChongPot
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
            ///   System.Void ClearTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("ClearTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void CLEAR_TIME(); 
*/
            /// <summary>
            ///   System.Void SetData(ChongPotDataSet data)
            /// </summary>
            /// <param name = "data">class ChongPotDataSet</param>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("SetData", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodParameterMetadataAttribute("ChongPotDataSet", 0)]
            public partial void SET_DATA(nint data); 
*/
            /// <summary>
            ///   System.Void StartTime()
            /// </summary>
            /// <returns>struct System.Void</returns>
             /*
            [Maple.MonoGameAssistant.MetadataExtensions.MetadataGenerator.ClassMethodMetadataAttribute("StartTime", "System.Void", CallConvs = [typeof(System.Runtime.CompilerServices.CallConvSuppressGCTransition)])]
            public partial void START_TIME(); 
*/
        }
    }
}