using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlgCSharp.Array {
    /*
    Two words are called isomorphic if the letters in one word can be remapped to get the second word. Remapping a letter means replacing all occurrences of it with another letter. The ordering of the letters remains unchanged. No two letters may map to the same letter, but a letter may map to itself.
    For example, the words "abca" and "zbxz" are isomorphic because we can map 'a' to 'z', 'b' to 'b' and 'c' to 'x'.

    Given a String[] words, return how many (unordered) pairs of words are isomorphic.
    */
    public class IsomorphicWords {

        private readonly string[] _arr;

        public IsomorphicWords (string[] arr) {
            _arr = arr;
        }

        public int CountIsomorphicWords () {
            var cnt = 0;
            for (int i = 0, j = 1; i < _arr.Length; i++) {
                var w1 = _arr[i];
                j = i + 1;
                for (; j < _arr.Length; j++) {
                    var w2 = _arr[j];
                    if (verifyIsomorphic (w1, w2)) {
                        cnt++;
                    }
                }
            }
            return cnt;
        }

        private bool verifyIsomorphic (string s1, string s2) {

            if (s1.Length != s2.Length) return false;
            var h1 = new System.Collections.Hashtable ();
            var h2 = new System.Collections.Hashtable ();

            for (int i = 0; i < s1.Length; i++) {

                if (h1.ContainsKey (s1[i])) {
                    if (h1[s1[i]].ToString () != s2[i].ToString ()) {
                        return false;
                    }
                } else {
                    h1.Add (s1[i], s2[i]);
                }
                if (h2.ContainsKey (s2[i])) {
                    if (h2[s2[i]].ToString () != s1[i].ToString ()) {
                        return false;
                    }
                } else {
                    h2.Add (s2[i], s1[i]);
                }

            }

            return true;
        }
    }

    //[TestClass]
    public class IsomorphicTest {

        [TestMethod]
        public void TestIsomorphic () {

            IsomorphicWords iso = new IsomorphicWords (new [] { "ave", "demo", "erty", "ert", "soso", "dodo", "cdcd" });
            var ret = iso.CountIsomorphicWords ();
            Assert.AreEqual (ret, 5, "values are not equal");
            Console.WriteLine ("----------Isomorphic done-------");
        }

    }

}