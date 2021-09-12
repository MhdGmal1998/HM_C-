using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddEmpolyeeAPI
{
   public class EmpolyeeBase : IEmpolyee
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        virtual public decimal  Salary{ get; set; }
    }
}
