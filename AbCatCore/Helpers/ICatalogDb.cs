using EPCat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbCatCore.Helpers
{
    public interface ICatalogDb
    {
        List<EpItem> Items { get; }
        void Load();
        
    }
}
