using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SklepInternetowy.Models;
using System.Collections.Generic;
using System.Linq;

namespace SklepInternetowy
{
    public class AppDBInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //CPU
                if (!context.CPUs.Any())
                {
                    context.CPUs.AddRange(new List<CPU>()
                    {
                        new CPU()
                        {
                            Firma = "AMD",
                            Model = "Ryzen 7 5800X3D",
                            Cena = 1689
                        },
                    });
                    context.SaveChanges();
                }

                //GPU
                if (!context.GPUs.Any())
                {
                    context.GPUs.AddRange(new List<GPU>()
                    {
                        new GPU()
                        {
                            Firma = "NVIDIA",
                            Model = "RTX 4090",
                            Cena = 10000
                        },
                    });
                    context.SaveChanges();
                }
                //Motherboard
                if (!context.Motherboards.Any())
                {
                    context.Motherboards.AddRange(new List<Motherboard>()
                    {
                        new Motherboard()
                        {
                            Firma = "ASUS",
                            Model = "PRIME Z690-P DDR4",
                            Cena = 949
                        },
                    });
                    context.SaveChanges();
                }
                //PSU
                if (!context.PSUs.Any())
                {
                    context.PSUs.AddRange(new List<PSU>()
                    {
                        new PSU()
                        {
                            Firma = "be quiet!",
                            Model = "Straight Power 11 850W 80 Plus Gold",
                            Cena = 759
                        },
                    });
                    context.SaveChanges();
                }
                //RAM
                if (!context.RAMs.Any())
                {
                    context.RAMs.AddRange(new List<RAM>()
                    {
                        new RAM()
                        {
                            Firma = "GOODRAM",
                            Model = "16GB (2x8GB) 3600MHz CL18 IRDM PRO Deep Black",
                            Cena = 219
                        },
                    });
                    context.SaveChanges();
                }
                //Storage
                if (!context.Storages.Any())
                {
                    context.Storages.AddRange(new List<Storage>()
                    {
                        new Storage()
                        {
                            Firma = "WD",
                            Model = "1TB M.2 PCIe NVMe Blue SN570",
                            Cena = 295
                        },
                    });
                    context.SaveChanges();
                }
                //Computer





            }

        }

    }
}