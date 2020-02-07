using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using EasyToDo.Commands;
using EasyToDo.ViewModels;

namespace EasyToDo
{
    public partial class Login
    {
        public Login()
        {
            InitializeComponent();
            DataContext = new LoginViewModel
            {
                LoginCommand = new GeneralCommand<PasswordBox>(LoginCommandExecute)
            };
        }

        private void LoginCommandExecute(PasswordBox passwordBox)
        {
            var model = (LoginViewModel)DataContext;
            var password = passwordBox.Password;
            if (model.Username == password)
            {
                Hide();
                var mainWindow = new MainWindow();
                mainWindow.Closed += (sender, args) => Show();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}