using SklepInternetowy.Base;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Services
{
    public class RAMService : EntityBaseRepository<RAM>, IRAMService
    {
        public RAMService(AppDBContext context) : base(context) { }

    }
}
