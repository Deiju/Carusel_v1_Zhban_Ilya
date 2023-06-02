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
    public partial class NewPage :ContentPage
    {
        public NewPage (string picker,int slider1,int slider2,int slider3,int slider4)
        {
            InitializeComponent( );
            labelone.Text = $"Picker:{picker}";
            labeltwo.Text = $"1 slider:{slider1}";
            labelthree.Text = $"2 slider:{slider2}";
            labelfour.Text = $"3 slider:{slider3}";
            labelfive.Text = $"4 slider:{slider4}";
        }
    }
}