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

            //networkState.Text = Connectivity.NetworkAccess.ToString();

            //if (Connectivity.NetworkAccess == NetworkAccess.None)
            //{
            //    networkState.Text = "Internet bağlantınızı kontrol edin!";
            //}

            Connectivity.ConnectivityChanged += ConnectivityChangedHandler;
        }

        private void ConnectivityChangedHandler(object sender, ConnectivityChangedEventArgs e)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                networkState.Text = e.NetworkAccess.ToString();
            });
        }
    }
}
