using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    interface ITributavel
    {
        double calculaTributos();
    }

    public interface IRentavel
    {
        double calculaRendimento();
    }

}
