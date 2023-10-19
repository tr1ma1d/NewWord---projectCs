using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewWord
{
    static internal class libDic
    {
   
        static public Dictionary<string, string> dictionary = new Dictionary<string, string>();
        
    
        static public void DictWord(string word, string valueWord)
        {
            dictionary.Add(word, valueWord);
        }
        static public string DictTest()
        {
           
            foreach(var dict in dictionary)
            { 
                return dict.Key.ToString();
            }
            return "";
        
        }
     
        static public bool DictChecked(string answer) 
        {
            string answerString = answer;
            return dictionary.ContainsKey(answerString);
         
        }
    }
}
