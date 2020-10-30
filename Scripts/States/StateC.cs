using System.Collections.Generic;
using Pikol93.DFA;

namespace DFAExample
{
    internal class StateC : StateBase
    {
        public StateC(StateNode node) : base(node)
        {
            Dictionary<InputSignals, DFATransition<ExampleStates>> transitions =
                new Dictionary<InputSignals, DFATransition<ExampleStates>>()
            {
                { InputSignals.Input1, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateD,
                    () => { return new object[] { "StateC" }; }
                )
                },
                { InputSignals.Input2, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateB,
                    () => { return new object[] { "StateC" }; }
                )
                }
            };
            AddTransitions(transitions);
        }
    }
}