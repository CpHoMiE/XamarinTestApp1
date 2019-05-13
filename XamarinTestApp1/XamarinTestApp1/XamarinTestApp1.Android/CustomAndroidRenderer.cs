using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinTestApp1;
using XamarinTestApp1.Droid;

[assembly:ExportRenderer(typeof(CustomView), typeof(CustomAndroidRenderer))]
namespace XamarinTestApp1.Droid
{
    public class CustomAndroidRenderer : ViewRenderer<CustomView, Android.Widget.DatePicker>
    {
        public CustomAndroidRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var datePicker = new Android.Widget.DatePicker(Forms.Context);

            SetNativeControl(datePicker);
        }

    }
}