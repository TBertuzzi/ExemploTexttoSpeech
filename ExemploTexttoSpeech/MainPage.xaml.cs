using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ExemploTexttoSpeech
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

        async void btnFalar_Executar(System.Object sender, System.EventArgs e)
        {
            await TextToSpeech.SpeakAsync(entryTexto.Text);
        }

        async void btnFalar_ExecutarVolumes(System.Object sender, System.EventArgs e)
        {
            var settings = new SpeechOptions()
            {
                Volume = .75f,
                Pitch = 1.0f
            };

            await TextToSpeech.SpeakAsync(entryTexto.Text, settings);
        }


        async void btnFalar_ExecutarTextos(System.Object sender, System.EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Primeiro Texto");
            await TextToSpeech.SpeakAsync("Segundo Texto");
            await TextToSpeech.SpeakAsync("Terceiro Texto");
        }

        async void btnFalar_ExecutarLocalidades(System.Object sender, System.EventArgs e)
        {
            var localidades = await TextToSpeech.GetLocalesAsync();

            var localidade = localidades.FirstOrDefault();

            var settings = new SpeechOptions()
            {
                Locale = localidade
            };

            await TextToSpeech.SpeakAsync(entryTexto.Text, settings);
        }

      
    }
}
