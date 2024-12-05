using System;
using System.Reflection;

namespace Babel_Obfuscar_Shared
{
	public class MxApplicationShared
	{
        private static MxApplicationShared mSharedInstance;

        public MxApplicationShared()
		{
		}

        #region Public Methods
        public static MxApplicationShared getSharedInstance()
        {
            if (mSharedInstance == null)
            {
                mSharedInstance = new MxApplicationShared();
            }
            return mSharedInstance;
        }

        public string getApplicationInfo()
        {
            string retString = string.Empty;

            try
            {
#if __ANDROID__
                Android.Content.Context context = Android.App.Application.Context; //MTODO: Correct
                Android.Content.PM.PackageInfo pkInfo = context.PackageManager.GetPackageInfo(context.PackageName, 0);

                string appName = pkInfo.PackageName;
                string appVersion = pkInfo.VersionName;
                int appVersionCode = 0;
                if (Build.VERSION.SdkInt >= BuildVersionCodes.P)
                {
                    appVersionCode = Convert.ToInt32(pkInfo.LongVersionCode);
                }
                else
                {
                    appVersionCode = pkInfo.VersionCode;
                }

                retString = string.Format("APP NAME : {0} \nAPP VERSION : {1} \nAPP BUILD VERSION : {2} \nOS  : Android", appName, appVersion, appVersionCode);


#elif __IOS__
                string appName = Foundation.NSBundle.MainBundle.InfoDictionary["CFBundleName"].ToString();
                string appVersion = Foundation.NSBundle.MainBundle.InfoDictionary["CFBundleShortVersionString"].ToString();
                string appBuildVersion = Foundation.NSBundle.MainBundle.InfoDictionary["CFBundleVersion"].ToString();

                retString = string.Format("\n\nAPP NAME : {0} \nAPP VERSION : {1} \nAPP BUILD VERSION : {2} \nOS  : iOS", appName, appVersion, appBuildVersion);
#endif

            }
            catch (Exception ex)
            {
                Console.WriteLine("Shared Class Exception :: {0}"+ ex.ToString());
            }

            return retString;
        }
        #endregion
    }
}

