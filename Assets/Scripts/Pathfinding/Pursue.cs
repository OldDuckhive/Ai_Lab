using System;
using UnityEngine;

namespace Pathfinding
{
    public class Pursue : Seek
    {
        [SerializeField] private float maxPredict = 5.0f;

        protected override void Update()
        {
            base.Update();
            DestTarget.position = BallPos;
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
