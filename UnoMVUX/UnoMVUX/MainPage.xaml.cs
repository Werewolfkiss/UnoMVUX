namespace UnoMVUX
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.DataContext = new BindableWeatherModel(new WeatherService());
        }
    }
}