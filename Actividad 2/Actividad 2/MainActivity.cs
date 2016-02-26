using System;
using Xamarin.Forms;

namespace HolaMundo
{
    public class App
    {
        public static Page GetMainPage()
        {
            return new ContentPage
            {
                Content = new Label
                {
                    Text = "Nombre: Mauricio Nepomuceno De Florencio Número de cuenta: 413140698 ",
                    VerticalOptions = LayoutOptions.CenterAndExpand,
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                },
            };
        }
    }
}
