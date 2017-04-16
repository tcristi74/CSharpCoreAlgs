using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.PolishNotation {

    /*

    Valid operators are +, -, *, /. Each operand may be an integer or another expression. 

    Some examples:

      ["2", "1", "+", "3", "*"] -> ((2 + 1) * 3) -> 9
      ["4", "13", "5", "/", "+"] -> (4 + (13 / 5)) -> 6

     */

    public class PolishReverse {

        private readonly Stack<int> _tokenStack;

        public PolishReverse () {
            _tokenStack = new Stack<int> ();
        }

        public int EvalRPN (string[] tokens) {

            for (int i = 0; i < tokens.Length; i++) {

                //verif if the next char is an operator
                if (tokens[i] != "+" && tokens[i] != "-" && tokens[i] != "/" && tokens[i] != "*") {
                    _tokenStack.Push (int.Parse (tokens[i]));
                    continue;
                }
                //extract the last 2 numbeers from stack 
                if (_tokenStack.Count < 2) {
                    throw new Exception ("Invalid expression");
                }
                int v1 = Convert.ToInt32 (_tokenStack.Pop ());
                int v2 = Convert.ToInt32 (_tokenStack.Pop ());

                switch (tokens[i]) {
                    case "+":
                        _tokenStack.Push (v1 + v2);
                        break;
                    case "-":
                        _tokenStack.Push (v2 - v1);
                        break;
                    case "*":
                        _tokenStack.Push (v1 * v2);
                        break;
                    case "/":
                        _tokenStack.Push (v2 / v1);
                        break;
                }

            }

            if (_tokenStack.Count != 1) {
                throw new Exception ("Invalid expression");
            }

            return _tokenStack.Pop ();
        }
    }

    [TestClass]
    public class PolishReverseTest {

        [TestMethod]
        public void TestEvalRPN () {
            PolishReverse pr = new PolishReverse ();
            var ret = pr.EvalRPN (new [] { "6", "7", "9", "+", "2","-","*" });
            Assert.AreEqual (ret, 9, "values are not equal");
            Console.WriteLine ("----------Polish reverse done-------");
        }
    }
}