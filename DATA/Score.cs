using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Score
{
    public float MinTimeGain = 3600; //Seconds score will start increasing after interacting
    public float GainInterval = 600; //Seconds between score gain events
    public int score = 0;

    public bool enableMechanics = true;
}
