using System.Collections.Generic;
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
                    // This is the target state the transition aims for
                    ExampleStates.StateB, 
                    // This is an optinal delegate returning object[]
                    () => { return new object[] { "StateA" }; }
                )
                }
            };
            AddTransitions(transitions);
        }
    }
}