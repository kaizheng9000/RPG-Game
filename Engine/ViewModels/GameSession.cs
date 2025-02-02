using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        Player CurrentPlayer { get; set; }

        public GameSession()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "ADD INPUT HERE";
            CurrentPlayer.Gold = 100000;
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.Level = 1;
            CurrentPlayer.Exp = 0;

        }
    }
}
