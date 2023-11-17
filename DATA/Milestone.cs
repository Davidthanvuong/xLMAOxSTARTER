using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        ScoreFunc = scoreFunc;
    }

    public bool enableMechanics = true;
}
