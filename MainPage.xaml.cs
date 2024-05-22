using MJAppMauiBurger.Models;
using Newtonsoft.Json;
namespace MJAppMauiBurger
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:7271/api/");
            var response = client.GetAsync("burger").Result;
            if (response.IsSuccessStatusCode)
            {
                var burgers = response.Content.ReadAsStringAsync().Result;
                var burgersList =
               JsonConvert.DeserializeObject<List<MJBurger>>(burgers);
                listView.ItemsSource = burgersList;
            }
        }

    }



}
