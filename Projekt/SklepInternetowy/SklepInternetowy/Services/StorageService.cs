using SklepInternetowy.Base;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy.Services
{
    public class StorageService : EntityBaseRepository<Storage>, IStorageService
    {
        public StorageService(AppDBContext context) : base(context) { }

    }
}
