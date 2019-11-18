using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static TuringMachine.Machine.RulesParser;

namespace TuringMachine.Machine
{
    public enum Movement
    {
        Left,
        Right,
        Stay
    }

    public class TuringMachine
    {
        public List<char> Tape = new List<char>();

        private int _head;

        public int Head
        {
            get => _head;
            set
            {
                _head = value;
                if (_head < 0)
                {
                    AddLeftCell();
                    _head = _head + 1;
                }

                if (_head >= Tape.Count)
                {
                    AddRightCell();
                }
            }
        }

        private Dictionary<Tuple<string, char>, Tuple<string, char, Movement>> _rules =
            new Dictionary<Tuple<string, char>, Tuple<string, char, Movement>>();

        public TuringMachine(int head, string startState, string endState, string input, string rules)
        {
            _head = head;
            _startState = startState;
            _endState = endState;
            CurrentState = _startState;
            _rules = ParseRules(rules);
            Tape = new List<char>(input);
        }

        private readonly string _startState;
        private readonly string _endState;
        public string CurrentState;

        public bool CanContinue
        {
            [MethodImpl(MethodImplOptions.Synchronized)]
            get { return CurrentState != _endState; }
        }

        public List<char> Run()
        {
            while (CanContinue)
            {
                ExecuteStep();
            }

            return Tape;
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void ExecuteStep()
        {
            if (!CanContinue)
                return;
            Tuple<string, char, Movement> rule;
            try
            {
                rule = _rules[new Tuple<string, char>(CurrentState, Tape[Head])];
            }
            catch (Exception e)
            {
                throw new MissingRuleException(new Tuple<string, char>(CurrentState, Tape[Head]));
            }

            Tape[Head] = rule.Item2;
            CurrentState = rule.Item1;
            if (rule.Item3 == Movement.Left)
                Head--;
            if (rule.Item3 == Movement.Right)
                Head++;
        }

        private void AddLeftCell()
        {
            Tape.Add('_');
            for (int i = Tape.Count - 1; i > 0; i--)
                Tape[i] = Tape[i - 1];
            Tape[0] = '_';
        }

        private void AddRightCell()
        {
            Tape.Add('_');
        }
    }
}