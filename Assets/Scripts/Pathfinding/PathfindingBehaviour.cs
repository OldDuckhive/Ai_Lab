using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Pathfinding
{
    public class PathfindingBehaviour : MonoBehaviour
    {
        public Transform goal;
        
        protected AIDestinationSetter TargetSetter;
        protected Ball Ball;
        protected Transform DestTarget;
        protected Rigidbody AgentRb;
        protected Rigidbody BallRb;
        protected AIPath Agent;
        protected Vector3 BallPos;

        protected virtual void Awake()
        { 
            Ball = FindObjectOfType<Ball>();
            AgentRb = GetComponent<Rigidbody>();
            TargetSetter = GetComponent<AIDestinationSetter>();
            DestTarget = GetComponentInChildren<DestinationTarget>().transform;
            Agent = GetComponent<AIPath>();
        }

        private void Start()
        {
            BallRb = Ball.GetComponent<Rigidbody>();
        }

        protected virtual void Update()
        {
            BallPos = Ball.transform.position;
        }

        protected virtual void LateUpdate()
        {
            TargetSetter.target = DestTarget;
        }

        private void OnDrawGizmos()
        {
            if (DestTarget == null) return;
            Gizmos.color = Color.magenta;
            Gizmos.DrawSphere(DestTarget.transform.position, 1);
        }

        protected Vector3 TargetFilter(Transform destTarget)
        {
            var destTargetPosition = destTarget.position;
            if (destTargetPosition.x > 145)
                destTargetPosition.x = 145;
            if (destTargetPosition.x < -145)
                destTargetPosition.x = -145;
            if (destTargetPosition.z > 70)
                destTargetPosition.z = 70;
            if (destTargetPosition.z < -70)
                destTargetPosition.z = -70;
            return destTarget.position;
        }
    }
}
