﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class TemplateClass
    {
        // Insert class field here, example
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { set; get; }

        [Required]
        public string Name { set; get; }

        // In case have relation with other table, for example

        // Foreign key to another entity example
        public int Grade { set; get; }

        // Pointer to another entity example
        public Template2Class Template2 { set; get; }
        
    }
}
