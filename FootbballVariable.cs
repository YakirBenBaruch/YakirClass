using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YakirClass;

public class FootballVariable
{
    public string Team1;
    public string Team2;
    public int ScoreT1;
    public int ScoreT2;

    public FootballVariable(string Team1, string Team2)
    {
        this.Team1 = Team1;
        this.Team2 = Team2;
        this.ScoreT1 = 0;
        this.ScoreT2 = 0;
    }

    public void SetTeam1(string t1)
    {
        this.Team1 = t1;
    }
    public string GetTeam1()
    {
        return this.Team1;
    }

    public void SetTeam2(string t2)
    {
        this.Team2 = t2;
    }
    public string GetTeam2()
    {
        return this.Team2;
    }



    public void SetScoreT1(int score)
    {
        if (score >= 0)
        {
            this.ScoreT1 = score;
        }
    }
    public int GetScoreT1()
    {
        return this.ScoreT1;
    }

    public void SetScoreT2(int score)
    {
        if (score >= 0)
        {
            this.ScoreT2 = score;
        }
    }
    public int GetScoreT2()
    {
        return this.ScoreT2;
    }

    public void AddGoalT1()
    {
        this.ScoreT1++;
    }

    public void AddGoalT2()
    {
        this.ScoreT2++;
    }

    public void AddGoalsT1(int goals)
    {
        if (goals > 0)
        {
            this.ScoreT1 += goals;
        }

    }

    public void AddGoalsT2(int goals)
    {
        if (goals > 0)
        {
            this.ScoreT2 += goals;
        }

    }

    public string Winner()
    {
        if (this.ScoreT1 > this.ScoreT2)
        {
            return this.Team1;
        }

        else if (this.ScoreT2 > this.ScoreT1)
        {
            return this.Team2;
        }
        else
        {
            return "Tie";
        }
    }

    public override string ToString()
    {
        string s = "";
        s += this.Team1 + " " + this.ScoreT1 + " - " + this.ScoreT2 + " " + this.Team2 + "\n";
        s += "Winner: " + Winner();
        return s;
    }
}