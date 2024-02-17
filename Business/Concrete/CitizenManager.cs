using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class CitizenManager: IApplicantService
{
    public void ApplyForMask(Citizen citizen)
    {

    }
    public List<Citizen> GetList()
    {
        return null;
    }

    public bool CheckPerson(Citizen citizen)
    {
        KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

        return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(citizen.NationalIdentity, citizen.Name, citizen.LastName, citizen.BirthDay))).Result.Body.TCKimlikNoDogrulaResult;
    }
}
