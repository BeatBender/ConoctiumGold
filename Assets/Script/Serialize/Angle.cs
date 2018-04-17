using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace serialize
{
    class Angle : EditorObject {

        public Vector3 rotation;
        public Vector3 scale;
        public Angle(Vector3 pos, Vector3 rot, Vector3 scale)
        {
            this.position = pos;
            this.rotation = rot;
            this.scale = scale;
        }
    }
}

