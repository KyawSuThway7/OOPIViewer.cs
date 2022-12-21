using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentforOOP
{
    public interface IViewer
    {
        void YourReaction();
        double Yourpaymaent(double minutes);
        void YourpaymentwithMinutes(double minutes, double payment);
        double WatchOscarvideo(double minutes);
        double WatchFunnyvideo(double minutes);
        double WatchPost(double minutes);
      

    }
}
