using UnityEngine;

namespace Pathfinding
{
    public class PursueBall : Pursue
    {
        protected override void Update()
        {
            goal = Ball.transform;
            base.Update();
        }
    }
}
