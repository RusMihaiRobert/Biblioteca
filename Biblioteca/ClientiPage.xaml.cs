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
    public partial class ClientiPage : ContentPage
    {
        public ClientiPage()
        {
            InitializeComponent();
        }
        async void OnClientiPageAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdaugareClienti((Clienti)this.BindingContext)
            {
                BindingContext = new Clienti()
            });


        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetListaClientiAsync();
        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ModificareClienti
                {
                    BindingContext = e.SelectedItem as Clienti
                });
            }
        }
    }
}