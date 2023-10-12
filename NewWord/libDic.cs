using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWord
{
    static internal class libDic
    {
        static Dictionary<string, string> dictionary = new Dictionary<string, string>();
        
    
        static public void DictWord(string word, string valueWord)
        {
            dictionary.Add(word, valueWord);
        }

    }
}
