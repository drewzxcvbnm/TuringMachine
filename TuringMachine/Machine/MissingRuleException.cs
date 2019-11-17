using System;

namespace TuringMachine.Machine
{
    public class MissingRuleException : Exception
    {
        Tuple<string, char> state;

        public MissingRuleException(Tuple<string, char> state) : base(
            string.Format("Cannot find rule for state:{0} and symbol:{1}", state.Item1, state.Item2))
        {
            this.state = state;
        }
    }
}