﻿using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Content.PM;

namespace PokerApp
{

    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true, 
     ScreenOrientation = ScreenOrientation.Portrait)]
       public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}

