using Babel_Obfuscar_Shared;

namespace Babel_Obfuscar_IOS;

[Register ("AppDelegate")]
public class AppDelegate : UIApplicationDelegate {

    private string AppName = "Babel Obfuscar IOS";
    public static MxApplicationShared? mApplication;

    public override UIWindow? Window {
		get;
		set;
	}

	public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
	{
		// create a new window instance based on the screen size
		Window = new UIWindow (UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var vc = new UIViewController ();
		vc.View!.AddSubview (new UILabel (Window!.Frame) {
			BackgroundColor = UIColor.SystemBackground,
			TextAlignment = UITextAlignment.Center,
			Text = "Hello, iOS!",
			AutoresizingMask = UIViewAutoresizing.All,
		});
		Window.RootViewController = vc;

		// make the window visible
		Window.MakeKeyAndVisible ();

        // Print Application Details from Shared Class Instance in Android Application
        mApplication = MxApplicationShared.getSharedInstance();

        var strR = mApplication.getApplicationInfo();
        Console.WriteLine("IOS Application :: {0}" + strR);

        return true;
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

