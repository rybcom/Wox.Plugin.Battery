
using System.Collections.Generic;

namespace Wox.Plugin.Battery
{
    public class WoxBatteryInformation : IPlugin
    {

        #region wox overrides

        public void Init(PluginInitContext context)
        {
        }

        public List<Result> Query(Query query)
        {
            List<Result> resultList = new List<Result>();

            AddShowBatteryStatusCommand(resultList);

            return resultList;
        }

        #endregion

        #region commands

        private string GetIconPathByBatteryPercentage(int percentage)
        {
            if (percentage < 5)
            {
                return "Images\\battery_min.png";
            }
            else if(percentage < 15)
            {
                return "Images\\battery_low.png";
            }
            else if (percentage < 40)
            {
                return "Images\\battery_mid.png";
            }
            else if (percentage <75)
            {
                return "Images\\battery_ok.png";
            }
            else
            {
                return "Images\\battery.png";
            }
        }

        private void AddShowBatteryStatusCommand(List<Result> resultList)
        {
            
            Result result = new Result
            {
                Title = $"Battery : {Battery.BatteryLifePercent} %",
                SubTitle = $"Status : {Battery.BatteryChargeStatus}, Life remaining : {Battery.BatteryLifeRemaining}",
                Score = 100,
                IcoPath = GetIconPathByBatteryPercentage(Battery.BatteryLifePercent),
                Action = e =>
                {
                    return true;
                }
            };

            resultList.Add(result);
        }

        #endregion

    }
}
