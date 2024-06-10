using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseERP.Core.Models
{
    public class BaseModel
    {
        private int _counter;
        public int Id { get; set; }

        public BaseModel()
        {
            Id = ++_counter;
        }
    }
}
