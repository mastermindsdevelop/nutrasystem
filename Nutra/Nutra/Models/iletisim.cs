using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nutra.Models
{
    public class iletisim
    {
        public int Id { get; set; }
        public string adsoyad { get; set; }
        public string eposta { get; set; }
        public string konu { get; set; }
        public string tel { get; set; }
        public virtual sube sube  { get; set; }
        public virtual nereden nereden { get; set; }
        public string mesaj  { get; set; }
        public string tarih { get; set; }
        public int goruldu { get; set; }
    }
}