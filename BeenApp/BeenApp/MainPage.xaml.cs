﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BeenApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new newPlacePage());
        }
    }
}
