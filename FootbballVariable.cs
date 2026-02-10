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

    public FootballVariable(string t1, string t2)
    {
        Team1 = t1;
        Team2 = t2;
        ScoreT1 = 0;
        ScoreT2 = 0;
    }

    public void SetTeam1(string t1)
    {
        Team1 = t1;
    }

    public void SetTeam2(string t2)
    {
        Team2 = t2;
    }

    public void SetScoreT1(int score)
    {
        if (score >= 0)
        {
            ScoreT1 = score;
        }
    }

    public void SetScoreT2(int score)
    {
        if (score >= 0)
        {
            ScoreT2 = score;
        }
    }

    public int GetScoreT1()
    {
        return ScoreT1;
    }

    public int GetScoreT2()
    {
        return ScoreT2;
    }

    public string GetTeam1()
    {
        return Team1;
    }

    public string GetTeam2()
    {
        return Team2;
    }


    public void AddGoalT1()
    {
        ScoreT1++;
    }

    public void AddGoalT2()
    {
        ScoreT2++;
    }

    public void AddGoalsT1(int goals)
    {
        if (goals > 0)
        {
            ScoreT1 += goals;
        }

    }

    public void AddGoalsT2(int goals)
    {
        if (goals > 0)
        {
            ScoreT2 += goals;
        }

    }

    public string Winner()
    {
        if (ScoreT1 > ScoreT2)
        {
            return Team1;
        }


        if (ScoreT2 > ScoreT1)
        {
            return Team2;
        }

        return "Tie";
    }

    public override string ToString()
    {
        string s = "";
        s += Team1 + " " + ScoreT1 + " - " + ScoreT2 + " " + Team2 + "\n";
        s += "Winner: " + Winner();
        return s;
    }
}