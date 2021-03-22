using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Abstract
{
    public interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
    }
}
