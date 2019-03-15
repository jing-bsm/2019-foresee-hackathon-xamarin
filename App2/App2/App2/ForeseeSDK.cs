using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public interface ForeseeSDK
    {
        void start();
        void increamentWithKey(String key);
        void reset();
        void checkIfEligible();
        void enableLogs();
        void showInviteForSurveyId(String key);
    }
}
