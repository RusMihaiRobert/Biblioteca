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
    public partial class AdaugareAutori : ContentPage
    {
        Autori s1;
        public AdaugareAutori(Autori slist)
        {
            InitializeComponent();
            s1 = slist;
        }
       

        async void OnSaveButtonAutoriClicked(object sender, EventArgs e)
        {
            var slist = (Autori)BindingContext;
            slist.Nume_autor = Nume_autor.Text;
            slist.Prenume_autor = Prenume_autor.Text;
            slist.Carte = Carte.Text;
            await App.Database.SaveAutoriAsync(slist);
            _ = DisplayAlert("Super!", "Inserare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }
        async void OnCancelButtonAutoriClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}