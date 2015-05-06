using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Curp
{
    /// <summary>
    /// Descripción breve de curp
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class curp : System.Web.Services.WebService
    {

        [WebMethod]
        public string generar(string apellidopa, string apellidoma, string nombres, string ano, string mes, string dia, string sexo )
        {
            string curp = apellidopa.Substring(0, 1).ToUpper();
            for (int i = 1; i < apellidopa.Length; i++)
            {
                if (apellidopa.Substring(i, 1).ToUpper() == "A" || apellidopa.Substring(i, 1).ToUpper() == "E" || apellidopa.Substring(i, 1).ToUpper() == "I" || apellidopa.Substring(i, 1).ToUpper() == "O" || apellidopa.Substring(i, 1).ToUpper() == "U")
                {
                    curp += apellidopa.Substring(i, 1).ToUpper();
                    break;
                }
            }
            curp += apellidoma.Substring(0, 1).ToUpper();
            curp += nombres.Substring(0, 1).ToUpper();
            curp += ano.Substring(2, 2);
            if (mes.Length == 1)
            {
                curp += "0" + mes;
            }
            else 
            {
                curp += mes.Substring(0, 2);
            }
            if (dia.Length == 1)
            {
                curp += "0" + dia;
            }
            else
            {
                curp += dia.Substring(0, 2);
            }
            curp += sexo.Substring(0, 1);
            return curp;
        }
    }
}
