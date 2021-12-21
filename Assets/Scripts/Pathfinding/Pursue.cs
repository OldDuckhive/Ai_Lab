using System;
using UnityEngine;

namespace Pathfinding
{
    public class Pursue : PathfindingBehaviour
    {
        [SerializeField] private float maxPredict = 5.0f;
        
        protected Transform goal;

        protected override void Update()
        {
            DestTarget.position = goal.position;
            var direction = DestTarget.position - transform.position;
            var distance = direction.magnitude;
            var speed = AgentRb.velocity.magnitude;
            
            float prediction;

            if (speed <= distance / maxPredict)
                prediction = maxPredict;
            else
                prediction = distance / speed;

            var velocity = BallRb.velocity;
            velocity.Normalize();
            DestTarget.position += velocity * prediction;
        }
    }
}
