

namespace MauiAppPrimeiroEadTec2026
{
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
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);

                string msg = "";

                if (etanol <= (gasolina * 0.7))
                {
                    msg = "O etanol está compensando.";

                } else
                {
                    msg = "A gasolina está compensando.";
                }

               await DisplayAlert("Calculado", msg, "Ok");

            } catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "Fechar");            
            }

        }// fechametodo
    } // fecha class
} //fecha manespace
