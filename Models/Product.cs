using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Models
{
    public class Product
    {
        public int id {get;set;}
        public string name {get;set;} = string.Empty;
        public double price {get;set;}

    }
}