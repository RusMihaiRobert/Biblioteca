using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Biblioteca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DesprePage : ContentPage
    {
        public DesprePage()
        {
            InitializeComponent();
        }

       public void Recomandare_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("https://www.academia.edu/29149881/Istoria_Romanilor_Constantin_Giurescu"));
        }
    }
}