using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager : ISupplierService
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService) //Constructor new yapıldığında çalışır
    {
        _applicantService = applicantService;
    }
    public void GiveMask(Citizen citizen)
    {
        if (_applicantService.CheckPerson(citizen))
            Console.WriteLine(citizen.Name + " isimli vatandaşa maske verildi.");
        else
            Console.WriteLine(citizen.Name + " isimli vatandaşa maske verilemedi.");
        
    }
}
