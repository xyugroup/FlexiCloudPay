using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexiCoudPay.Tasks
{
    [Table("stsTask")]
    public class Task : Entity 
    {
        public virtual string Description { get; set; }

        public virtual DateTime CreationTime { get; set; }

        

    }
}
