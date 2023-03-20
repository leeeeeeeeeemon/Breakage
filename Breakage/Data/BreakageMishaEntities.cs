using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Breakage.Data
{
    public partial class BreakageMishaEntities
    {
        private static polomkaEntities _context;
        public static polomkaEntities GetContext()
        {
            if( _context == null )
                _context = new polomkaEntities();

            return _context;
        }
    }
}
