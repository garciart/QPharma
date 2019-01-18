using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace QPharma {
    public partial class App : Application {
        public App() {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected async override void OnStart() {
            await MainPage.DisplayAlert("DISCLAIMER:", "FOR QUICK REFERENCE ONLY! ALWAYS VERIFY THE DOSE!\n\nYou are responsible for administering the right dose of the right drug to the right patient at the right time through the right route!", "OK");
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
