using Godot;

namespace DFAExample
{
    internal class StateE : StateBase
    {
        public StateE(StateNode node) : base(node) { }

        // StateE is final state and contains no transitions
        public override void EnterState(object[] args)
        {
            base.EnterState(args);

            GD.Print("Entered final state.");
        }
    }
}