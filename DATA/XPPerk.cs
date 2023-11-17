﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class XPPerk
{
    public string AppName { get; set; }
    public int XPCost { get; set; }
    public float RewardTime { get; set; }

    public XPPerk(string appName, int xpCost, float rewardTime) {
        AppName = appName;
        XPCost = xpCost;
        RewardTime = rewardTime;
    }

    public bool enableMechanics = true;

    public static List<XPPerk> SamplePerks = new()
    {
        new("Weird App", 100, 1800),
        new("Weird App", 150, 3600), //Wait for longer to gain more reward, for example
    };
}