using System.Windows;
using System.Windows.Controls;

namespace WpfProgress
{
    public class SemicircleProgressBar : ProgressBar
    {
        static SemicircleProgressBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(SemicircleProgressBar),
                new FrameworkPropertyMetadata(typeof(SemicircleProgressBar)));
        }

        public static DependencyProperty CuttingFactorProperty =
            DependencyProperty.Register(nameof(CuttingFactor), typeof(double), typeof(SemicircleProgressBar));

        public double CuttingFactor
        {
            get => (double)GetValue(CuttingFactorProperty);
            set => SetValue(CuttingFactorProperty, value);
        }
    }
}