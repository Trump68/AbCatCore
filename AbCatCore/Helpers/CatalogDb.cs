using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EPCat.Model;

namespace AbCatCore.Helpers
{
    public class CatalogDb : ICatalogDb
    {

        private List<EpItem> _Items;
        public List<EpItem> Items
        {
            get { return _Items; }
        }

        public void Load()
        {
            _Items = CatalogLoaderHelper.ProcessScriptFile();
        }
    }
}
