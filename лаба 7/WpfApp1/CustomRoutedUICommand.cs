using System.Windows.Input;

namespace WpfApp1
{
    public class CustomRoutedUICommand
    {
        private static RoutedUICommand requery;

        static CustomRoutedUICommand()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.R, ModifierKeys.Control, "Ctrl + R"));
            requery = new RoutedUICommand("Requery", "Requery", typeof(CustomRoutedUICommand), inputs);
        }

        public static RoutedUICommand Requery => requery;
    }
}
