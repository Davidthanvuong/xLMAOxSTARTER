//> TODO: Make app's icon working

namespace xLMAOxSTARTER.Droid
{
    public class AppUsageManager
    {
        public List<AppInfo> GetInstalledAppsAndUsage(Context context)
        {
            var installedApps = GetInstalledApps(context);
            var usageStats = GetUsageStats(context);

            foreach (var app in installedApps)
            {
                var usage = usageStats.FirstOrDefault(u => u.PackageName == app.PackageName);
                app.UsageTime = usage?.TotalTimeInForeground ?? 0;
            }

            return installedApps;
        }
        //.--------------------------------------------

        private List<AppInfo> GetInstalledApps(Context context)
        {
            var packageManager = context.PackageManager;
            var installedApps = new List<AppInfo>();

            var apps = packageManager.GetInstalledApplications(PackageInfoFlags.MatchAll);

            foreach (var app in apps)
            {
                installedApps.Add(new AppInfo
                {
                    PackageName = app.PackageName,
                    AppName = app.LoadLabel(packageManager).ToString()
                });
            }

            return installedApps;
        }

        private List<UsageStats> GetUsageStats(Context context)
        {
            var calendar = Calendar.GetInstance(Java.Util.TimeZone.Default);
            calendar.TimeInMillis = Java.Lang.JavaSystem.CurrentTimeMillis();
            long endTime = calendar.TimeInMillis;
            calendar.Add(CalendarField.Month, -1);
            long startTime = calendar.TimeInMillis;

            var usageStatsManager = (UsageStatsManager)context.GetSystemService(Context.UsageStatsService);
            var usageEvents = usageStatsManager.QueryUsageStats(UsageStatsInterval.Monthly, startTime, endTime);

            return usageEvents
                .Where(usage => usage.TotalTimeInForeground > 0)
                .Select(usage => new UsageStats
                {
                    PackageName = usage.PackageName,
                    TotalTimeInForeground = usage.TotalTimeInForeground
                })
                .ToList();
        }
    }

    public class AppInfo
    {
        public string PackageName { get; set; }
        public string AppName { get; set; }
        public long UsageTime { get; set; }
    }

    public class UsageStats
    {
        public string PackageName { get; set; }
        public long TotalTimeInForeground { get; set; }
    }
}