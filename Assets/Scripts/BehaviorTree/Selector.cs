namespace BehaviorTree
{
    public class Selector : Node
    {
        public override NodeState Evaluate()
        {
            foreach (var child in Children)
            {
                switch (child.Evaluate())
                {
                    case NodeState.Running:
                        State = NodeState.Running;
                        return State;
                    case NodeState.Success:
                        State = NodeState.Success;
                        return State;
                    case NodeState.Failure:
                        continue;
                    default:
                        continue;
                }
            }

            State = NodeState.Failure;
            return State;
        }
    }
}