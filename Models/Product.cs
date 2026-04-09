using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Product
    {
        [Key]
        public int id {get;set;}
        public string name {get;set;} = string.Empty;
        [Column(TypeName = "double(10,2)")]
        public double price {get;set;}

    }
}