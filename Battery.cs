
using System.Windows.Forms;

namespace Wox.Plugin.Battery
{
    internal static class Battery
    {

        public static int BatteryLifePercent
        {
            get
            {
                PowerStatus pwr = SystemInformation.PowerStatus;
                return (int)(pwr.BatteryLifePercent * 100);
            }
        }

        public static int BatteryFullLifetime
        {
            get
            {
                PowerStatus pwr = SystemInformation.PowerStatus;
                return pwr.BatteryFullLifetime;
            }
        }

        public static int BatteryLifeRemaining
        {
            get
            {
                PowerStatus pwr = SystemInformation.PowerStatus;
                return pwr.BatteryLifeRemaining;
            }
        }

        public static string BatteryChargeStatus
        {
            get
            {
                PowerStatus pwr = SystemInformation.PowerStatus;
                return pwr.BatteryChargeStatus.ToString();
            }
        }
    }
}
