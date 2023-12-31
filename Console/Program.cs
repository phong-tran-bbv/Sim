﻿using Sim;
using Sim.Tools;

namespace Console
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string a = ">start {\"formatid\":\"gen1customgame\"}\n" +
                ">player p1 {\"name\":\"Bot 1\",\"team\":\"Nidorino|||NoAbility|doublekick,bodyslam,blizzard,thunderbolt||255,255,255,255,255,255||30,30,30,30,30,30||83|]Mew|||NoAbility|earthquake,hyperbeam,swordsdance,softboiled||255,255,255,255,255,255||30,30,30,30,30,30||66|]Rhyhorn|||NoAbility|rockslide,earthquake,substitute,bodyslam||255,255,255,255,255,255||30,30,30,30,30,30||85|]Vaporeon|||NoAbility|bodyslam,surf,rest,blizzard||255,255,255,255,255,255||30,30,30,30,30,30||74|]Oddish|||NoAbility|stunspore,megadrain,sleeppowder,doubleedge||255,255,255,255,255,255||30,30,30,30,30,30||88|]Kangaskhan|||NoAbility|rockslide,hyperbeam,earthquake,bodyslam||255,255,255,255,255,255||30,30,30,30,30,30||73|\"}\n" +
                ">player p2 {\"name\":\"Bot 2\",\"team\":\"Diglett|||NoAbility|earthquake,rockslide,slash,bodyslam||255,255,255,255,255,255||30,30,30,30,30,30||88|]Haunter|||NoAbility|hypnosis,thunderbolt,nightshade,psychic||255,,255,255,255,255||30,2,30,30,30,30||72|]Parasect|||NoAbility|swordsdance,spore,bodyslam,megadrain||255,255,255,255,255,255||30,30,30,30,30,30||78|]Poliwag|||NoAbility|hypnosis,amnesia,blizzard,surf||255,,255,255,255,255||30,2,30,30,30,30||86|]Electrode|||NoAbility|screech,explosion,thunderbolt,thunderwave||255,255,255,255,255,255||30,30,30,30,30,30||77|]Poliwhirl|||NoAbility|counter,amnesia,blizzard,surf||255,,255,255,255,255||30,2,30,30,30,30||76|}";

            var stream = new BattleStream();
            stream.write(a);
        }
    }
}