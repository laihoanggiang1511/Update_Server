using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Script.Serialization;
using UpdateServer.Models;

namespace UpdateServer.Controllers
{
    public class UpdateController : ApiController
    {
        // GET: api/Update
        public UpdateModel Get()
        {

            UpdateModel updateModel = new UpdateModel();
            //JavaScriptSerializer serializer = new JavaScriptSerializer();
            //string json = serializer.Serialize(updateModel);
            return updateModel;
        }

        // GET: api/Update/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Update
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Update/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Update/5
        public void Delete(int id)
        {
        }
    }
}
