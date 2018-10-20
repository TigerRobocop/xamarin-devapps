using System;
using AVFoundation;
using Foundation;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlayNotification.iOS.Play))]
namespace PlayNotification.iOS
{
    public class Play : IPlay
    {
        AVAudioPlayer player;

        public void PlaySound()
        {
            NSUrl url = new NSUrl("sounds/spring.mp3");
            NSError error;

            player = new AVAudioPlayer(url, "mp3", out error);
            player.NumberOfLoops = 3;
            player.Play();

        }
    }
}
