using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static QPharma.Constants;

namespace QPharma {

    public partial class MainPage : ContentPage {

        private TimeUnit timeUnit = TimeUnit.YEARS;
        private WeightUnit weightUnit = WeightUnit.LBS;

        public MainPage() {
            InitializeComponent();
            headerImage.Source = ImageSource.FromResource("QPharma.Assets.headerImage.png");
            ageEntry.Text = "18";
            weightEntry.Text = "110";
        }
        private async void ListAllDosesBtn_Clicked(object sender, EventArgs e) {
            await this.DisplayAlert("QPharma", "You clicked All Doses Based on Age/Weight!", "OK");
            // await Navigation.PushModalAsync(new KeypadPage(LookUpFlag.MEDS));
        }

        private async void SearchForDoseBtn_Clicked(object sender, EventArgs e) {
            await this.DisplayAlert("QPharma", "You clicked Look up a Medication!", "OK");
            // await Navigation.PushModalAsync(new KeypadPage(LookUpFlag.MEDS));
        }

        private void TimeUnitBtn_Clicked(object sender, EventArgs e) {
            timeUnitBtn.Text = (timeUnitBtn.Text == "years" ? "months" : "years");
            timeUnit = (timeUnit == TimeUnit.YEARS ? TimeUnit.MONTHS : TimeUnit.YEARS);
        }

        private void WeightUnitBtn_Clicked(object sender, EventArgs e) {
            weightUnitBtn.Text = (weightUnitBtn.Text == "pounds" ? "kilos" : "pounds");
            weightUnit = (weightUnit == WeightUnit.LBS ? WeightUnit.KGS : WeightUnit.LBS);
            // weightEntry.Text = (weightUnitBtn.Text == "lbs" ? (Double.Parse(weightEntry.Text) * 2.2046).ToString() : (Double.Parse(weightEntry.Text) / 2.2046).ToString());
        }
    }
}
