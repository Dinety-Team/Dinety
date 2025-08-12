using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AndroidX.AppCompat.App;
using Android.Util;
using Android.Views;
using Android.Content.Res;
using Android.OS;

namespace Dinety
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        // 存储四个圆角的半径
        private float B1; // Top-left
        private float B2; // Top-right
        private float B3; // Bottom-left
        private float B4; // Bottom-right

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            // 初始化默认值
            B1 = B2 = B3 = B4 = 0f;
            
            // 设置窗口插入监听器
            Window.DecorView.SetOnApplyWindowInsetsListener(new CurvatureListener(this));
        }

        private class CurvatureListener : Java.Lang.Object, View.IOnApplyWindowInsetsListener
        {
            private readonly MainActivity _activity;

            public CurvatureListener(MainActivity activity)
            {
                _activity = activity;
            }

            public WindowInsets OnApplyWindowInsets(View view, WindowInsets insets)
            {
                try
                {
                    // 仅需在初始化时测量一次
                    if (_activity.B1 > 0) return view.OnApplyWindowInsets(insets);

                    // API 31+ 设备获取物理圆角
                    if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
                    {
                        var roundedCorners = insets.RoundedCorners;
                        if (roundedCorners != null)
                        {
                            _activity.B1 = GetCornerRadiusSafe(roundedCorners, RoundedCorner.PositionTopLeft);
                            _activity.B2 = GetCornerRadiusSafe(roundedCorners, RoundedCorner.PositionTopRight);
                            _activity.B3 = GetCornerRadiusSafe(roundedCorners, RoundedCorner.PositionBottomLeft);
                            _activity.B4 = GetCornerRadiusSafe(roundedCorners, RoundedCorner.PositionBottomRight);
                            
                            Log.Info("ScreenCurvature", $"Physical corners detected: " +
                                $"TL={_activity.B1}, TR={_activity.B2}, BL={_activity.B3}, BR={_activity.B4}");
                            
                            return view.OnApplyWindowInsets(insets);
                        }
                    }
                    
                    // API 31 以下设备使用默认值
                    Log.Info("ScreenCurvature", "Using default corner values");
                }
                catch (Exception ex)
                {
                    Log.Error("ScreenCurvature", $"Error reading corners: {ex.Message}");
                }
                
                return view.OnApplyWindowInsets(insets);
            }
            
            private float GetCornerRadiusSafe(RoundedCorners corners, int position)
            {
                try
                {
                    return corners.GetRoundedCorner(position)?.Radius ?? 0f;
                }
                catch
                {
                    return 0f;
                }
            }
        }

        protected override void OnDestroy()
        {
            // 清理监听器防止内存泄漏
            Window.DecorView.SetOnApplyWindowInsetsListener(null);
            base.OnDestroy();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
        // 示例：在需要的地方使用圆角值
        private void ApplyCurvatureToUI()
        {
            // 示例：设置自定义视图的圆角
            var customView = FindViewById<CurvatureAwareView>(Resource.Id.custom_view);
            if (customView != null)
            {
                customView.SetCornerRadii(B1, B2, B3, B4);
            }
            
            // 示例：设置安全边距
            var content = FindViewById<View>(Resource.Id.content);
            content.SetPadding((int)B1, (int)B1, (int)B2, (int)Math.Max(B3, B4));
        }
    }
    
    // 示例自定义视图（实际项目中单独文件）
    public class CurvatureAwareView : View
    {
        public CurvatureAwareView(Context context) : base(context) { }
        
        public void SetCornerRadii(float tl, float tr, float bl, float br)
        {
            // 实现自定义绘制逻辑
        }
    }
}