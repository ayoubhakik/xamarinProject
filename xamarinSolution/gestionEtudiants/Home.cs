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

namespace gestionEtudiants
{
    [Activity(Label = "Home")]
    public class Home : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.home);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            button1.Click += delegate
            {
                Intent absence = new Intent(this, typeof(Absence));
                StartActivity(absence);
            };
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            button2.Click += delegate
            {
                Intent add = new Intent(this, typeof(AddStudent));
                StartActivity(add);
            };
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            button3.Click += delegate
            {
                Intent newL = new Intent(this, typeof(NewLesson));
                StartActivity(newL);
            };
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            button4.Click += delegate
            {
                Intent search = new Intent(this, typeof(Search));
                StartActivity(search);
            };
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            button5.Click += delegate
            {
                Intent MainActivity = new Intent(this, typeof(MainActivity));
                StartActivity(MainActivity);
            };
        }
    }
}