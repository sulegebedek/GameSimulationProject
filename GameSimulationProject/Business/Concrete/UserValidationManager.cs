using GameSimulationProject.Adapters;
using GameSimulationProject.Business.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        IUserValidationService userValidationService;
        public bool Validate(Gamer gamer)
        {
            userValidationService = new EStateServiceAdapter();

            return userValidationService.Validate(gamer);
        }
    }
}
