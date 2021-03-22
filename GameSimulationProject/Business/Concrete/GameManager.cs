using GameSimulationProject.Business.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun başarıyla eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun silindi.");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " adlı oyun başarıyla güncellendi.");
        }
    }
}
