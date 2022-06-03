using Prism.Commands;
using Prism.Navigation;
using System;

namespace ConnectedCarPrismExample.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private string _userName;
        private string _password;

        private DelegateCommand _loginCommand;

        public string UserName
        {
            get => _userName;
            set => SetProperty(ref _userName, value);
        }

        public string Password
        {
            get => _password;
            set => SetProperty(ref _password, value);
        }

        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));


        private async void Login()
        {
            await App.Current.MainPage.DisplayAlert("Hola", "Te saludo desde el comando", "ok");
        }

        public LoginPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            _navigationService = navigationService;
        }
    }
}
