using System.Collections.Generic;
using Godot;
using Pikol93.DFA;

namespace DFAExample
{
    internal class StateA : StateBase
    {
        public StateA(StateNode node) : base(node)
        {
            Dictionary<InputSignals, DFATransition<ExampleStates>> transitions =
                new Dictionary<InputSignals, DFATransition<ExampleStates>>()
            {
                { InputSignals.Input1, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateB,
                    () => { return new object[] { "StateA" }; }
                )
                }
            };
            AddTransitions(transitions);
        }
    }
}