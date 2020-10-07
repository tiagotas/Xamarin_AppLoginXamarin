using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppLoginXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if(await DisplayAlert("Tem Certeza?", "Vai sair mesmo?", "Sim", "Não"))
                {
                    App.Current.Properties.Remove("PersistenciaUsuarioLogado");

                    App.Current.MainPage = new Login();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Desculpe \n ", ex.Message, "OK");
            }
        }
    }
}
