using System;
using System.Collections.Generic;

namespace WordCounter.Models {
    public class WordCount {
        private string _searchWord;
        private string _sentence;

        public WordCount (string searchWord, string sentence) {
            _searchWord = searchWord;
            _sentence = sentence;
        }

        public int GetCount () {
            int count = 0;
            string word = _searchWord.ToLower ();
                word = word.Replace("-", "");
                word = word.Replace("_", "");
            string sentence = _sentence.ToLower ();
                sentence = sentence.Replace(".", "");
                sentence = sentence.Replace(",", "");
                sentence = sentence.Replace(";", "");
                sentence = sentence.Replace("'", "");
                sentence = sentence.Replace("!", "");
                sentence = sentence.Replace(":", "");
                sentence = sentence.Replace("?", "");
                sentence = sentence.Replace("[", "");
                sentence = sentence.Replace("]", "");
                sentence = sentence.Replace("{", "");
                sentence = sentence.Replace("}", "");
                sentence = sentence.Replace("(", "");
                sentence = sentence.Replace(")", "");
                sentence = sentence.Replace("-", "");
                sentence = sentence.Replace("_", "");
            string[] split = sentence.Split ();

            if (word.Length == 0 || split.Length == 0) {
                count = 0;
            } else {
                for (int i = 0; i < split.Length; i++) {
                    if (split[i] == word) {
                        count += 1;
                    }
                }
            }
            return count;
        }
    }
}