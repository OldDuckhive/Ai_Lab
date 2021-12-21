namespace Pathfinding
{
    public class PathFollower : Seek 
    { 
        public Path path; 
        public float pathOffset = 0.0f; 
        float currentParam = 0f;

        protected override void Awake() 
        { 
            base.Awake(); 
            
        }

        protected override void Update() 
        { 
            currentParam = path.GetParam(transform.position, currentParam); 
            float targetParam = currentParam + pathOffset; 
            DestTarget.transform.position = path.GetPosition(targetParam);
        } 
    }
}
