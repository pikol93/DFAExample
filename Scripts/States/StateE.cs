using Godot;

namespace DFAExample
{
    internal class StateE : StateBase
    {
        // StateE is final state so it contains no transitions
        public StateE(StateNode node) : base(node) { }

        public override void EnterState(object[] args)
        {
            base.EnterState(args);

            GD.Print("Entered final state.");
        }
    }
}