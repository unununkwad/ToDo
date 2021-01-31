using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TODO
{
    public class contactDb
    {
        public virtual int Id { get; set; }
        public virtual string Day { get; set; }
        public virtual int Sort_Value { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual bool Reminder { get; set; }
        public virtual bool Done { get; set; }
    }
}
