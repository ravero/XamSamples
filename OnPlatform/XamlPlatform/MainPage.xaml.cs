using System;
using System.Collections.Generic;
using Xamarin.Forms;
using static XamlPlatform.PlatformUtils;

namespace XamlPlatform
{
    public partial class MainPage : ContentPage
    {
        public MainPage() {
            InitializeComponent();
        }

        protected override void OnAppearing() {
            base.OnAppearing();

            //
            // Exemplos de aplicação dos métodos do Platform Utils
            sampleLabel.HorizontalTextAlignment = OnPlatform(TextAlignment.Center,
                (Device.iOS, TextAlignment.End),
                (Device.Android, TextAlignment.Start));            
        }

        public void Handle_Clicked(object sender, EventArgs e) {
            //
            // Exemplo de código sendo chamado de acordo com a plataforma.
            // Se a plataforma não estiver listada o método será ignorado.
            OnPlatform(
                ( Device.iOS, () => DisplayAlert("OnPlatform", "O botão foi clicado em um dispositivo iOS", "OK") ),
                ( Device.Android, () => DisplayAlert("OnPlatform", "O botão foi clicado em um dispositivo Android", "OK") )
            );
        }
    }
}
