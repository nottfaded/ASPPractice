using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace University.Data.Models
{
    public class Product
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Column("countInStock")]
        public int CountInStock { get; set; }
        [Column("price")]
        public int Price { get; set; }
        [Column("categoryId")]
        [ForeignKey("category_fk")]
        public int CategoryId { get; set; }
        [Column("imageUrl")]
        public string ImageUrl { get; set; }
    }
}
