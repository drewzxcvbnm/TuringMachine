﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using NUnit.Framework;

namespace TuringMachineTests
{
    [TestFixture]
    public class Tests
    {
        private string input = @"goto-operator done 111#11111
goto-operator  1  1  R  goto-operator
goto-operator  x  x  R  goto-operator
goto-operator  #  #  R  check-zero-power
check-zero-power  _  =  R  zero-power
check-zero-power  1  1  R  add-equals
add-equals  1  1  R  add-equals
add-equals  _  =  L  goto-left-corner
goto-left-corner  1  1  L  goto-left-corner
goto-left-corner  x  x  L  goto-left-corner
goto-left-corner  =  =  L  goto-left-corner
goto-left-corner  #  #  L  goto-left-corner
goto-left-corner  _  _  R  carry-first-num
zero-power  =  =  R  zero-power
zero-power  _  1  R  done
carry-first-num  x  x  R  carry-first-num
carry-first-num  1  x  R  add-one-as-root
carry-first-num  #  #  R  set-x-and-left
add-one-as-root  1  1  R  add-one-as-root
add-one-as-root  x  x  R  add-one-as-root
add-one-as-root  #  #  R  add-one-as-root
add-one-as-root  =  =  R  add-one-as-root
add-one-as-root  _  x  L  goto-left-corner
set-x-and-left  x  x  R  set-x-and-left
set-x-and-left  1  x  L  add-power
add-power  x  x  R  add-power
add-power  #  #  R  add-power
add-power  1  x  L  to-operator
add-power  =  =  R  root-to-number
to-operator  x  x  L  to-operator
to-operator  1  1  L  to-operator
to-operator  #  #  L  left-motion-x-to-ones
left-motion-x-to-ones  1  1  L  left-motion-x-to-ones
left-motion-x-to-ones  #  #  L  left-motion-x-to-ones
left-motion-x-to-ones  =  =  L  left-motion-x-to-ones
left-motion-x-to-ones  x  1  L  left-motion-x-to-ones
left-motion-x-to-ones  _  _  R  ignore-first-digit
ignore-first-digit  1  x  R  continue-multiplication
ignore-first-digit  #  #  R  zero-number
zero-number  x  x  R  zero-number
zero-number  =  =  R  zero-number
zero-number  1  x  R  zero-number
zero-number  _  _  R  done
continue-multiplication  #  #  R  increase-root
continue-multiplication  x  x  R  continue-multiplication
continue-multiplication  1  x  R  go-to-root
go-to-root  1  1  R  go-to-root
go-to-root  x  x  R  go-to-root
go-to-root  #  #  R  go-to-root
go-to-root  =  =  R  duplicate-root
duplicate-root  0  0  R  duplicate-root
duplicate-root  x  0  R  add-one-to-be-root
duplicate-root  2  2  R  back-to-first-operand-fixing-root
add-one-to-be-root  1  1  R  add-one-to-be-root
add-one-to-be-root  x  x  R  add-one-to-be-root
add-one-to-be-root  #  #  R  add-one-to-be-root
add-one-to-be-root  =  =  R  add-one-to-be-root
add-one-to-be-root  0  0  R  add-one-to-be-root
add-one-to-be-root  2  2  R  add-one-to-be-root
add-one-to-be-root  _  2  L  to-root-beginning
to-root-beginning  1  1  L  to-root-beginning
to-root-beginning  x  x  L  to-root-beginning
to-root-beginning  #  #  L  to-root-beginning
to-root-beginning  0  0  L  to-root-beginning
to-root-beginning  2  2  L  to-root-beginning
to-root-beginning  =  =  R  duplicate-root
back-to-first-operand-fixing-root  1  1  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  x  x  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  #  #  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  =  =  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  2  2  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  0  x  L  back-to-first-operand-fixing-root
back-to-first-operand-fixing-root  _  _  R  continue-multiplication
increase-root  1  1  R  increase-root
increase-root  x  x  R  increase-root
increase-root  #  #  R  increase-root
increase-root  =  =  R  increase-root
increase-root  0  0  R  increase-root
increase-root  2  x  R  increase-root
increase-root  _  _  L  to-middle
to-middle  1  1  L  to-middle
to-middle  x  x  L  to-middle
to-middle  =  =  L  to-middle
to-middle  0  0  L  to-middle
to-middle  #  #  R  add-power
root-to-number  x  1  R  root-to-number
root-to-number  _  _  R  done";

        [Test]
        public void ThreePowerOfFive()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "111#11111", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "_xxx#xxxxx=111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111__",
                string.Join("", chars));
        }

        [Test]
        public void TwoPowerOfFive()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "11#11111", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "_xx#xxxxx=11111111111111111111111111111111__",
                string.Join("", chars));
        }

        [Test]
        public void ZeroPowerOfFive()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "#11111", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "_#xxxxx=__",
                string.Join("", chars));
        }

        [Test]
        public void TwoPowerOfZero()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "11#", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "11#=1_",
                string.Join("", chars));
        }

        [Test]
        public void ZeroPowerOfZero()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "#", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "#=1_",
                string.Join("", chars));
        }
        
        [Test]
        public void TwoPowerOfTwo()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "11#11", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "_xx#xx=1111__",
                string.Join("", chars));
        }
        
        [Test]
        public void FivePowerOfZero()
        {
            TextReader reader = new StringReader(input);
            string s = reader.ReadLine();
            string[] inp = s.Split(' ');
            var machine =
                new TuringMachine.Machine.TuringMachine(0, inp[0], inp[1], "11111#", reader.ReadToEnd());
            List<char> chars = machine.Run();
            Assert.AreEqual(
                "11111#=1_",
                string.Join("", chars));
        }
        
    }
}