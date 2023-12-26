using System.Windows;
using System.Windows.Controls;

namespace CreditCalculatorApp
{
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty CreditAmountProperty =
            DependencyProperty.Register("CreditAmount", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));

        public double CreditAmount
        {
            get { return (double)GetValue(CreditAmountProperty); }
            set { SetValue(CreditAmountProperty, value); }
        }

        public static readonly DependencyProperty MonthlyIncomeProperty =
            DependencyProperty.Register("MonthlyIncome", typeof(double), typeof(MainWindow), new PropertyMetadata(0.0));

        public double MonthlyIncome
        {
            get { return (double)GetValue(MonthlyIncomeProperty); }
            set { SetValue(MonthlyIncomeProperty, value); }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}