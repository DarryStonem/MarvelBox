using MarvelBox.Marvel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MarvelBox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            btnBuscar.Click += BtnBuscar_Click;
        }

        private async void BtnBuscar_Click(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(txtCharacter.Text))
            {
                var message = await new MessageDialog("No has ingresado un personaje").ShowAsync();
                return;
            }

            GetInformation();
        }

        private async void GetInformation()
        {
            var api = new CharactersAPI();
            var results = await api.GetAllAsync(null, null, new APIFilter("nameStartsWith", txtCharacter.Text));

            if(results.Code != 200)
            {
                var message = await new MessageDialog("Hubo un problema al obtener los personajes").ShowAsync();
                return;
            }

            lstCharacters.ItemsSource = results.Data.Results;
        }
    }
}
