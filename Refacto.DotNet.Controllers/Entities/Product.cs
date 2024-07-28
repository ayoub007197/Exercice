using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Refacto.DotNet.Controllers.Entities
{
    [Table("products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public long Id { get; set; }

        [Column("lead_time")]
        public int LeadTime { get; set; }

        [Column("available")]
        public int Available { get; set; }

        [Column("type")]
        public string? Type { get; set; }

        [Column("name")]
        public string? Name { get; set; }

        [Column("expiry_date")]
        public DateTime? ExpiryDate { get; set; }

        [Column("season_start_date")]
        public DateTime? SeasonStartDate { get; set; }

        [Column("season_end_date")]
        public DateTime? SeasonEndDate { get; set; }

        [Column("flash_sale_start")]
        public DateTime? FlashSaleStart { get; set; } // Date de début de la vente flash

        [Column("flash_sale_end")]
        public DateTime? FlashSaleEnd { get; set; } // Date de fin de la vente flash

        [Column("flash_sale_max_quantity")]
        public int? FlashSaleMaxQuantity { get; set; } // Quantité maximale vendable pendant la vente flash
    }
}
