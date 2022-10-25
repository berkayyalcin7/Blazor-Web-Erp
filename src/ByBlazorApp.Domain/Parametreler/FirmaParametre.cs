using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace ByBlazorApp.Parametreler
{
    public class FirmaParametre:Entity<Guid>
    {
        public Guid UserId { get; set; }

        public Guid SubeId { get; set; }

        public Guid DonemId { get; set; }

        public Guid? DepoId { get; set; }
    }
}
