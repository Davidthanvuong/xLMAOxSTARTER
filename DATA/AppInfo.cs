public class AppInfo
{
    public const float DefaultMaxUsageTime = 36000;

    public string PackageName { get; set; }
    public string AppName { get; set; }
    public float UsageTime { get; set; }
    public float MaxUsageTime { get; set; }
    //App preference var
    //Using apps with this number being < 0 yields some penalty, e.g. disables XP generation
    //Using apps with this number being > 0 yields some reward
    public int BadGood { get; set; } = 0;

    /// <summary> usageTime is measured in ... amount of time </summary>
    public AppInfo(string packageName, string appName, float usageTime, float maxUsageTime = DefaultMaxUsageTime, int badGood = 0)
    {
        PackageName = packageName;
        AppName = appName;
        UsageTime = usageTime;
        MaxUsageTime = maxUsageTime;
        BadGood = badGood;
    }

    public static List<AppInfo> SampleUsages = new()
    {
        new("Testing", "Weird App", 36000, 36000, -1),
        new("Soup", "Super Soup", 12000, 36000, 1),
        new("Soup", "Chiken Chik", 18000, 36000),
        new("Rick", "Astley", 2000, 36000, 1),
        new("Anna", "Banana", 1000, 36000, -1),
        new("Ching Chong", "Ding Dong", 17000, 36000, -1),
    };
}