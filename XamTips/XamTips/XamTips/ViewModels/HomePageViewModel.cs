using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamTips.Views;

namespace XamTips.ViewModels
{
    public class HomePageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public string MessageName { get; set; }
        public ICommand SayHiCommand { get; set; }

        public ICommand GoNextCommand { get; set; }

        public HomePageViewModel()
        {
            var a = Name;

            SayHiCommand = new Command( () => {

                MessageName = Name;
            }
            );

            GoNextCommand = new Command( async() => {

                await App.Current.MainPage.Navigation.PushAsync(new SecundTipPage());
            }
            );


        }
    }
}
