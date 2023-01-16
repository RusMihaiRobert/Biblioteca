using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Biblioteca.Models;
using System.ComponentModel;

namespace Biblioteca
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartiPage : ContentPage
    {
        public CartiPage()
        {
            InitializeComponent();
        }
        
        async void OnCartiPageAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AdaugareCarti((Carti)this.BindingContext)
            {
                BindingContext = new Carti()
            });
            
            
        }
         
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetListaCartiAsync();
        }


        /* async void ButtonRemove_Clicked(object sender, EventArgs e)
         {

                 var carte = (Carti)BindingContext;

                 await App.Database.DeleteCartiAsync(carte);
                 listView.ItemsSource = await App.Database.GetCartiAsync();

         }*/

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ModificareCarti
                {
                    BindingContext = e.SelectedItem as Carti
                });
            }
        }





    }
}