using System;
using System.Collections.Generic;
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
        private List<char> _tape = new List<char>();

        private int _head;

        private int Head
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

                if (_head >= _tape.Count)
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
            _currentState = _startState;
            _rules = ParseRules(rules);
            _tape = new List<char>(input);
        }

        private readonly string _startState;
        private readonly string _endState;
        private string _currentState;
        private bool CanContinue => _currentState != _endState;

        public List<char> Run()
        {
            while (CanContinue)
            {
                ExecuteStep();
            }

            return _tape;
        }

        private void ExecuteStep()
        {
            if (!CanContinue)
                return;
            Tuple<string, char, Movement> rule;
            try
            {
                rule = _rules[new Tuple<string, char>(_currentState, _tape[Head])];
            }
            catch (Exception e)
            {
                throw e;
            }

            _tape[Head] = rule.Item2;
            _currentState = rule.Item1;
            if (rule.Item3 == Movement.Left)
                Head--;
            if (rule.Item3 == Movement.Right)
                Head++;
        }

        private void AddLeftCell()
        {
            _tape.Add('_');
            for (int i = _tape.Count - 1; i > 0; i--)
                _tape[i] = _tape[i - 1];
            _tape[0] = '_';
        }

        private void AddRightCell()
        {
            _tape.Add('_');
        }
    }
}