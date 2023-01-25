using SklepInternetowy.Base;
using SklepInternetowy.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SklepInternetowy.Services
{
    public class ComputerServices
    {
        private readonly AppDBContext _context;
        public ComputerServices(AppDBContext context)
        {
            _context = context;
        }

        NewComputerDropdowns GetNewComputerDropdownsValues()
        {
            var response = new NewComputerDropdowns()
            {
                CPUs = _context.CPUs.OrderBy(n => n.Firma).ToList()
            };
            return response;
        }

    }
}
