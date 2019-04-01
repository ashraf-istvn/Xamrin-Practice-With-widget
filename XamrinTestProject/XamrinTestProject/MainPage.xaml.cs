using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using System;
using System.IO;
using Xamarin.Forms;


namespace XamrinTestProject
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        public void OnButtonClicked(Object btnClick, EventArgs eventArg)
        {
            (btnClick as Button).Text = "Click me again";
            userNameLb.Text = "user name : "+ userNameEt.Text;
        }

        private void OnEntryTextChange(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

        }

        private void OnEntryCompleted(Object sender, EventArgs eventArgs)
        {

        }
    }
}
