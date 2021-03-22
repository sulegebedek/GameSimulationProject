using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
