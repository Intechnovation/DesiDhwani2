using System;
using FlyOutMenu;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using DesiDhwani2.www.junctione.com;

namespace DesiDhwani2
{
	[Activity (Label = "DesiDhwani2", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		string mlogin = null;
		MagentoService mservice = new MagentoService();
		filters myfilter = new filters();
		public MagentoService MGM = new MagentoService ();
		public MainActivity()
		{
			mlogin = mservice.login("sarath", "qwerty");
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			var menu = FindViewById<FlyOutContainer> (Resource.Id.FlyOutContainer);
			var menuButton = FindViewById (Resource.Id.MenuButton);
			menuButton.Click += (sender, e) => {
				menu.AnimatedOpened = !menu.AnimatedOpened;			
			};
			
			//FlyOutContainer fly = new FlyOutContainer ();
			Button  BookClick = FindViewById<Button>(Resource.Id.AllBooks);
			BookClick.Click += (sender, e) => {
				var intent = new Intent (this, typeof(BooksActivity));
				StartActivity (intent);

			};

//			Button MobPhnClick = FindViewById<Button>(Resource.Id.Mobbtn);
//			MobPhnClick.Click += (sender, e) => {
//				var intent = new Intent(this,typeof(MobilePhones));
//				StartActivity(intent);
//			};
//
//			Button TabBtnClick = FindViewById<Button>(Resource.Id.Tabletbtn);
//			TabBtnClick.Click += (sender, e) => {
//				var intent = new Intent(this,typeof(TabletActivity));
//				StartActivity(intent);
//
//			};
//
//			Button OtherItmClick = FindViewById<Button>(Resource.Id.OtherItmBtn);
//			OtherItmClick.Click += (sender, e) => {
//				var intent = new Intent(this,typeof(OtherItemsActivity));
//				StartActivity(intent);
//			};
//
//			Button ApparelClick =  FindViewById<Button>(Resource.Id.ApparelsBtn);
//			ApparelClick.Click += (sender, e) => {
//				var intent = new Intent(this,typeof(Apparels));
//				StartActivity(intent);
//			};
//
//			Button LaptopsClick =  FindViewById<Button>(Resource.Id.Laptopbtn);
//			LaptopsClick.Click += (sender, e) => {
//				var intent = new Intent(this,typeof(LaptopActivity));
//				StartActivity(intent);
//			};
			//catalogCategoryTree   CCE = MGM.catalogCategoryTree (mlogin ,"2",null);
			//catalogCategoryEntity[] childs = CCE.children;

//			foreach (catalogCategoryEntity item in childs) {
				
//			}
		}
	}
}	


