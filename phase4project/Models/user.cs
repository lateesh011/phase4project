using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using DAL;

namespace phase4project.Models
{
        public class user
        {
            [Required]
            public int UserID
            {
                get;
                set;
            }
            [DataType(DataType.Password)]
            public string password
            {
                get;
                set;
            }
        }
}