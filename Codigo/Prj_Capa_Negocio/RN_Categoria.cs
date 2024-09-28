using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Prj_Capa_Datos;


namespace Prj_Capa_Negocio
{
    public class RN_Categoria
    {
        public void RN_Register_Category(string nomCateg)
        {


            BD_Categoria obj = new BD_Categoria();
            obj.BD_Register_Category(nomCateg); 


        }


        // editar

        public void RN_Editar_Category(int idcat, string nomCateg)
        {
            BD_Categoria obj = new BD_Categoria();
            obj.BD_Editar_Category(idcat, nomCateg);

        }

        // mostrar registros
        public DataTable RN_ShowAllCategories()
        {
            BD_Categoria obj = new BD_Categoria();
            return obj.BD_ShowAllCategories();
        }

    }
}
