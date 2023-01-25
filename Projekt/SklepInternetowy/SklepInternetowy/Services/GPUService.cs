using SklepInternetowy.Base;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Services
{
    public class GPUService : EntityBaseRepository<GPU>, IGPUService
    {
        public GPUService(AppDBContext context) : base(context) { }

    }
}
