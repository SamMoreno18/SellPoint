using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj_Capa_Datos
{
    public class BDConexion
    {
        public string Conectar()
        {
            return "data source = Darjunter\\SQLEXPRESS; Initial Catalog = POS_Microsell_Lite; uid=sa; pwd=admin123";
        }
    }
}