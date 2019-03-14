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

[assembly: Dependency(typeof(App2.Droid.IT4CService_Android))]
namespace App2.Droid
{
    class IT4CService_Android : Java.Lang.Object, IT4CService
    {
        public string getString(object obj)
        {
            Gson gson = new Gson();
            String li = gson.ToJson(new Java.Util.AbstractMap.SimpleEntry("w", "l"));
            return li + "\t" + obj + "\t";
        }

        public string getTime()
        {
            return "yo\t" + Java.Lang.JavaSystem.CurrentTimeMillis();
        }

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

        public void enableLogs()
        {
            //ForeSee.setDebugLogEnabled(true);
        }

        public void showInviteForSurveyId(string key)
        {
            ForeSee.ShowInviteForSurveyID(key);
        }
    }
}