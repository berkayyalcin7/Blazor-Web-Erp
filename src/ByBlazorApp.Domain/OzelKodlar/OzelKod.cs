using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBlazorApp.OzelKodlar
{
    public class OzelKod : FullAuditedAggregateRoot<Guid>
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public OzelKodTuru KodTuru { get; set; }
        public KartTuru KartTuru { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }

    }
}
