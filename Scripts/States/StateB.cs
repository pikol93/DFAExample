using System.Collections.Generic;
using Pikol93.DFA;

namespace DFAExample
{
    internal class StateB : StateBase
    {
        public StateB(StateNode node) : base(node)
        {
            Dictionary<InputSignals, DFATransition<ExampleStates>> transitions =
                new Dictionary<InputSignals, DFATransition<ExampleStates>>()
            {
                { InputSignals.Input1, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateC,
                    () => { return new object[] { "StateB" }; }
                )
                },
                { InputSignals.Input2, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateD,
                    () => { return new object[] { "StateB" }; }
                )
                },
                { InputSignals.Input3, new DFATransition<ExampleStates>
                (
                    ExampleStates.StateE,
                    () => { return new object[] { "StateB" }; }
                )
                }
            };
            AddTransitions(transitions);
        }
    }
}