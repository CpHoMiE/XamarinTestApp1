using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamarinTestApp1.Droid;

[assembly: Dependency(typeof(CallerAndroid))]
namespace XamarinTestApp1.Droid
{
    class CallerAndroid : IDialer
    {
        public bool OnDial(string phoneNum)
        {
            System.Diagnostics.Debug.WriteLine("Android에서 전화중\n전화번호 : " + phoneNum);
            return true;
        }
    }
}