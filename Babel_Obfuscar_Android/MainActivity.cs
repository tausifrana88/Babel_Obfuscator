using Android.Util;
using Babel_Obfuscar_Shared;

namespace Babel_Obfuscar_Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    private string AppName = "Babel Obfuscar Android";

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);

        SetContentView(Resource.Layout.activity_main);

        var mxApplication = new MxApplication();

        mxApplication.calculate();
    }
}

