using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Reflection;

namespace himiya
{
    public partial class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
  
            Image embeddedImage = new Image
            {
                Source = ImageSource.FromResource("himiya.pic11.jpg", typeof(MainPage).GetTypeInfo().Assembly)
            };
            /*NavigationPage navPage1 = new NavigationPage(new Basilisk());
            navPage1.IconImageSource = "Razdel_1_bely.png";
            navPage1.Title = "Новости";
            
            NavigationPage navPage3 = new NavigationPage(new Cobra());
            navPage3.IconImageSource = "Razdel_1_bely.png";
            navPage3.Title = "Раздел 2";
            NavigationPage navPage4 = new NavigationPage(new DeathAdder());
            navPage4.IconImageSource = "Razdel_1_bely.png";
            navPage4.Title = "Раздел 3";
            NavigationPage navPage5 = new NavigationPage(new Naga());
            navPage5.IconImageSource = "Razdel_1_bely.png";
            navPage5.Title = "Профиль";


            
            Children.Add(navPage2);
            Children.Add(navPage3);
            Children.Add(navPage4);
            Children.Add(navPage5);  полная залупа а не метод из-за которого я чуть не начал переписывать прилоежние*/
        }

    }
    [ContentProperty(nameof(Source))]
    public class ImageResourceExtension : IMarkupExtension
    {
        public string Source { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }

}

