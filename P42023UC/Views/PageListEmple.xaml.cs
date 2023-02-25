using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace P42023UC.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListEmple : ContentPage
    {
        public PageListEmple()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();  // Aplicacion 

            // Usuario

            List<Models.Empleado> empleados= new List<Models.Empleado>();
            empleados = await App.Database.GetListEmple();
            listemple.ItemsSource = empleados;
        }

        private void listemple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}