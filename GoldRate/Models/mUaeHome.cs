using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace GoldRate.Models
{
    public class mUaeHome
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(name: "iID", TypeName = "int", Order = 0)]
        public int iID { get; set; }

        [Column(name: "rGoldPriceOz", TypeName = "decimal(9,3)", Order = 1)]
        public decimal GoldPriceOz { get; set; } = 0;
        
        [Column(name: "rGoldPrice24", TypeName = "decimal(9,3)", Order = 2)]
        public decimal GoldPrice24 { get; set; }
             
        [Column(name: "rGoldPrice22", TypeName = "decimal(9,3)", Order = 3)]
        public decimal GoldPrice22 { get; set; }

        [Column(name: "rGoldPrice21", TypeName = "decimal(9,3)", Order = 4)]
        public decimal GoldPrice21 { get; set; }
            
        [Column(name: "rGoldPrice18", TypeName = "decimal(9,3)", Order = 5)]
        public decimal GoldPrice18 { get; set; }

        [Column(name: "dGoldPriceUpdate", TypeName = "datetime", Order = 6)]
        public DateTime GoldPriceUpdate { get; set; }

        [Column(name: "rGoldPrice18", TypeName = "decimal(9,3)", Order = 5)]
        public decimal GoldWeight { get; set; }

        /**********************************************************/

        [Column(name: "rSuper98", TypeName = "decimal(9,3)", Order = 7)]
        public decimal Super98 { get; set; }

        [Column(name: "rSpecial95", TypeName = "decimal(9,3)", Order = 8)]
        public decimal Special95 { get; set; }

        [Column(name: "rEPlus91", TypeName = "decimal(9,3)", Order = 9)]
        public decimal EPlus91 { get; set; }

        [Column(name: "rDiesel", TypeName = "decimal(9,3)", Order = 10)]
        public decimal Diesel { get; set; }

        /**********************************************************/

    }
}
