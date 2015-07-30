
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DesiDhwani2.www.junctione.com;
namespace DesiDhwani2
{
	[Activity (Label = "BooksActivity")]			
	public class BooksActivity : Activity
	{
		ArrayAdapter<string> ListAdapter;
		string [] items;
		//ListView mainListView ;
		protected override void OnCreate (Bundle bundle)
		{	
			base.OnCreate (bundle);
   			SetContentView (Resource.Layout.Books);
			items = new string[] { "Vegetables","Fruits","Flower Buds","Legumes","Bulbs","Tubers" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
		}

		public void GetProductList()
		{
			MagentoService _magento = new MagentoService ();
			string session = _magento.login("sarath", "qwerty");
			catalogProductLinkEntity[] relatedProduct = _magento.catalogProductLinkList (session, "grouped", "Bags, Belts and Wallets", null);

		}
	
	}
}

