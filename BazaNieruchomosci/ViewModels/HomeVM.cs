using BazaNieruchomosci.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.ViewModels
{
    public class HomeVM
    {
        public string Tittle { get; set; }
        public List<ImmovableProperty> ImmovableProperties { get; set; }
    }

}
