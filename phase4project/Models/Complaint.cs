using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace phase4project.Models
{
    public class Complaint
    {
        [Required]
        public int LogId
        {
            get;
            set;
        }
        [DataType(DataType.EmailAddress)]
        public string CustomerMail
        {
            get;
            set;
        }
        public string CustomerName
        {
            get;
            set;
        }
        public string LogStatus
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
    }
}