using System;

namespace BehaviorTree
{
    public class Sequence : Node
    {
        public override NodeState Evaluate()
        {
            var anyChildIsRunning = false;

            foreach (var child in Children)
            {
                switch (child.Evaluate())
                {
                    case NodeState.Running:
                        anyChildIsRunning = true;
                        continue;
                    case NodeState.Success:
                        continue;
                    case NodeState.Failure:
                        State = NodeState.Failure;
                        return State;
                    default:
                        State = NodeState.Success;
                        return State;
                }
            }

            State = anyChildIsRunning ? NodeState.Running : NodeState.Success;
            return State;
        }
    }
}