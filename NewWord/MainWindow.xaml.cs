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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NewWord
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
           
       
        public MainWindow()
        {
            InitializeComponent();
        }

        // make a button, which can add dictionary
       
        private void AddNewWord()
        {
            string inputWord = tbInputWordName.Text;
            string inputValue = tbInputValue.Text;

            libDic.DictWord(inputWord, inputValue);
            
        }

        private void btAdd_Click(object sender, RoutedEventArgs e)
        {
            AddNewWord();
            tbInputValue.Text = null;
            tbInputWordName.Text = null;
        }

        private void bdTest_Click(object sender, RoutedEventArgs e)
        {
            Test testWindow = new Test();
            try
            {
                this.Hide();
                testWindow.Show();
            }
            catch {
                MessageBox.Show("404");
            }
        }

        private void tbInputWordValue(object sender, TextChangedEventArgs e)
        {

        }
    }
}
