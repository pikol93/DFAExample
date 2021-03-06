using System.Collections.Generic;
using Pikol93.DFA;

namespace DFAExample
{
    internal class StateD : StateBase
    {
        public StateD(StateNode node) : base(node)
        {
            Dictionary<InputSignals, DFATransition<ExampleStates>> transitions =
                new Dictionary<InputSignals, DFATransition<ExampleStates>>()
            {
                { InputSignals.Input1, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateB,
                    () => { return new object[] { "StateD" }; }
                )
                },
                { InputSignals.Input2, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateC,
                    () => { return new object[] { "StateD" }; }
                )
                }
            };
            AddTransitions(transitions);
        }
    }
}