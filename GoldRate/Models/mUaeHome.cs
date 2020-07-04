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

        [Column(name: "rGoldPriceOz", TypeName = "double(9,3)", Order = 1)]
        public double GoldPriceOz { get; set; } = 0;

        [Column(name: "rGoldPrice24", TypeName = "double(9,3)", Order = 2)]
        public double GoldPrice24 { get; set; } = default;
             
        [Column(name: "rGoldPrice22", TypeName = "double(9,3)", Order = 3)]
        public double GoldPrice22 { get; set; }

        [Column(name: "rGoldPrice21", TypeName = "double(9,3)", Order = 4)]
        public double GoldPrice21 { get; set; }
            
        [Column(name: "rGoldPrice18", TypeName = "double(9,3)", Order = 5)]
        public double GoldPrice18 { get; set; }

        [Column(name: "dGoldPriceUpdate", TypeName = "datetime", Order = 6)]
        public DateTime GoldPriceUpdate { get; set; }

        [Column(name: "rGoldPrice18", TypeName = "double(9,3)", Order = 5)]
        public double GoldWeight { get; set; }

        /**********************************************************/

        [Column(name: "rSuper98", TypeName = "double(9,3)", Order = 7)]
        public double Super98 { get; set; } = 1.91;

        [Column(name: "rSpecial95", TypeName = "double(9,3)", Order = 8)]
        public double Special95 { get; set; } = 1.80;

        [Column(name: "rEPlus91", TypeName = "double(9,3)", Order = 9)]
        public double EPlus91 { get; set; } = 1.72;

        [Column(name: "rDiesel", TypeName = "double(9,3)", Order = 10)]
        public double Diesel { get; set; } = 2.06;

        /**********************************************************/

    }
}
