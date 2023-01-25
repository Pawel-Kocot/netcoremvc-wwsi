using SklepInternetowy.Base;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Services
{
    public class PSUService : EntityBaseRepository<PSU>, IPSUService
    {
        public PSUService(AppDBContext context) : base(context) { }

    }
}
