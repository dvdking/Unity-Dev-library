using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace DevLibrary.ArcadePhysics
{
    public class ArcadeBody:MonoBehaviour
    {
        public Vector2 Velocity;
        public Vector2 MaxVelocity;

        public float Gravity = 0.0f;
    }
}
