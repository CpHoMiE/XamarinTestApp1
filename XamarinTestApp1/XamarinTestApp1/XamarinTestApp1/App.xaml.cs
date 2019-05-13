using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XamarinTestApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();

            // Idiom은 디바이스 정보 리턴
            switch (Device.Idiom)
            {
                case TargetIdiom.Desktop:
                    MainPage = new Page_Desktop();
                    break;
                case TargetIdiom.Phone:
                    MainPage = new LayoutStudyPage();
                    break;
                default:
                    break;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
