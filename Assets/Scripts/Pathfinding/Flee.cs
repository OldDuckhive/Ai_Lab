using UnityEngine;

namespace Pathfinding
{
    public class Flee : PathfindingBehaviour
    {
        protected Vector3 Linear;
        protected override void Update()
        {
            base.Update();
            Linear = transform.position - DestTarget.position;
            Linear.Normalize();
            Linear *= Agent.maxSpeed;
            DestTarget.position = Linear;
        }
    }
}
