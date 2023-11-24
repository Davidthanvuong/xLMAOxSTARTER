using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class XP
{
    public const float MinTimeGain = 3600; //Seconds XP will start increasing after interacting
    public const float GainInterval = 600; //Seconds between XP gain events
    public int xp = 0;

    //Vars for milestones
    public int totalXP = 0;
    public int healthyTotalXP = 0;
    public int milestoneTotalXP = 0;
    public int highestXP = 0;

    public bool enableMechanics = true;
}
