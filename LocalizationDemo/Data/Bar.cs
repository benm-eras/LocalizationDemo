using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDemo.Data
{
    public class Bar
    {
        [Key]
        public int Id { get; set; }

        public int FooId { get; set; }

        [ForeignKey(nameof(FooId))]
        public Foo Foo { get; set; }

        public string Value { get; set; }
    }
}
