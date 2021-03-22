using EStateServiceReference;
using GameSimulationProject.Business.Abstract;
using GameSimulationProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulationProject.Adapters
{
    class EStateServiceAdapter : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            EStateServiceReference.KPSPublicSoapClient client = new KPSPublicSoapClient
            (KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(Convert.ToInt64(gamer.IdentityNumber),
                gamer.FirstName.ToUpper(),
                gamer.LastName.ToUpper(), 
                gamer.DateYear.Year))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
