using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace NewWord
{
    /// <summary>
    /// Логика взаимодействия для Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        List<string> list = new List<string>();
        static int countTrueAnswer = 0;
        static int countFalseAnswer = 0;
        public Test()
        {
            InitializeComponent();
            TestExam();
        }
        private void TestExam()
        {
            try
            {
                list.Add(libDic.DictTest());

                lbTestQuet.Content = list.Count;

                
            }
            catch { }
        }
        private void CheckedAnswer()
        {
         
            string answer = tbAnswer.Text;
            bool answerBool = libDic.DictChecked(answer);
            if(answerBool == true) 
            { 
                countTrueAnswer++;
            }
            else
            {
                countFalseAnswer++;
            }
            lbAnswerTrue.Content = countTrueAnswer;
           
           
        }

        private void btContinue_Click(object sender, RoutedEventArgs e)
        {
            CheckedAnswer();
         
            
        }
    }
}
