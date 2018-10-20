using System;
using Xamarin.Forms;
using Android.Media;

[assembly: Dependency(typeof(PlayNotification.Droid.Play))]
namespace PlayNotification.Droid
{
    public class Play: IPlay
    {
        MediaPlayer player;

        public void PlaySound()
        {
            player = MediaPlayer
                .Create(Android.App.Application.Context,
                                                    Resource.Raw.spring);

            player.Start();


        }
    }
}
