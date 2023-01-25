using Microsoft.AspNetCore.Mvc.Rendering;
using SklepInternetowy.Models;
using System.Collections.Generic;
using SklepInternetowy.Base;

namespace SklepInternetowy
{
    public class ComputerCreateModel
    {
        public int ID { get; set; }
        public List<int> CPUIDs { get; set; }


    }
}
