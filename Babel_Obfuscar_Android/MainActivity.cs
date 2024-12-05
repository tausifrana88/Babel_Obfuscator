using Android.Util;
using Babel_Obfuscar_Shared;

namespace Babel_Obfuscar_Android;

[Activity(Label = "@string/app_name", MainLauncher = true)]
public class MainActivity : Activity
{
    private string AppName = "Babel Obfuscar Android";

    public static MxApplicationShared? mApplication;

    protected override void OnCreate(Bundle? savedInstanceState)
    {
        base.OnCreate(savedInstanceState);
        SetContentView(Resource.Layout.activity_main);

        // Print Application Details from Shared Class Instance in Android Application
        mApplication = MxApplicationShared.getSharedInstance();

        var strR = mApplication.getApplicationInfo();
        Console.WriteLine("Android Application :: {0}" + strR);
    }

    #region Private Methods
    private int factorial(int num)
    {
        int result = 1;
        int b = 1;
        do
        {
            result = result * b;
            b++;
        } while (num >= b);

        return result;
    }

    private int recursively(int num)
    {
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            return recursively(num - 1) * num;
        }
    }
    #endregion

    #region Public Methods
    public static void add(int num01, int num02)
    {
        int result = num01 + num02;
        Console.WriteLine("ADDITION :: " + result);
    }

    public static void subtract(int num01, int num02)
    {
        int result = num01 - num02;
        Console.WriteLine("SUBSTRACTION :: " + result);
    }

    public static void multiply(int num01, int num02)
    {
        int result = num01 * num02;
        Console.WriteLine("MULTIPLICATION :: " + result);
    }

    public static void divide(int num01, int num02)
    {
        int result = num01 / num02;
        Console.WriteLine("DIVISION :: " + result);
    }
    #endregion
}
