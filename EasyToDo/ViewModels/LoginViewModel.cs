using System.Windows.Input;

namespace EasyToDo.ViewModels
{
    public class LoginViewModel
    {
        public string Username { get; set; }

        public ICommand LoginCommand { get; set; }
    }
}