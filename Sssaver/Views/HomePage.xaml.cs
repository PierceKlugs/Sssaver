using System;
using System.Collections.Generic;
using Sssaver.ViewModels;
using Xamarin.Forms;
using Sssaver.Models;

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

        private void SaveClicked(object sender, EventArgs e)
        {
            saveBtn.IsVisible = false;
            homeViewModel.SavingsPlan.CurrentSavingsAmount += homeViewModel.TodaysSavingsAmount;
            
        }
    }
}
