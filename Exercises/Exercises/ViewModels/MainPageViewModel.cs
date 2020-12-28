using Exercises.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Exercises.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string OrientationText { get; set; }
        public ICommand GetOrientationCommand { get; set; }
        public MainPageViewModel()
        {
            GetOrientationCommand = new Command(GetCurrentOrientation);
        }
        public void GetCurrentOrientation()
        {
            DeviceOrientation orientation = DependencyService.Get<IScreenOrientationService>().GetOrientation();
            switch (orientation)
            {
                case DeviceOrientation.Portrait:
                    OrientationText = "Portrait";
                    break;
                case DeviceOrientation.Landscape:
                    OrientationText = "Landscape";
                    break;
                case DeviceOrientation.PortraitUp:
                    OrientationText = "Portrait Up";
                    break;
                case DeviceOrientation.PortraitDown:
                    OrientationText = "Portrait Down";
                    break;
                case DeviceOrientation.LandscapeLeft:
                    OrientationText = "Landscape Left";
                    break;
                case DeviceOrientation.LandscapeRight:
                    OrientationText = "Landscape Right";
                    break;
                case DeviceOrientation.Other:
                    OrientationText = "Other";
                    break;
                default:
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
