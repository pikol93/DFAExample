using System.Collections.Generic;
using Godot;
using Pikol93.DFA;

namespace DFAExample
{
    public class Test : Node
    {
        private DFATreeEngineBase<InputSignals, ExampleStates> StateMachine { get; set; }

        public override void _Ready()
        {
            // Get references to nodes
            StateNode stateNodeA = GetNode<StateNode>("StateA");
            StateNode stateNodeB = GetNode<StateNode>("StateB");
            StateNode stateNodeC = GetNode<StateNode>("StateC");
            StateNode stateNodeD = GetNode<StateNode>("StateD");
            StateNode stateNodeE = GetNode<StateNode>("StateE");

            // Create the DFA and states for it
            StateMachine = new DFATreeEngineBase<InputSignals, ExampleStates>();

            Dictionary<ExampleStates, DFAState<InputSignals, ExampleStates>> states =
                new Dictionary<ExampleStates, DFAState<InputSignals, ExampleStates>>()
            {
                { ExampleStates.StateA, new StateA(stateNodeA) },
                { ExampleStates.StateB, new StateB(stateNodeB) },
                { ExampleStates.StateC, new StateC(stateNodeC) },
                { ExampleStates.StateD, new StateD(stateNodeD) },
                { ExampleStates.StateE, new StateE(stateNodeE) }
            };

            // Initialize states in the DFA
            StateMachine.CreateStates(states, ExampleStates.StateA);
        }

        public override void _Process(float delta)
        {
            // State Machine calls the active state's Update method
            StateMachine.Update(delta);
        }

        public override void _Input(InputEvent @event)
        {
            // This acts as a way to simulate getting signals
            if (Input.IsActionJustPressed("signal_1"))
            {
                StateMachine.InvokeSignal(InputSignals.Input1);
            }
            else if (Input.IsActionJustPressed("signal_2"))
            {
                StateMachine.InvokeSignal(InputSignals.Input2);
            }
            else if (Input.IsActionJustPressed("signal_3"))
            {
                StateMachine.InvokeSignal(InputSignals.Input3);
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (Engine.EditorHint)
                return;

            if (disposing)
            {
                StateMachine?.Dispose();
                StateMachine = null;
            }
        }
    }
}
