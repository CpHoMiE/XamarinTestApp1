using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using XamarinTestApp1;
using XamarinTestApp1.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomIosRenderer))]
namespace XamarinTestApp1.iOS
{
    class CustomIosRenderer:ViewRenderer<CustomView, UIKit.UISlider>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var slider = new UIKit.UISlider();

            SetNativeControl(slider);
        }
    }
}