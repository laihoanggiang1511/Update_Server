using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace UpdateServer.Models
{
    [DataContract]
    public class UpdateModel
    {

        public UpdateModel()
        {
            UpdateURL = "https://google.com.vn";
            ServerVersion = "1.0.0.0";
            IsProductValid = true;
            ProductId = 1001;
        }
        [DataMember]
        public string UpdateURL { get; set; }
        [DataMember]
        public string ServerVersion { get; set; }
        [DataMember]
        public bool IsProductValid { get; set; }
        [DataMember]
        public string[] Descriptions { get; set; }
        [DataMember]
        public int ProductId { get; set; }
    }
}