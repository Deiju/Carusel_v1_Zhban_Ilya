using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Carusel
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page :ContentPage
    {
        public Page ()
        {
            InitializeComponent( );
        }

        private void Button_Clicked (object sender, EventArgs e)
        {
            if(picker.SelectedIndex!=-1 && sliderone.Value!=0&& slidertwo.Value != 0 && sliderthree.Value != 0 && sliderfour.Value != 0 )
            {
                Navigation.PushAsync(new NewPage(picker.SelectedItem.ToString(), Convert.ToInt32(sliderone.Value), Convert.ToInt32(slidertwo.Value), Convert.ToInt32(sliderthree.Value), Convert.ToInt32(sliderfour.Value)));
            }
            else
            {
                DisplayAlert("Error","Не выбраны данные из picker или не указаны все slider'ы","OK");
            }
        }
    }
}