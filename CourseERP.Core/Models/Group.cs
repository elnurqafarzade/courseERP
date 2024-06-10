using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class Group : BaseModel
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public Group(string name)
        {
            Name = name;
            Code = name.Substring(0, 1).ToUpper() + Id.ToString();
        }
    }
}

