using Maple.MonoGameAssistant.Core;
using System.Runtime.InteropServices;

namespace Maple.BeastSaga.Metadata
{
#if WIN32


#else

# endif

    partial struct Ref_MonoDictionary_BeastSaga : IRefMonoDictionary
    {
        public int Count => _count;

        public int FreeCount => _freeCount;

        public PMonoArray Entries => _entries;


        public int Size => Count - FreeCount;

    }





}
