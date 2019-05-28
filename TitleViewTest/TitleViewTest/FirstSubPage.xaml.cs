using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace TitleViewTest
{
    public partial class FirstSubPage : ContentPage {
        public FirstSubPage() {
            InitializeComponent();

            var titleView = new Image { Source = ImageSource.FromFile("caeno_logo") };
            NavigationPage.SetTitleView(this, titleView);
        }
    }
}
