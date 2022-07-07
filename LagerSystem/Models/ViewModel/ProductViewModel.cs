using System.ComponentModel.DataAnnotations;

namespace LagerSystem.Models.ViewModel
{

#nullable disable
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public int InventoryValue { get; set; }
    }
}
