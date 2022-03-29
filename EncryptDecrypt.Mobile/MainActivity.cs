using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using System.Xml.Linq;
using Android.Content;
using Xamarin.Essentials;
using Android.Content.PM;
using Android.Widget;
using System.Collections.Generic;
using EncryptDecrypt.Android;


namespace EncryptDecrypt.Mobile
{
    [Activity(Label = "Crypty", Theme = "@style/AppTheme", MainLauncher = true,ScreenOrientation =ScreenOrientation.Locked)]
    public class MainActivity : AppCompatActivity
    {
        private Button btnEncrypt;
        private Button btnDecrypt;
        private EditText txtEncrypt;
        private EditText txtDecrypt;
        private EditText txtPhrase;
        private AndroidX.AppCompat.App.AlertDialog.Builder dialog;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            btnDecrypt = FindViewById<Button>(Resource.Id.btnDecrypt);
            btnEncrypt = FindViewById<Button>(Resource.Id.btnEncrypted);
            txtEncrypt = FindViewById<EditText>(Resource.Id.txtEncrypt);
            txtDecrypt = FindViewById<EditText>(Resource.Id.txtDecrypt);
            txtPhrase=FindViewById<EditText>(Resource.Id.txtEncryptionKey);
            dialog = new AndroidX.AppCompat.App.AlertDialog.Builder(this);


            btnDecrypt.Click += BtnDecrypt_Click;
            btnEncrypt.Click += BtnEncrypt_Click;

        }

        private void BtnEncrypt_Click(object sender, System.EventArgs e)
        {
            try
            {
                MyEncryption enc = new MyEncryption(txtPhrase.Text.Trim());
                txtDecrypt.Text = enc.Encrypt(txtEncrypt.Text.Trim());
            }
            catch
            {
                dialog.SetTitle("Error!");
                dialog.SetMessage("An unexpected thing happened");
                dialog.Show();
            }
        }

        private void BtnDecrypt_Click(object sender, System.EventArgs e)
        {
            try
            {
               MyEncryption enc = new MyEncryption(txtPhrase.Text.Trim());
               txtEncrypt.Text = enc.Decrypt(txtDecrypt.Text.Trim());
            }
            catch
            {
                dialog.SetTitle("Error!");
                dialog.SetMessage("An unexpected thing happened");
                dialog.Show();
            }
        }
        //public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        //{
        //    Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

        //    base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        //}
    }
}