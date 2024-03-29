﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByBlazorApp.Depolar
{
    public class Depo : FullAuditedAggregateRoot<Guid>
    {
        public string Kod { get; set; }
        public string Ad { get; set; }

        public Guid? OzelKod1Id { get; set; }

        public Guid? OzelKod2Id { get; set; }

        public Guid SubeId { get; set; }

        public string Aciklama { get; set; }

        public bool Durum { get; set; }
    }
}
