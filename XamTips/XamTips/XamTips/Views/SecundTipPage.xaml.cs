using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamTips.ViewModels;

namespace XamTips.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecundTipPage : ContentPage
    {
        public SecundTipPage()
        {
            InitializeComponent();
            this.BindingContext = new SecundTipPageViewModel();
        }
    }
}