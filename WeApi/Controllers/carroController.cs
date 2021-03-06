using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using WeApi.Models;

namespace WeApi.Controllers
{
    public class carroController : ApiController
    {

        Carro[] carros = new Carro[]{
       
       new Carro{idcarro=1,marca="Ferrari",modelo=2012},
       new Carro{idcarro=2,marca="BMW",modelo=2010},
       new Carro{idcarro=3,marca="Mazda",modelo=2002},
       new Carro{idcarro=4,marca="Nizzan",modelo=2004},
       new Carro{idcarro=5,marca="Renault",modelo=1998}
       
       };

        IList<String> lstSismas = new List<String>();


        //public IEnumerable<Carro> GetAllCarro() {
        //    return carros;
        //}

        public IEnumerable<String> GetAllCarro()
        {
            lstSismas.Add("SistemaA");
            lstSismas.Add("SistemaB");
            lstSismas.Add("SistemaC");
            //return new JavaScriptSerializer().Serialize(lstSismas).ToString();
            return lstSismas;
        }

        public IHttpActionResult GetCarro(int id) {
            var carro = carros.FirstOrDefault((c)=>c.idcarro==id);
            if (carro!=null)
            {
                return Ok(carro);
            }
            else
            {
                return NotFound();
            }
        }



    }
}
