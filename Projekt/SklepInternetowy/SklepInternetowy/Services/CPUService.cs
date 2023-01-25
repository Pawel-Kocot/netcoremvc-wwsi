using SklepInternetowy.Base;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Services
{
    public class CPUService : EntityBaseRepository<CPU>, ICPUService
    {
        public CPUService(AppDBContext context) : base(context) { }

    }
}
