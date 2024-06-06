using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryCosmetica
{
    internal class clsProcesosBD
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private string varCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Cosmetica.accdb";
    }
}
