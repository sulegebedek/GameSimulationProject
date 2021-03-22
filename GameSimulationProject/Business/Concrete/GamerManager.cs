using GameSimulationProject.Business.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Business.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kaydınız Başarıyla Gerçekleşmiştir!");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız, Kayıt Gerçekleştirilemedi!");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kaydınız Başarıyla Silinmiştir!");
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kaydınız Başarıyla Güncellenmiştir!");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız! Güncelleme Gerçekleştirildi!.");
            }
        }
    }
}
