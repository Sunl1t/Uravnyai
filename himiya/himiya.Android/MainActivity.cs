using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android.Graphics;
using static Android.Views.ViewGroup;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Content;
using Google.Android.Material.Tabs;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;



/*[assembly: ExportRenderer(typeof(TabbedPage), typeof(CustomNavigationPageRenderer))]*/
namespace himiya.Droid
{
    /*public class CustomNavigationPageRenderer : NavigationPageRenderer
    {
        private Android.Support.V7.Widget.Toolbar _toolbar;

        public CustomNavigationPageRenderer(Context context) : base(context)
        {
        }

        public override void OnViewAdded(Android.Views.View child)
        {
            base.OnViewAdded(child);

            if (child.GetType() == typeof(Android.Support.V7.Widget.Toolbar))
            {
                _toolbar = (Android.Support.V7.Widget.Toolbar)child;
                _toolbar.ChildViewAdded += Toolbar_ChildViewAdded;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (disposing)
            {
                _toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
            }
        }

        private void Toolbar_ChildViewAdded(object sender, ChildViewAddedEventArgs e)
        {
            var view = e.Child.GetType();

            System.Diagnostics.Debug.WriteLine(view);

            if (e.Child.GetType() == typeof(Android.Support.V7.Widget.AppCompatTextView))
            {
                var textView = (Android.Support.V7.Widget.AppCompatTextView)e.Child;

                // TODO: CHANGE VALUES HERE
                textView.TextSize = 10;
                textView.SetTypeface(null, TypefaceStyle.Bold);

                _toolbar.ChildViewAdded -= Toolbar_ChildViewAdded;
            }
        }
    }*/







    [Activity(Label = "Уравняй!", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

/*        class CustomTabbedPageRenderer : TabbedPageRenderer
        {
            private TabLayout tabLayout = null;
            public CustomTabbedPageRenderer(Context context) : base(context)
            {
            }
            protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.TabbedPage> e)
            {
                base.OnElementChanged(e);
                this.tabLayout = (TabLayout)this.GetChildAt(1);
                tabLayout.TabMode = TabLayout.ModeScrollable;
                tabLayout.TabGravity = TabLayout.GravityFill;
            }
        }*/








        
    }
}