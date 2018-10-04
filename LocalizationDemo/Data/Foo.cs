using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Data
{
    public class Foo
    {
        [Key]
        public int Id { get; set; }

        public virtual ICollection<Bar> Bars { get; set; } = new List<Bar>();
    }
}
