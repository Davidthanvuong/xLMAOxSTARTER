using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ScorePerk
{
    public string AppName { get; set; }
    public int ScoreCost { get; set; }
    public float RewardTime { get; set; }

    public ScorePerk(string appName, int scoreCost, float rewardTime) {
        AppName = appName; 
        ScoreCost = scoreCost; 
        RewardTime = rewardTime;
    }

    public static List<ScorePerk> SamplePerks = new()
    {
        new("Weird App", 100, 1800),
        new("Weird App", 150, 3600), //Wait for longer to gain more reward
    };
}