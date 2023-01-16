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
    public partial class ModificareAutori : ContentPage
    {
        public ModificareAutori()
        {
            InitializeComponent();
        }
        async void OnSaveButtonAutoriClicked(object sender, EventArgs e)
        {

            var slist = (Autori)BindingContext;
            slist.Nume_autor = Nume_autor.Text;
            slist.Prenume_autor = Prenume_autor.Text;
            await App.Database.SaveAutoriAsync(slist);
            _ = DisplayAlert("Mesaj", "Modificare realizata cu succes", "OK");
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonAutoriClicked(object sender, EventArgs e)
        {
            var slist = (Autori)BindingContext;
            await App.Database.DeleteAutoriAsync(slist);
            _ = DisplayAlert("Mesaj", "Stergere realizata cu succes", "OK");
            await Navigation.PopAsync();
        }
    }
}