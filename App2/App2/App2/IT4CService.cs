using System;
using System.Collections.Generic;
using System.Text;

namespace App2
{
    public interface IT4CService
    {
        String getTime();
        String getString(Object obj);
        void start();
        void increamentWithKey(String key);
        void reset();
        void checkIfEligible();
        void enableLogs();
        void showInviteForSurveyId(String key);
    }
}
