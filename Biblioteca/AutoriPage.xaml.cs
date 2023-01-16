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
    public partial class AutoriPage : ContentPage
    {
        public AutoriPage()
        {
            InitializeComponent();
        }
        async void OnAutoriPageAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdaugareAutori((Autori)this.BindingContext)
            {
                BindingContext = new Autori()
            });


        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //var carte1 = (Carti)BindingContext;
            listView.ItemsSource = await App.Database.GetListaAutoriAsync();
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ModificareAutori
                {
                    BindingContext = e.SelectedItem as Autori
                });
            }
        }

    }
}