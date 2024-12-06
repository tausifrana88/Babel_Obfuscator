using System;
using System.Reflection;
using Android.Content;
using Android.OS;
using Babel_Obfuscar_Shared;

namespace Babel_Obfuscar_Android
{
    public class MxApplication : Application
    {
        public MxApplication()
        {

        }

        public override void OnCreate()
        {
            try
            {
                base.OnCreate();
            }
            catch (Exception ex)
            {
                Console.WriteLine("MxApplication Class Exception :: {0}" + ex.ToString());
            }
        }

        public void calculate()
        {
            try
            {
                int result = 10 + 20;
                Console.WriteLine("Result :: " + result);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception :: {0}" + ex.ToString());
            }
        }

        ~MxApplication()
        {

        }
    }
}

