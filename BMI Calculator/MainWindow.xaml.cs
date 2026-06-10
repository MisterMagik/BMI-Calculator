using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BMI_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private double _userHeight;
        private double _userWeight;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButtonClick(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(HeightTextBox.Text, out height) && double.TryParse(WeightTextBox.Text, out weight))
            {
                double bmi = weight / (height * height);
                ResultLabel.Content = $"BMI: {bmi}";
            }
            else
            {
                MessageBox.Show("Wpisz poprawne wartości dla wzrostu i wagi.", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ResetButtonClick(object sender, RoutedEventArgs e)
        {
            HeightTextBox.Clear();
            WeightTextBox.Clear();
            ResultLabel.Content = "BMI: -";
            _userHeight = 0;
            _userWeight = 0;
        }
    }
}