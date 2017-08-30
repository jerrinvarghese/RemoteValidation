using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCRemoteValidation.Models
{
    public class User
    {
        public int id { get; set; }
        [Remote("IsValidUserName", "User", ErrorMessage ="User Name already existing")]
        public string UserName { get; set; }
    }
}