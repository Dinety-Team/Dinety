using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Util;
using Android.Views.Inserts;

namespace YourAppNamespace
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        
        private float? B1 = null; // Top-left radius
        private float? B2 = null; // Top-right radius
        private float? B3 = null; // Bottom-left radius
        private float? B4 = null; // Bottom-right radius

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            
            Window.DecorView.SetOnApplyWindowInsetsListener(new OnApplyWindowInsetsListener(this));
        }

        private class OnApplyWindowInsetsListener : Java.Lang.Object, View.IOnApplyWindowInsetsListener
        {
            private readonly MainActivity _activity;

            public OnApplyWindowInsetsListener(MainActivity activity)
            {
                _activity = activity;
            }

            public WindowInsets OnApplyWindowInsets(View view, WindowInsets insets)
            {
                var roundedCorners = insets.RoundedCorners;

                if (roundedCorners != null)
                {
                    
                    _activity.B1 = roundedCorners.GetRoundedCorner(RoundedCorner.PositionTopLeft)?.Radius;
                    _activity.B2 = roundedCorners.GetRoundedCorner(RoundedCorner.PositionTopRight)?.Radius;
                    _activity.B3 = roundedCorners.GetRoundedCorner(RoundedCorner.PositionBottomLeft)?.Radius;
                    _activity.B4 = roundedCorners.GetRoundedCorner(RoundedCorner.PositionBottomRight)?.Radius;

                    
                    Log.Debug("ScreenCurvature", $"B1 (Top-Left): {_activity.B1}");
                    Log.Debug("ScreenCurvature", $"B2 (Top-Right): {_activity.B2}");
                    Log.Debug("ScreenCurvature", $"B3 (Bottom-Left): {_activity.B3}");
                    Log.Debug("ScreenCurvature", $"B4 (Bottom-Right): {_activity.B4}");

_activity.UpdateUIWithCurvature(_activity.B1, _activity.B2, _activity.B3, _activity.B4);
                }

                return view.OnApplyWindowInsets(insets);
            }
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}