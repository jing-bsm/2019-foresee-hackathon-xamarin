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
using Com.Foresee.Sdk;
using Google.Gson;
using Java.Util;
using Xamarin.Forms;

[assembly: Dependency(typeof(App2.Droid.ForeseeSDK_Android))]
namespace App2.Droid
{
    class ForeseeSDK_Android : Java.Lang.Object, ForeseeSDK
    {
        public void increamentWithKey(string key)
        {
            ForeSee.IncrementSignificantEventCountWithKey(key);
        }

        public void reset()
        {
            ForeSee.ResetState();
        }

        public void checkIfEligible()
        {
            ForeSee.CheckIfEligibleForSurvey();
        }

        public void start()
        {
            ForeSee.Start((Android.App.Application)Android.App.Application.Context);
        }

        public void showInviteForSurveyId(string key)
        {
            ForeSee.ShowInviteForSurveyID(key);
        }

        public void enableLogs()
        {
            //ForeSee.setDebugLogEnabled(true);
        }
    }
}