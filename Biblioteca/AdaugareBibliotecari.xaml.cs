using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Models;

namespace Biblioteca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdaugareBibliotecari : ContentPage
    {
        Bibliotecari s1;
        public AdaugareBibliotecari(Bibliotecari slist)
        {
            InitializeComponent();
            s1 = slist;
        }


        async void OnSaveButtonBibliotecariClicked(object sender, EventArgs e)
        {
            var slist = (Bibliotecari)BindingContext;
            
            slist.Nume = Nume.Text;
            slist.Prenume = Prenume.Text;
            slist.Numar_telefon = Numar_telefon.Text;
            slist.Carte = Carte.Text;
            await App.Database.SaveBibliotecariAsync(slist);
            _ = DisplayAlert("Super!", "Inserare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnCancelButtonBibliotecariClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}