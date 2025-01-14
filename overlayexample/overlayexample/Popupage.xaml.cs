﻿using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace overlayexample
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Popupage : PopupPage
    {
		public Popupage ()
		{
			InitializeComponent ();

            MessagingCenter.Subscribe<MainPage>(this, "Hi", (sender) => {
                clospage();
            });

            animatepage1();
            animatepage2();
            animatepage3();
        }
        async void animatepage1()
        {
            await Image1.RelRotateTo(360, 5000);
        }
        async void animatepage2()
        {
            await Image2.RelRotateTo(360, 5000);
        }
        async void animatepage3()
        {
            await Image3.RelRotateTo(360, 5000);
        }
        async void clospage()
        {
            await PopupNavigation.Instance.PopAsync();
        }
        protected override Task OnAppearingAnimationEndAsync()
        {
            return Content.FadeTo(0.5);
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return Content.FadeTo(1);
        }
    }
}