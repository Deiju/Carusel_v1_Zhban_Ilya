using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Carusel
{
    public partial class MainPage :ContentPage
    {
        public MainPage ()
        {
            InitializeComponent( );
        }
        public string Check_name (string a)
        {
            string b = "";
            foreach ( char i in a )
            {
                if ( !char.IsLetter(i) )
                {
                    b = "er";
                }
            }
            return b;
        }
        public string Check_pass (string a)
        {
            string b = "";
            foreach ( char i in a )
            {
                if ( !char.IsDigit(i) )
                {
                    b = "er";
                }
            }
            return b;
        }
        private void sign_Clicked (object sender, EventArgs e)
        {
            if ( name.Text != null && pass.Text != null )
            {
                if ( Check_name(name.Text) != "er" )
                {
                    if ( Check_pass(pass.Text) != "er" )
                    {
                        Navigation.PushAsync(new Page( ));
                    }
                    else
                    {
                        DisplayAlert("Ошибка", "Пароль должен состоят из цифр", "ОК");
                    }
                }
                else
                {
                    DisplayAlert("Ошибка", "Имя должно состоят из букв", "ОК");
                }
            }
            else
            {
                DisplayAlert("Ошибка", "Пустые поля", "ОК");
            }
        }
    }
}
