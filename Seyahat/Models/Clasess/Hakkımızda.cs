using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Seyahat.Models.Clasess
{
    public class Hakkımızda
    {
        [Key]
        public int ID { get; set; }
        public string FotoUrl { get; set; }
        public string Aciklama { get; set; }
    }
}