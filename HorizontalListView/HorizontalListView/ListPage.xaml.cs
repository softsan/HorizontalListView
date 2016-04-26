using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HorizontalListView
{
	public partial class ListPage : ContentPage
	{
		public ListPage ()
		{
			InitializeComponent ();
			this.BindingContext = new CategoryViewModel ();
		}
	}
}

