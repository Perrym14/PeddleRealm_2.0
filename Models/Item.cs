using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PeddleRealmCore.Models
{
    public class Item
    {
        public int Id { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ItemType ItemType { get; set; }

        [Required]
        public byte ItemTypeId { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }

        [Required]
        public string ItemPhoto { get; set; }
    }
}
