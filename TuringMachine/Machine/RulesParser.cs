using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TuringMachine.Machine
{
    public class RulesParser
    {
        /// <summary>
        /// Method Parses rules for the turing machine
        /// Rules are in this format:
        /// old_state old_symbol new_symbol move new_state
        /// old_state old_symbol new_symbol move new_state
        /// ....
        /// </summary>
        /// <param name="rulesBlock"></param>
        /// <returns></returns>
        /// 
        public static Dictionary<Tuple<string, char>, Tuple<string, char, Movement>> ParseRules(string rulesBlock)
        {
            string[] rules =
                rulesBlock.Split(new string[] {"\n"}, StringSplitOptions.RemoveEmptyEntries);

            return rules.Select(ParseRule).ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
        }

        private static KeyValuePair<Tuple<string, char>, Tuple<string, char, Movement>> ParseRule(string rule)
        {
//            Console.WriteLine("parsing: {0}", rule);
            string[] fives = rule.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            Tuple<string, char> old = new Tuple<string, char>(fives[0], Convert.ToChar(fives[1]));
            Tuple<string, char, Movement> newStuff =
                new Tuple<string, char, Movement>(fives[4], Convert.ToChar(fives[2]), GetMovement(fives[3]));
            return new KeyValuePair<Tuple<string, char>, Tuple<string, char, Movement>>(old, newStuff);
        }

        private static Movement GetMovement(string move)
        {
            if (move.ToLower() == "l")
            {
                return Movement.Left;
            }

            if (move.ToLower() == "r")
            {
                return Movement.Right;
            }

            return Movement.Stay;
        }
    }
}