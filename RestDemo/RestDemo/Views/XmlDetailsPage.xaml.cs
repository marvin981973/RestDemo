﻿using RestDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RestDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XmlDetailsPage : ContentPage
	{
        public XmlDetailsPage (XmlPizzaDetails item)
		{
			InitializeComponent ();
            GridDetails.BindingContext = item;
		}
	}
}