using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using UnoSample.Shared.Command;
using Windows.UI.Popups;

namespace UnoSample.Shared.ViewModel
{
    public class Login : ViewModelBase
    {
        private string _loginText = string.Empty;
        private string _senha = string.Empty;

        public string LoginText 
        { get { return _loginText; } 
            set { 
                if (!_loginText.Equals(value)) _loginText = value; 
                OnPropertyChanged("LoginText"); } 
        }

        public string Senha
        {
            get { return _senha; }
            set
            {
                if (!_senha.Equals(value)) _senha = value;
                OnPropertyChanged("Senha");
            }
        }

        public ICommand VerifyLogingAndPassword
        {
            get { return new LoginCommand(LoginVerify); }
        }

        private async void LoginVerify()
        {

            if (this.LoginText.Equals("Admin") && this.Senha.Equals("1234"))
                ShowAlert("Dados informados com sucesso");
            else
                ShowAlert("Não foi posível realizar o login com os dados informados.\n Verifique e tente novamente");

            ResetDados();
        }

        private async void ShowAlert(string text)
        {
            MessageDialog dialog = new MessageDialog(text);
            await dialog.ShowAsync();
        }

        private void ResetDados()
        {
            this.LoginText = string.Empty;
            this.Senha = string.Empty;
        }
    }
}
