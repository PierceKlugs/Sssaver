using System;
using System.Collections.Generic;
using Sssaver.ViewModels;
using Xamarin.Forms;


namespace Sssaver.Views
{
    public partial class HomePage : ContentPage
    {
        private HomeViewModel homeViewModel;

        public HomePage()
        {
            InitializeComponent();
            

            BindingContext = homeViewModel = new HomeViewModel();


        }

        void ChallengeClicked(object sender, EventArgs e)
        {
            
            challengeBtn.Text = homeViewModel.TodaysSavingsAmount.ToString();
            saveBtn.IsVisible = true;


        }

        void SaveClicked(object sender, EventArgs e)
        {
            //Disable the Save Button After Click
            saveBtn.IsVisible = false;

            //Update the CurrentSavingsAmount in the ViewModel
            homeViewModel.SavingsPlan.CurrentSavingsAmount += homeViewModel.TodaysSavingsAmount;

            //Update the Challenge Button Look
            challengeBtn.Text = "You're doing Great!";
            challengeBtn.TextColor = Color.White;
            challengeBtn.IsEnabled = false;
            challengeBtn.BackgroundColor = Color.FromHex("#AEF2C6");
            challengeBtn.HeightRequest = 250;

            //Update the Days Left
            homeViewModel.SavingsPlan.Days -= 1;

            //Add the challenge to the SavingsHistory
            homeViewModel.SavingsHistory.Add(homeViewModel.SavingsPlan.SavingsChallenges[homeViewModel.SavingsPlan.SavingsChallenges.Count - 1]);

            int count = 1;
            foreach (var challenge in homeViewModel.SavingsHistory) {

                historyTable.RowDefinitions.Add(new RowDefinition { Height = 50 });

                //Form the Labels
                Label labelDate = new Label();
                Label labelAmount = new Label();

                //Text to Labels
                labelDate.Text = challenge.ActualDate.ToString();
                labelAmount.Text = "$" + challenge.Amount.ToString();

                labelDate.TextColor = Color.FromHex("#212121");
                labelAmount.TextColor = Color.FromHex("#212121");

                labelDate.FontFamily = "OsLight";
                labelAmount.FontFamily = "OsLight";

                labelDate.FontSize = 30;
                labelAmount.FontSize = 30;

                labelDate.HorizontalOptions = LayoutOptions.CenterAndExpand;
                labelAmount.HorizontalOptions = LayoutOptions.CenterAndExpand;

                //Grid Columns Set
                Grid.SetColumn(labelDate, 0);
                Grid.SetColumn(labelAmount, 1);

                

                count++;

                

                Grid.SetRow(labelDate, count);
                Grid.SetRow(labelAmount, count);

                historyTable.Children.Add(labelDate);
                historyTable.Children.Add(labelAmount);
            }
            


        }
    }
}
