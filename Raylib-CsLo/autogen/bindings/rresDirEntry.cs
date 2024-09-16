//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct rresDirEntry
    {
        [NativeTypeName("unsigned int")]
        public uint id;

        [NativeTypeName("unsigned int")]
        public uint offset;

        [NativeTypeName("unsigned int")]
        public uint reserved;

        [NativeTypeName("unsigned int")]
        public uint fileNameSize;

        [NativeTypeName("char[1024]")]
        public _fileName_e__FixedBuffer fileName;

        [InlineArray(1024)]
        public partial struct _fileName_e__FixedBuffer
        {
            public sbyte e0;
        }
    }
}
