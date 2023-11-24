using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using xLMAOxSTARTER.DATA;


public class Milestone
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Func<string> DescFunc { get; set; }
    public Func<float> ScoreFunc { get; set; }
    public int Achieved { get; set; }

    public Milestone(int id, string name, Func<string> descFunc, Func<float> scoreFunc, int achieved = 0)
    {
        Id = id;
        Name = name;
        DescFunc = descFunc;
        ScoreFunc = scoreFunc; //Counts how many achieved achievements are in this milestone
        Achieved = achieved;
    }

    public static List<Milestone> Milestones = new()
    {
        new Milestone(
            0, "XP Wizard",
            () => "Have " + (Math.Floor(AppData.Milestones[0].ScoreFunc()) + 1) * 1000 + " XP in total",
            () => AppData.XPdata.totalXP / 1000
            ),
        new Milestone(
            1, "Healthy Consumer",
            () => "Have " + (Math.Floor(AppData.Milestones[1].ScoreFunc()) + 1) * 200 + " XP gained from good apps in total",
            () => AppData.XPdata.healthyTotalXP / 200
            ),
        new Milestone(
            2, "Successful Achiever",
            () => "Have " + (Math.Floor(AppData.Milestones[2].ScoreFunc()) + 1) * 200 + " XP gained from milestones in total",
            () => AppData.XPdata.milestoneTotalXP / 200
            ),
        new Milestone(
            3, "Energetic Wealth",
            () => "Have " + (Math.Floor(AppData.Milestones[3].ScoreFunc()) + 1) * 500 + " acquired XP at the same time",
            () => AppData.XPdata.highestXP / 500
            ),
        new Milestone(
            4, "Productivity Paragon",
            () => "Avoid using bad apps for consecutive " + (Math.Floor(AppData.Milestones[4].ScoreFunc()) + 5) * 4 + " hours",
            () => Math.Min(0, (AppData.MiscGame.highestNoBadAppTime / 3600) * 4 - 5)
            ),
        new Milestone(
            5, "Tempo Master",
            () => "Be offline for consecutive " + (Math.Floor(AppData.Milestones[5].ScoreFunc()) + 4) * 5 + " hours",
            () => Math.Min(0, (AppData.MiscGame.highestOfflineTime / 3600) * 5 - 4)
            ),
    };

    public bool enableMechanics = true;
}
