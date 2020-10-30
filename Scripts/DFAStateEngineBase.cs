using System;
using Pikol93.DFA;

namespace DFAExample
{
    public class DFAStateEngineBase<TSignal, TState> : DFAState<TSignal, TState>
        where TSignal : Enum
        where TState : Enum
    {
        /// <summary>
        /// Contains behaviour that can get called every frame.
        /// </summary>
        /// <param name="delta">Time since last frame.</param>
        public virtual void Update(float delta) { }
    }
}