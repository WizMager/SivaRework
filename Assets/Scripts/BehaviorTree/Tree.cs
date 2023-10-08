namespace BehaviorTree
{
    public abstract class Tree
    {
        private Node _root;
        
        protected abstract Node SetupTree();
        
        public void OnStart()
        {
            _root = SetupTree();
        }

        public void OnUpdate()
        {
            _root?.Evaluate();
        }
    }
}