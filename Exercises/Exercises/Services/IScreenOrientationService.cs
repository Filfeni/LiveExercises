using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms.Internals;

namespace Exercises.Services
{
    public interface IScreenOrientationService
    {
        DeviceOrientation GetOrientation();
    }
}
