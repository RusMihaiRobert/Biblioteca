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
    public partial class ModificareBibliotecari : ContentPage
    {
        public ModificareBibliotecari()
        {
            InitializeComponent();
        }

        async void OnSaveButtonBibliotecariClicked(object sender, EventArgs e)
        {

            var slist = (Bibliotecari)BindingContext;
            slist.Nume = Nume.Text;
            slist.Carte = Carte.Text;
            await App.Database.SaveBibliotecariAsync(slist);
            _ = DisplayAlert("Mesaj", "Modificare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonBibliotecariClicked(object sender, EventArgs e)
        {
            var slist = (Bibliotecari)BindingContext;
            await App.Database.DeleteBibliotecariAsync(slist);
            _ = DisplayAlert("Mesaj", "Stergere realizata cu succes", "OK");
            await Navigation.PopAsync();
        }
    }
}