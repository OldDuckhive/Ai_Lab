using UnityEngine;

namespace Pathfinding
{
    public class Evade : Flee
    {
        [SerializeField] private float maxPrediction = 10.0f;
        private float _prediction;
        private Vector3 _targetVelocity;
        
        protected override void Update()
        {
            var direction = DestTarget.position - transform.position;
            var distance = direction.magnitude;
            var speed = AgentRb.velocity.magnitude;

            if (speed <= distance / maxPrediction)
                _prediction = maxPrediction;
            else
                _prediction = distance / speed;

            _targetVelocity = BallRb.velocity;
            _targetVelocity.Normalize();
            DestTarget.position += _targetVelocity * _prediction;
            
            base.Update();
        }
    }
}
