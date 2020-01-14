using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace SwaggerDemo.Models
{
    public class TodoItems
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DefaultValue(false)]
        public bool IsComplete { get; set; }
    }
}
