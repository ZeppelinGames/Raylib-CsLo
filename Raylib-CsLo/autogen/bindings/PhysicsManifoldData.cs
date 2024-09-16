//# raylib 4.0 bindings.   MPL 2.0 Licensed.  Source here: https://github.com/NotNotTech/Raylib-CsLo
//# Find Raylib+docs here:   https://github.com/raysan5/raylib/blob/master/src/raylib.h
//# This file, and it's containing folder are automatically generated.  Do not Modify.
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Raylib_CsLo
{
    public unsafe partial struct PhysicsManifoldData
    {
        [NativeTypeName("unsigned int")]
        public uint id;

        [NativeTypeName("PhysicsBody")]
        public PhysicsBodyData* bodyA;

        [NativeTypeName("PhysicsBody")]
        public PhysicsBodyData* bodyB;

        public float penetration;

        public Vector2 normal;

        [NativeTypeName("Vector2[2]")]
        public _contacts_e__FixedBuffer contacts;

        [NativeTypeName("unsigned int")]
        public uint contactsCount;

        public float restitution;

        public float dynamicFriction;

        public float staticFriction;

        [InlineArray(2)]
        public partial struct _contacts_e__FixedBuffer
        {
            public Vector2 e0;
        }
    }
}
