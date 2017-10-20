using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamlTest
{
    public class AboutViewModel : BaseViewModel
    {
        public string AppName { get; set; } = "Hello!!";
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
