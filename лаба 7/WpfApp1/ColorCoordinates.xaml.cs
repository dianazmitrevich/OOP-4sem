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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для ColorCoordinates.xaml
    /// </summary>
    public partial class ColorCoordinates : UserControl
    {
        public ColorCoordinates()
        {
            InitializeComponent();
        }

        public static DependencyProperty ColorProperty;
        public static DependencyProperty RedProperty;
        public static DependencyProperty GreenProperty;
        public static DependencyProperty BlueProperty;
        public static readonly RoutedEvent ColorChangedEvent;

        static ColorCoordinates()
        {
            FrameworkPropertyMetadata metadata1 = new FrameworkPropertyMetadata
            {
                CoerceValueCallback = new CoerceValueCallback(CorrectValue),
                PropertyChangedCallback = new PropertyChangedCallback(OnColorRGBChanged)
            };

            FrameworkPropertyMetadata metadata2 = new FrameworkPropertyMetadata
            {
                CoerceValueCallback = new CoerceValueCallback(CorrectValue),
                PropertyChangedCallback = new PropertyChangedCallback(OnColorRGBChanged)
            };

            FrameworkPropertyMetadata metadata3 = new FrameworkPropertyMetadata
            {
                CoerceValueCallback = new CoerceValueCallback(CorrectValue),
                PropertyChangedCallback = new PropertyChangedCallback(OnColorRGBChanged)
            };

            ColorProperty = DependencyProperty.Register("Color", typeof(Color), typeof(ColorCoordinates), new FrameworkPropertyMetadata(Colors.Black, new PropertyChangedCallback(OnColorChanged)));
            RedProperty = DependencyProperty.Register("Red", typeof(byte), typeof(ColorCoordinates), metadata1, new ValidateValueCallback(ValidateValue));
            GreenProperty = DependencyProperty.Register("Green", typeof(byte), typeof(ColorCoordinates), metadata2, new ValidateValueCallback(ValidateValue));
            BlueProperty = DependencyProperty.Register("Blue", typeof(byte), typeof(ColorCoordinates), metadata3, new ValidateValueCallback(ValidateValue));

            ColorChangedEvent = EventManager.RegisterRoutedEvent("ColorChanged", RoutingStrategy.Tunnel, typeof(RoutedPropertyChangedEventHandler<Color>), typeof(ColorCoordinates));
        }

        public Color Color
        {
            get { return (Color)GetValue(ColorProperty); }
            set { SetValue(ColorProperty, value); }
        }
        public byte Red
        {
            get { return (byte)GetValue(RedProperty); }
            set { SetValue(RedProperty, value); }
        }
        public byte Green
        {
            get { return (byte)GetValue(GreenProperty); }
            set { SetValue(GreenProperty, value); }
        }
        public byte Blue
        {
            get { return (byte)GetValue(BlueProperty); }
            set { SetValue(BlueProperty, value); }
        }

        private static void OnColorRGBChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            ColorCoordinates colorCoordinates = (ColorCoordinates)sender;
            Color color = colorCoordinates.Color;
            if (e.Property == RedProperty)
                color.R = (byte)e.NewValue;
            else if (e.Property == GreenProperty)
                color.G = (byte)e.NewValue;
            else if (e.Property == BlueProperty)
                color.B = (byte)e.NewValue;
            colorCoordinates.Color = color;
        }
        private static void OnColorChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            Color newColor = (Color)e.NewValue;
            ColorCoordinates colorCoordinates = (ColorCoordinates)sender;
            colorCoordinates.Red = newColor.R;
            colorCoordinates.Green = newColor.G;
            colorCoordinates.Blue = newColor.B;
            colorCoordinates.RaiseEvent(new RoutedPropertyChangedEventArgs<Color>((Color)e.OldValue, newColor, ColorChangedEvent));
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            byte currentValue = (byte)baseValue;
            if (currentValue > 255)
                return 255;
            return currentValue;
        }
        private static bool ValidateValue(object value)
        {
            byte currentValue = (byte)value;
            if (currentValue >= 0)
                return true;
            return false;
        }
    }
}