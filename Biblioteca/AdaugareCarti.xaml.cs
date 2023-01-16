using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Models;
using SQLite;

namespace Biblioteca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdaugareCarti : ContentPage
    {
        Carti sl;
        public AdaugareCarti(Carti slist)
        {
            InitializeComponent();
            sl = slist;
        }
            protected override async void OnAppearing()
            {
                base.OnAppearing();
                listView.ItemsSource = await App.Database.GetCartiAsync();
            }
        
        
        
        async void OnSaveButtonCartiClicked(object sender, EventArgs e)
        {
            
            var slist = (Carti)BindingContext;
            slist.Nume_carte = Nume_carte.Text;
            slist.Nume_autor = Nume_autor.Text;
            slist.Prenume_autor = Prenume_autor.Text;
            slist.Pagini = Pagini.Text;
            slist.Categorie = Categorie.Text;
            await App.Database.SaveCartiAsync(slist);
            _ = DisplayAlert("Super!", "Inserare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnCancelButtonCartiClicked(object sender, EventArgs e)
        {
           
            await Navigation.PopAsync();
        }
       
    }
}
