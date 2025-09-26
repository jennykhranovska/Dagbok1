using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dagbok
{
    public class DiaryEntry
    {
        public DateTime Date { get; set; } //  kan hämtas och läsas av andra 
        public string Text { get; set; }
    }

}
