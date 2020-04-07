using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace AdministrationMng.Models
{
    
    public class Volunteers
    {

        public string VFname { get; set; }
        public string VLName{ get; set; }
        
        public string VUsername { get; set; }
        public string VPassword{ get; set; }
        public string VEdu { get; set; }
        public string Center { get; set; }

        public string VSKills { get; set; }
        public string VAddress { get; set; }
        public string VWorkPhone { get; set; }
        public string VHomePhone { get; set; }
        public string VCellPhone { get; set; }
        public string VEmail{ get; set; }
        public string VCurrentLicense{ get; set; }
        public string VDL{ get; set; }

        public string VSS { get; set; }
        public string ECFname { get; set; }
        public string ECLname { get; set; }
        public string ECHomePhone { get; set; }

        public string ECWorkPhone { get; set; }
        public string ECEmail { get; set; }
        public string ECAddress { get; set; }
        public string Status { get; set; }

       


    }
    
}