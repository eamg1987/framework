using Autonoma.Service;

namespace Autonoma;

public partial class climapage : ContentPage
{
	public climapage()
	{
		InitializeComponent();
	}
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        var result = await (AppService.GetClima(40.4170, -3.7022));
        LblCiudad.Text = result.locality.name;
        LblClima.Text = result.hour_hour.hour1.text;
        LblPais.Text = result.locality.country;
        LblTemperatura.Text = result.hour_hour.hour1.temperature + result.information.temperature;
        LblHumedad.Text = result.day1.humidity + result.information.humidity;
        LblViento.Text = result.day1.wind + result.information.wind;
        ImgHumedadIcon.Source = "humedadicon.png";
        ImgVientoIcon.Source = "vientoicon.png";
        ImgclimaIcon.Source = result.hour_hour.hour1.miIcon;
    }
}