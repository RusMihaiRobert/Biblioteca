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
    public partial class AdaugareClienti : ContentPage
    {
        Clienti sl;
        public AdaugareClienti(Clienti slist)
        {
            InitializeComponent();
            sl = slist;
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetClientiAsync();
        }



        async void OnSaveButtonClientiClicked(object sender, EventArgs e)
        {

            var slist = (Clienti)BindingContext;
            slist.Nume = Nume.Text;
            slist.Prenume = Prenume.Text;
            slist.Carte = Carte.Text;
            slist.Numar_telefon = Numar_telefon.Text;
            slist.Data_retur = Data_retur.Text;
            await App.Database.SaveClientiAsync(slist);
            _ = DisplayAlert("Super!", "Inserare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnCancelButtonClientiClicked(object sender, EventArgs e)
        {
              await Navigation.PopAsync();
        }
    }
}