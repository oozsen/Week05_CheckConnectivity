using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Week05_CheckConnectivity
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            networkState.Text = Connectivity.NetworkAccess.ToString();
        }
    }
}
