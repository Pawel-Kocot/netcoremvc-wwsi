using SklepInternetowy.Models;
using System.Collections.Generic;

namespace SklepInternetowy

{
    public class NewComputerDropdowns
    {
        public NewComputerDropdowns()
        {
            CPUs = new List<CPU>();
        }

        public List<CPU> CPUs { get; set; }

    }

}
