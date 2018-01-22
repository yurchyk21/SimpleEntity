using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEntity.Entities
{
    public class UserProfile
    {
        [Key]
        public int Id { get; set; }
        [Required , StringLength(maximumLength:250)]
        public string Name { get; set; }
        [Required , StringLength(maximumLength: 128)]
        public string Image { get; set; }
        [Required , StringLength(maximumLength: 50)]
        public string Telephone { get; set; }
    }
}
