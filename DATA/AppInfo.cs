public class AppInfo
{
    public const float DefaultMaxUsageTime = 36000;

    public string PackageName { get; set; }
    public string AppName { get; set; }
    public float UsageTime { get; set; }
    public float MaxUsageTime { get; set; }

    /// <summary> usageTime is measured in ... amount of time </summary>
    public AppInfo(string packageName, string appName, float usageTime, float maxUsageTime = DefaultMaxUsageTime)
    {
        PackageName = packageName;
        AppName = appName;
        UsageTime = usageTime;
        MaxUsageTime = maxUsageTime;
    }

    public static List<AppInfo> SampleUsages = new()
    {
        new("Testing", "Weird App", 36000, 36000),
        new("Soup", "Super Soup", 12000, 36000),
        new("Soup", "Chiken Chik", 18000, 36000),
        new("Rick", "Astley", 2000, 36000),
        new("Anna", "Banana", 1000, 36000),
        new("Ching Chong", "Ding Dong", 17000, 36000),
    };
}