using Maple.MonoGameAssistant.Core;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Maple.BeastSaga.Metadata
{

#if !WIN32

    [StructLayout(LayoutKind.Explicit)]
    public readonly unsafe partial struct Ref_MonoList_BeastSaga
    {
        [FieldOffset(0)]
        public readonly REF_MONO_OBJECT _obj;

        /// <summary>
        /// 0x10 AchievementData[] _items
        /// </summary>
        [FieldOffset(0x8)]
        public readonly PMonoArray _items;


        /// <summary>
        /// 0x18 System.Int32 _size
        /// </summary>
        [FieldOffset(0xC)]
        public readonly System.Int32 _size;


        /// <summary>
        /// 0x1C System.Int32 _version
        /// </summary>
        [FieldOffset(0x10)]
        public readonly System.Int32 _version;


        /// <summary>
        /// 0x20 System.Object _syncRoot
        /// </summary>
        [FieldOffset(0x14)]
        public readonly nint _syncRoot;

    }

#else

    //[StructLayout(LayoutKind.Explicit)]
    //public readonly unsafe partial struct Ref_MonoList_BeastSaga
    //{
    //    [FieldOffset(0)]
    //    public readonly REF_MONO_OBJECT _obj;

    //    /// <summary>
    //    /// 0x10 AchievementData[] _items
    //    /// </summary>
    //    [FieldOffset(0x10)]
    //    public readonly PMonoArray _items;


    //    /// <summary>
    //    /// 0x18 System.Int32 _size
    //    /// </summary>
    //    [FieldOffset(0x18)]
    //    public readonly System.Int32 _size;


    //    /// <summary>
    //    /// 0x1C System.Int32 _version
    //    /// </summary>
    //    [FieldOffset(0x1C)]
    //    public readonly System.Int32 _version;


    //    /// <summary>
    //    /// 0x20 System.Object _syncRoot
    //    /// </summary>
    //    [FieldOffset(0x20)]
    //    public readonly nint _syncRoot;

    //}


#endif
    readonly unsafe partial struct Ref_MonoList_BeastSaga : IRefMonoList
    {
        public readonly PMonoArray Items => _items;

        public readonly int Size => _size;


    }

    [StructLayout(LayoutKind.Sequential)]
    public readonly unsafe partial struct PMonoList_BeastSaga<T_DATA>(nint ptr) : IPtrMonoList<Ref_MonoList_BeastSaga, T_DATA>
   where T_DATA : unmanaged
    {

        [MarshalAs(UnmanagedType.SysInt)]
        readonly nint _ptr = ptr;
        public static implicit operator PMonoList_BeastSaga<T_DATA>(nint ptr) => new(ptr);
        public static implicit operator nint(PMonoList_BeastSaga<T_DATA> obj) => obj._ptr;

        public static implicit operator PMonoList(PMonoList_BeastSaga<T_DATA> obj) => new(obj._ptr);
        public static implicit operator PMonoList_BeastSaga<T_DATA>(PMonoList obj) => new(obj);

        public override string ToString()
        {
            return _ptr.ToString("X8");
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Valid() => _ptr != nint.Zero;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref Ref_MonoList_BeastSaga AsRef()
            => ref _ptr.AsRefStruct<Ref_MonoList_BeastSaga>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<T_DATA> AsReadOnlySpan()
            => this.AsReadOnlySpan<PMonoList_BeastSaga<T_DATA>, Ref_MonoList_BeastSaga, T_DATA>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ref T_DATA RefElementAt(int index)
            => ref this.RefElementAt<PMonoList_BeastSaga<T_DATA>, Ref_MonoList_BeastSaga, T_DATA>(index);

        public ref T_DATA this[int index] => ref this.RefElementAt(index);

        public int Size => AsRef().Size;

        public IEnumerable<T_DATA> AsEnumerable()
        {
            var size = this.Size;
            for (int i = 0; i < size; ++i)
            {
                yield return this[i % size];
            }
        }

        public Enumerator GetEnumerator() => new(this);

        public struct Enumerator(PMonoList_BeastSaga<T_DATA> list)
        {
            private int _index = 0;
            private readonly int _size = list.Size;
            private T_DATA _current = default;

            public readonly void Dispose() { }

            public readonly T_DATA Current => _current;

            public bool MoveNext()
            {
                if (((uint)_index < (uint)_size))
                {
                    _current = list[_index];
                    _index++;
                    return true;
                }
                return false;
            }
        }
    }



}

