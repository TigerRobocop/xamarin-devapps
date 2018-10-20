using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Net;
using System.Runtime.Serialization.Json;
using System.IO;

namespace JsonWebRequest
{
    public partial class MainPage : ContentPage
    {
        WebRequest request;

        public MainPage()
        {
            InitializeComponent();
            Uri uri = new Uri("https://developer.xamarin.com/demo/stock.json");
            request = WebRequest.Create(uri);

            lblLoading.Text = "lblLoading...";

            request.BeginGetResponse(HandleAsyncCallback, null);


        }

        void HandleAsyncCallback(IAsyncResult ar)
        {
            Device.BeginInvokeOnMainThread(() =>
            {


                Stream stream = request.EndGetResponse(ar).GetResponseStream();
                DataContractJsonSerializer serializer =
                    new DataContractJsonSerializer(typeof(PhotoList));

                PhotoList list = (PhotoList)serializer.ReadObject(stream);
                listPhotos.ItemsSource = list.photos;

                lblLoading.Text = "";
            });


        }

    }
}
