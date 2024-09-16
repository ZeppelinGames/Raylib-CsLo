//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public partial struct PhysicsVertexData
    {
        [NativeTypeName("unsigned int")]
        public uint vertexCount;

        [NativeTypeName("Vector2[24]")]
        public _positions_e__FixedBuffer positions;

        [NativeTypeName("Vector2[24]")]
        public _normals_e__FixedBuffer normals;

        [InlineArray(24)]
        public partial struct _positions_e__FixedBuffer
        {
            public Vector2 e0;
        }

        [InlineArray(24)]
        public partial struct _normals_e__FixedBuffer
        {
            public Vector2 e0;
        }
    }
}
