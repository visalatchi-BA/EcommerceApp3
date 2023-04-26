using System.Windows.Input;
using EcommerceApp3.Helper;
using EcommerceApp3.Views;
using Prism.Navigation;
using Prism.Services;
using Xamarin.Forms;

namespace EcommerceApp3.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

        private readonly IPageDialogService _pageDialogService;
        private string _userName;
        private string _password;
        public LoginPageViewModel(INavigationService navigationService, IPageDialogService pageDialogService)
        {
            LoginCommand = new Command(LoginCommandHandler);
            _navigationService = navigationService;

            _pageDialogService = pageDialogService;



        }
        public UserDB UserDB = new UserDB();

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
           {
                SetProperty(ref _userName, value);

            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                SetProperty(ref _password, value);
            }
        }
        public ICommand LoginCommand { get; set; }
        private async void LoginCommandHandler()
        {
            if (!UserDB.LoginValidate(UserName, Password))
            {
               await _pageDialogService.DisplayAlertAsync("Warning","Invalid Login Credentials","OK");
            }
            else
            {
                await _navigationService.NavigateAsync(nameof(ProductDetailsPage));
            }
        }
    }
}
