using Maple.MonoGameAssistant.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Maple.BeastSaga.Metadata
{
    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoDictionary_BeastSaga
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x8 System.Int32[] _buckets
        /// </summary>
        [FieldOffset(0x8)]
        public readonly PMonoArray<Ref_MonoArray, int> _buckets;


        /// <summary>
        /// 0xC System.Collections.Generic.Dictionary.Entry<TKEY,TVALUE>[] _entries
        /// </summary>
        [FieldOffset(0xC)]
        public readonly PMonoArray _entries;


        /// <summary>
        /// 0x10 System.Int32 _comparer
        /// </summary>
        [FieldOffset(0x10)]
        public readonly nint _comparer;



        /// <summary>
        /// 0x14 System.Int32 _keys
        /// </summary>
        [FieldOffset(0x14)]
        public readonly nint _keys;




        /// <summary>
        /// 0x18 System.Int32 _values
        /// </summary>
        [FieldOffset(0x18)]
        public readonly nint _values;



        /// <summary>
        /// 0x1C System.Int32 _syncRoot
        /// </summary>
        [FieldOffset(0x1C)]
        public readonly nint _syncRoot;



        /// <summary>
        /// 0x20 System.Int32 _count;
        /// </summary>
        [FieldOffset(0x20)]
        public readonly int _count;


        /// <summary>
        /// 0x24 System.Int32 _freeList;
        /// </summary>
        [FieldOffset(0x24)]
        public readonly int _freeList;


        /// <summary>
        /// 0x28 System.Int32 _freeCount;
        /// </summary>
        [FieldOffset(0x28)]
        public readonly int _freeCount;


        /// <summary>
        /// 0x2C System.Int32 _version;
        /// </summary>
        [FieldOffset(0x2C)]
        public readonly int _version;

    }
}
