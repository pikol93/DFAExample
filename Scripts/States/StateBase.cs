using Godot;

namespace DFAExample
{
    internal class StateBase : DFAStateEngineBase<InputSignals, ExampleStates>
    {
        private StateNode node;

        public StateBase(StateNode node)
        {
            this.node = node;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                node = null;
            }
        }

        public override void EnterState(object[] args)
        {
            GD.Print($"Entered state {this.GetType()}.");
            if (args != null)
            {
                GD.Print($"Args: [{string.Join(", ", args)}]");
            }
            node.OnEntered(args);
        }

        public override void ExitState()
        {
            node.OnExited();
        }
    }
}