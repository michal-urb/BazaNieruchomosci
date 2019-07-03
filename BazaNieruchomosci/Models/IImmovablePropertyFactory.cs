using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaNieruchomosci.Models
{
    public interface IImmovablePropertyFactory
    {
        ImmovableProperty GetProperty(ImmovableProperty immovableProperty);
    }
}
