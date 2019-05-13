using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using XamarinTestApp1;
using XamarinTestApp1.UWP;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomDesktopRenderer))]
namespace XamarinTestApp1.UWP
{
    public class CustomDesktopRenderer : ViewRenderer<CustomView, Xamarin.Forms.Platform.UWP.EntryCellTextBox>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);

            var textBox = new  Xamarin.Forms.Platform.UWP.EntryCellTextBox();

            SetNativeControl(textBox);
        }
    }
}