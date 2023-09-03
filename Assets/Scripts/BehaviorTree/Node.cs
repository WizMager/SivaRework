using System.Collections.Generic;

namespace BehaviorTree
{
    public enum NodeState
    {
        Running,
        Success,
        Failure
    }
    
    public class Node
    {
        protected NodeState State;

        public Node Parent;
        protected List<Node> Children;

        private Dictionary<string, object> _dataContext = new();

        public Node()
        {
            Parent = null;
        }

        public Node(List<Node> children)
        {
            foreach (var child in children)
            {
                Attach(child);
            }
        }

        private void Attach(Node node)
        {
            node.Parent = this;
            Children.Add(node);
        }

        public virtual NodeState Evaluate() => NodeState.Failure;

        public void SetData(string key, object value)
        {
            _dataContext[key] = value;
        }

        public object GetData(string key)
        {
            if (_dataContext.TryGetValue(key, out var value))
            {
                return value;
            }

            var node = Parent;
            while (node != null)
            {
                value = node.GetData(key);
                if (value != null)
                {
                    return value;
                }
                
                node = node.Parent;
            }
            return null;
        }
        
        public bool ClearData(string key)
        {
            if (_dataContext.TryGetValue(key, out var value))
            {
                _dataContext.Remove(key);
                return true;
            }

            var node = Parent;
            while (node != null)
            {
                var cleared = node.ClearData(key);
                if (cleared)
                {
                    return true;
                }
                
                node = node.Parent;
            }
            return false;
        }
    }
}