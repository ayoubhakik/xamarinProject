using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace gestionEtudiants
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource

            SetContentView(Resource.Layout.loginPage);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                Intent registerActivity = new Intent(this, typeof(RegisterActivity));
                StartActivity(registerActivity);
            };
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate
            {
                Intent home = new Intent(this, typeof(Home));
                StartActivity(home);
            };

        }
    }
}