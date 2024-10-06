
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; }
        public string PackageCity { get; set; }
        public string PackageImageUrl { get; set; }
        public string PackageDescription { get; set; }
        public string PackageDayNight { get; set; }
        public double PackagePrice { get; set; }
        public bool PackageStatus { get; set; }
        public int PackageCapacity { get; set; }
    }
}
