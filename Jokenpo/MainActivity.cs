﻿using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Webkit;
using Android.Widget;
using AndroidX.AppCompat.App;
using System;

namespace Jokenpo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button btnIniciarJogo;
        WebView webView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnIniciarJogo = FindViewById<Button>(Resource.Id.btnIniciarJogo);

            btnIniciarJogo.Click += BtnIniciarJogo_Click;
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        private void BtnIniciarJogo_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(JogoActivity));
        }
    }
}