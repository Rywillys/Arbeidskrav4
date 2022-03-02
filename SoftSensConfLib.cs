using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeidskrav1
{
    //internal
    class conf
    {
        string result;

        public string Status(float status)
        {

            if (status == 0)
            {
                result = "Ok";
            }
            else if (status == 1)
            {
                result = "Fail";
            }
            else if (status == 2)
            {
                result = "alarmL";
            }
            else if (status == 3)
            {
                result = "alarmH";
            }
            return result;
        }
    }
}
