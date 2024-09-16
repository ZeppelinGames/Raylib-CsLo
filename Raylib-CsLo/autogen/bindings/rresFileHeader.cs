//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct rresFileHeader
    {
        [NativeTypeName("unsigned char[4]")]
        public _id_e__FixedBuffer id;

        [NativeTypeName("unsigned short")]
        public ushort version;

        [NativeTypeName("unsigned short")]
        public ushort chunkCount;

        [NativeTypeName("unsigned int")]
        public uint cdOffset;

        [NativeTypeName("unsigned int")]
        public uint reserved;

        [InlineArray(4)]
        public partial struct _id_e__FixedBuffer
        {
            public byte e0;
        }
    }
}
