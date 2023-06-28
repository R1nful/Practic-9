using System;
using System.Linq;
using System.Windows;
using System.Windows.Documents;

namespace Practic_9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SplitTextButton_Click(object sender, RoutedEventArgs e)
        {
            SplitListBox.ItemsSource = SplitText();
        }
        private void ReversTextButton_click(object sender, RoutedEventArgs e)
        {
            string[] reverseArr = SplitText().Reverse().ToArray();
            ReverseListBox.ItemsSource = reverseArr;

            ReverseTextLable.Content = String.Join(" ", reverseArr);
        }

        private string[] SplitText()
        {
            string text = MainText.Text;
            return text.Split(' ');
        }
    }
}
