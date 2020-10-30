using System;
using Pikol93.DFA;

namespace DFAExample
{
    public class DFAStateEngineBase<TSignal, TState> : DFAState<TSignal, TState>
        where TSignal : Enum
        where TState : Enum
    {
        public virtual void Update(float delta) { }
        public virtual void UpdateRare() { }
    }
}