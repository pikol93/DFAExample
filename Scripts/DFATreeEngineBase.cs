using System;
using Pikol93.DFA;

namespace DFAExample
{
    public class DFATreeEngineBase<TSignal, TState> : DFATree<TSignal, TState>
        where TSignal : Enum
        where TState : Enum
    {
        /// <summary> Called from game engine, passes update to state.</summary>
        /// <param name="delta">Time passed since last frame.</param>
        public void Update(float delta)
        {
            DFAState<TSignal, TState> state = States[CurrentState];
            if (state is DFAStateEngineBase<TSignal, TState> engineState)
            {
                engineState.Update(delta);
            }
        }
    }
}