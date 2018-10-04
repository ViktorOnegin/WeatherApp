using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace WeatherApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            var SearchButton = FindViewById<Button>(Resource.Id.button1);
            var City = FindViewById<EditText>(Resource.Id.citySearch);

            SearchButton.Click += Button_Click;

            
        }
        private async void Button_Click(object sender, System.EventArgs e)
        {
            var City = FindViewById<TextView>(Resource.Id.City);
            var weather1 = await Core.Core.GetWeather();
            City.Text = weather1.Title;

            var MainTemp = FindViewById<TextView>(Resource.Id.Temp);
            var weather2 = await Core.Core.GetWeather();
            MainTemp.Text = weather1.Temperature;

            var WindSpeed = FindViewById<TextView>(Resource.Id.WindSpeed);
            var weather3 = await Core.Core.GetWeather();
            WindSpeed.Text = weather3.WindSpeed;

            var MainPressure = FindViewById<TextView>(Resource.Id.MainPressure);
            var weather4 = await Core.Core.GetWeather();
            MainPressure.Text = weather3.WindSpeed;
        }
    }
}