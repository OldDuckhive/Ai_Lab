using System;
using UnityEngine;

namespace Pathfinding
{
    public class Ball : MonoBehaviour
    {
        public static Ball Instance;
        [HideInInspector] public Rigidbody ballRb;

        private void Awake()
        {
            if (Instance != null) Destroy(this);
            else Instance = this;
            ballRb = GetComponent<Rigidbody>();
        }

        private void FixedUpdate()
        {
            var destTargetPosition = transform.position;
            if (destTargetPosition.x > 149)
                destTargetPosition.x = 149;
            if (destTargetPosition.x < -149)
                destTargetPosition.x = -149;
            if (destTargetPosition.z > 74)
                destTargetPosition.z = 74;
            if (destTargetPosition.z < -74)
                destTargetPosition.z = -74;
        }
    }
}
