using System.Windows.Controls;
using System.Windows.Input;
using System.Windows;
using System.Windows.Media;

namespace ChatApp
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginWindow_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void RemoveText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == "Username")
            {
                textBox.Text = "";
                textBox.Foreground = Brushes.White;
            }
        }

        private void AddText(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = "Username";
                textBox.Foreground = Brushes.Gray;
            }
        }

        private void RemovePasswordText(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null && passwordBox.Password == "*******")
            {
                passwordBox.Password = "";
                passwordBox.Foreground = Brushes.White;
            }
        }

        private void AddPasswordText(object sender, RoutedEventArgs e)
        {
            PasswordBox passwordBox = sender as PasswordBox;
            if (passwordBox != null && string.IsNullOrWhiteSpace(passwordBox.Password))
            {
                passwordBox.Password = "*******";
                passwordBox.Foreground = Brushes.Gray;
            }
        }

        private void OpenChatClient(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Visibility = Visibility.Hidden;
            objMainWindow.Show();
        }


    }
}