using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBlazorApp.Makbuzlar
{
    public class MakbuzHareket:FullAuditedEntity<Guid>
    {
        public Guid MakbuzId { get; set; }

        public OdemeTuru OdemeTuru { get; set; }

        public string TakipNo { get; set; }

        public Guid? CekBankaId { get; set; }
        public Guid? CekBankaSubeId { get; set; }
        
        public string CekHesapNo { get; set; }
        public string BelgeNo { get; set; }
        public DateTime Vade { get; set; }
        public string AsilBorcu { get; set; }
        // Ciro
        public string Ciranta { get; set; }

        public Guid? KasaId { get; set; }
        public Guid? BankaHesapId { get; set; }
        public decimal Tutar { get; set; }
        public BelgeDurumu BelgeDurumu { get; set; }

        //Kendimize ait mi kontrol
        public bool KendiBelgemiz { get; set; }

        public string Aciklama { get; set; }

    }
}
