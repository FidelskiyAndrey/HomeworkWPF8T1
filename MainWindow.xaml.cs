using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
{
  
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        bool isBold;
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            if (!isBold)
                textBox.FontWeight = FontWeights.Bold;
            else
                textBox.FontWeight = FontWeights.Normal;
            isBold = !isBold;
        }

        bool isDecor;
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (!isDecor)
                textBox.TextDecorations = TextDecorations.Underline;
            else
                textBox.TextDecorations = null;
            isDecor = !isDecor;
        }

        bool isItalic;
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (!isItalic)
                textBox.FontStyle = FontStyles.Italic;
            else
                textBox.FontStyle = FontStyles.Normal;
            isItalic = !isItalic;
        }




        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Black;
        }
        private void RadioButton_Click1(object sender, RoutedEventArgs e)
        {
            textBox.Foreground = Brushes.Red;
        }






        private void OpenExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                textBox.Text = File.ReadAllText(openFileDialog.FileName);
            }
        }

        private void SaveExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(saveFileDialog.FileName, textBox.Text);
            }
        }

        private void CloseExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }





       
    }
}