using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MasterDetailLearning
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }

        void Page1_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page1());
            IsPresented = false;
        }

        void Page2_Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Page2());
            IsPresented = false;
        }

    }
}
