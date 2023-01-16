using Biblioteca.Models;
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
    public partial class ModificareClienti : ContentPage
    {
        public ModificareClienti()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClientiClicked(object sender, EventArgs e)
        {

            var slist = (Clienti)BindingContext;
            slist.Carte = Carte.Text;
            slist.Data_retur = Data_retur.Text;
            await App.Database.SaveClientiAsync(slist);
            _ = DisplayAlert("Mesaj", "Modificare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClientiClicked(object sender, EventArgs e)
        {
            var slist = (Clienti)BindingContext;
            await App.Database.DeleteClientiAsync(slist);
            _ = DisplayAlert("Mesaj", "Stergere realizata cu succes", "OK");
            await Navigation.PopAsync();
        }
    }
}