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
    public partial class EntryPage : ContentPage
    {
        public EntryPage()
        {
            InitializeComponent();
        }

        private void Carti_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CartiPage());
        }

        private void Autori_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AutoriPage());
        }

        private void Bibliotecari_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new BibliotecariPage());
        }

        private void Clienti_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClientiPage());
        }

        private void Despre_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DesprePage());
        }
    }
}