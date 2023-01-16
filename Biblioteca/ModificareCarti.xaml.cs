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
    public partial class ModificareCarti : ContentPage
    {
        public ModificareCarti()
        {
            InitializeComponent();
        }
        async void OnSaveButtonCartiClicked(object sender, EventArgs e)
        {

            var slist = (Carti)BindingContext;
            slist.Nume_carte = Nume_carte.Text;
            slist.Categorie = Categorie.Text;
            await App.Database.SaveCartiAsync(slist);
            _ = DisplayAlert("Mesaj", "Modificare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonCartiClicked(object sender, EventArgs e)
        {
            var slist = (Carti)BindingContext;
            await App.Database.DeleteCartiAsync(slist);
            _ = DisplayAlert("Mesaj", "Stergere realizata cu succes", "OK");
            await Navigation.PopAsync();
        }
    }
}