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

    public Milestone(int id, string name, Func<string> descFunc, Func<float> scoreFunc)
    {
        Id = id;
        Name = name;
        DescFunc = descFunc;
        ScoreFunc = scoreFunc; //Counts how many achieved achievements are in this milestone
    }

    public static List<Milestone> Milestones = new()
    {
        new Milestone(
            0, "XP Wizard",
            () => "Have " + (Math.Floor(AppData.Milestones[0].ScoreFunc()) + 1) * 1000 + " in total",
            () => AppData.XPdata.totalXP / 1000
            ),
        new Milestone(
            1, "Healthy Consumer",
            () => "Have " + (Math.Floor(AppData.Milestones[1].ScoreFunc()) + 1) * 200 + " gained from good apps in total",
            () => AppData.XPdata.healthyTotalXP / 200
            ),
        new Milestone(
            1, "Successful Achiever",
            () => "Have " + (Math.Floor(AppData.Milestones[2].ScoreFunc()) + 1) * 200 + " gained from milestones in total",
            () => AppData.XPdata.milestoneTotalXP / 200
            ),
    };

    public bool enableMechanics = true;
}
