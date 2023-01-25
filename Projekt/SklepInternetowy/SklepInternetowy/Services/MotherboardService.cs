using SklepInternetowy.Base;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Services
{
    public class MotherboardService : EntityBaseRepository<Motherboard>, IMotherboardService
    {
        public MotherboardService(AppDBContext context) : base(context) { }

    }
}
