using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YakirClass;

namespace Yakir
{
    public class FootballGame
    {
        public static void UnitTest()
        {
            FootballVariable game1;
            game1 = new FootballVariable("Maccabi", "Hapoel");

            game1.AddGoalT1();
            game1.AddGoalT2();
            game1.AddGoalT2();
            game1.AddGoalT1();
            game1.AddGoalT1();

            Console.WriteLine(game1.ScoreT1);
            Console.WriteLine(game1.ScoreT2);

            Console.WriteLine();

            Console.WriteLine(game1.Winner());
            Console.WriteLine(game1.GameString());
        }

    }
}
