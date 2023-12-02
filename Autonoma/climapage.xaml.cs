using Android.Health.Connect.DataTypes.Units;
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
        List<ClimaList> climaLists = new List<ClimaList>()
        {
            new ClimaList {Imagen = "clima" + result.hour_hour.hour1.icon, Temperatura= result.hour_hour.hour1.temperature, Hora=result.hour_hour.hour1.hour_data },
            new ClimaList {Imagen = "clima" + result.hour_hour.hour2.icon, Temperatura= result.hour_hour.hour2.temperature, Hora=result.hour_hour.hour2.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour3.icon, Temperatura = result.hour_hour.hour3.temperature, Hora = result.hour_hour.hour3.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour4.icon, Temperatura= result.hour_hour.hour4.temperature, Hora= result.hour_hour.hour4.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour5.icon, Temperatura= result.hour_hour.hour5.temperature, Hora=result.hour_hour.hour5.hour_data },
            new ClimaList {Imagen = "clima" + result.hour_hour.hour6.icon, Temperatura= result.hour_hour.hour6.temperature, Hora=result.hour_hour.hour6.hour_data },
            new ClimaList {Imagen = "clima" + result.hour_hour.hour7.icon, Temperatura= result.hour_hour.hour7.temperature, Hora=result.hour_hour.hour7.hour_data },
            new ClimaList {Imagen = "clima" + result.hour_hour.hour8.icon, Temperatura= result.hour_hour.hour8.temperature, Hora=result.hour_hour.hour8.hour_data },
            new ClimaList {Imagen = "clima" + result.hour_hour.hour9.icon, Temperatura= result.hour_hour.hour9.temperature, Hora=result.hour_hour.hour9.hour_data },
            new ClimaList {Imagen = "clima" + result.hour_hour.hour10.icon, Temperatura= result.hour_hour.hour10.temperature, Hora=result.hour_hour.hour10.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour11.icon, Temperatura= result.hour_hour.hour11.temperature, Hora=result.hour_hour.hour11.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour12.icon, Temperatura= result.hour_hour.hour12.temperature, Hora=result.hour_hour.hour12.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour13.icon, Temperatura= result.hour_hour.hour13.temperature, Hora=result.hour_hour.hour13.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour14.icon, Temperatura= result.hour_hour.hour14.temperature, Hora=result.hour_hour.hour14.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour15.icon, Temperatura= result.hour_hour.hour15.temperature, Hora=result.hour_hour.hour15.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour16.icon, Temperatura= result.hour_hour.hour16.temperature, Hora=result.hour_hour.hour16.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour17.icon, Temperatura= result.hour_hour.hour17.temperature, Hora=result.hour_hour.hour17.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour18.icon, Temperatura= result.hour_hour.hour18.temperature, Hora=result.hour_hour.hour18.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour19.icon, Temperatura= result.hour_hour.hour19.temperature, Hora=result.hour_hour.hour19.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour20.icon, Temperatura= result.hour_hour.hour20.temperature, Hora=result.hour_hour.hour20.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour21.icon, Temperatura= result.hour_hour.hour21.temperature, Hora=result.hour_hour.hour21.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour22.icon, Temperatura= result.hour_hour.hour22.temperature, Hora=result.hour_hour.hour22.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour23.icon, Temperatura= result.hour_hour.hour23.temperature, Hora=result.hour_hour.hour23.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour24.icon, Temperatura= result.hour_hour.hour24.temperature, Hora=result.hour_hour.hour24.hour_data},
            new ClimaList {Imagen = "clima" + result.hour_hour.hour25.icon, Temperatura= result.hour_hour.hour25.temperature, Hora=result.hour_hour.hour25.hour_data},
        };

        CvTiempo.ItemsSource = climaLists;
        LblCiudad.Text = result.locality.name;
        LblClima.Text = result.hour_hour.hour1.text;
        LblPais.Text = result.locality.country;
        LblTemperatura.Text = result.hour_hour.hour1.temperature + result.information.temperature;
        LblHumedad.Text = result.day1.humidity + result.information.humidity;
        LblViento.Text = result.day1.wind + result.information.wind;
        ImgHumedadIcon.Source = "humedadicon.png";
        ImgVientoIcon.Source = "vientoicon.png";
        ImgclimaIcon.Source = "clima"+result.hour_hour.hour1.icon;
    }
    public class ClimaList
    {
        public string Imagen { get; set; }
        public int Temperatura { get; set; }
        public string Hora { get; set; }
    }

}