namespace DFAExample
{
    /// <summary>
    /// Contains behaviour that gets called when the state is active
    /// </summary>
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

        public override void Update(float delta)
        {
            node.OnUpdate(delta);
        }

        public override void EnterState(object[] args)
        {
            node.OnEntered(args);
        }

        public override void ExitState()
        {
            node.OnExited();
        }
    }
}