using Gestion.Capas.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Capas.BL
{
    public class EntidadesMantenimiento
    {
        private EntidadesDatos ObjetoMN = new EntidadesDatos();

        //DATATABLE------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DataTable MostrarDatos()
        {
            DataTable table = new DataTable();
            table = ObjetoMN.Mostrar();
            return table;
        }

        //LOGIN METHOD DATA EXTRACTION------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool LoginExect(string usuario, string contraseña)
        {
            return ObjetoMN.LoginTrue(usuario, contraseña);
        }

        //INSERT METHOD DATA EXTRACTION------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void InsertProductoBL(string Desc, string address, string Localidad, string TEntidad, string TDocumento, string NDocumento, string tell, string PW, string URLF, string URLIG, string URLTW, string URLTK, string CP, string CG, string LCredito, string user, string pass, string ROL, string Comment, string estado, bool Eliminable, string Fecha)
        {
            ObjetoMN.Insertar(Desc, address, Localidad, TEntidad, TDocumento, Convert.ToInt64(NDocumento), tell, PW, URLF, URLIG, URLTW, URLTK, CP, CG, Convert.ToDecimal(LCredito), user, pass, ROL, Comment, estado, Convert.ToByte(Eliminable), Fecha);
        }

        //EDIT METHOD DATA EXTRACTION------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Editar(string Desc, string address, string Localidad, string TEntidad, string TDocumento, string NDocumento, string tell, string PW, string URLF, string URLIG, string URLTW, string URLTK, string CP, string CG, string LCredito, string user, string pass, string ROL, string Comment, string estado, bool Eliminable, string Fecha, string ID)
        {
            ObjetoMN.EditarEntidades(Desc, address, Localidad, TEntidad, TDocumento, Convert.ToInt64(NDocumento), tell, PW, URLF, URLIG, URLTW, URLTK, CP, CG, Convert.ToDecimal(LCredito), user, pass, ROL, Comment, estado, Convert.ToByte(Eliminable), Fecha, Convert.ToInt64(ID));
        }

        //DELETE METHOD DATA EXTRACTION------------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Eliminar(string ID)
        {
            ObjetoMN.EliminarEntidades(Convert.ToInt32(ID));
        }
    }
}
