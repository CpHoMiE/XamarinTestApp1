using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using XamarinTestApp1.iOS;

[assembly:Dependency(typeof(CallerIOS))]
namespace XamarinTestApp1.iOS
{
    class CallerIOS : IDialer
    {
        public bool OnDial(string phoneNum)
        {
            System.Diagnostics.Debug.WriteLine("IPhone에서 전화중\n전화번호 : " + phoneNum);
            return true;
        }
    }
}