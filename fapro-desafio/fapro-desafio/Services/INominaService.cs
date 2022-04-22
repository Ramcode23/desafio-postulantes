using fapro_desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fapro_desafio.Services
{
    public interface INominaService
    {
        List<NominaRegistro> GetNominaRegistros();
     
    }
}
