using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voorwerp
{
    interface IVoorwerpen
    {
        decimal Winst
        {
            get;
        }

        void GegevensTonen();
    }
}
