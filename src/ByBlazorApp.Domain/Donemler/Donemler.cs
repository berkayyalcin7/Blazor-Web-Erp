using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBlazorApp.Donemler
{
    public class Donemler : FullAuditedAggregateRoot<Guid>
    {
        public string Kod { get; set; }
        public string Ad { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }

    }
}
