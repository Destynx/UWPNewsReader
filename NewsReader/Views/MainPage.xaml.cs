using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using NewsReader.Model;
using NewsReader.ViewModels;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NewsReader.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private MainViewModel VM => MainViewModel.SingleInstance;

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            
            base.OnNavigatedTo(e);
            SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility
                = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
            

            try
            {
                await VM.InitializeAsync();
            }
            catch (Exception exception)
            {
                var dialog = new MessageDialog("Er is iets fout gegaan: " + exception.Message);
                await dialog.ShowAsync();
            }
        }


        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            if (Frame.BackStackDepth > 0)
            {
                e.Handled = true;
                Frame.GoBack();
            }
            else
            {
                MessageBoxMethod("je kan niet verder terug");

            }
        }

        private static async void MessageBoxMethod(string message)
        {
            var messageTekst = new MessageDialog(message);
            await messageTekst.ShowAsync();
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var article = ListView.SelectedItem;
            Frame.Navigate(typeof(DetailsPage), article);
        }
    }
}
