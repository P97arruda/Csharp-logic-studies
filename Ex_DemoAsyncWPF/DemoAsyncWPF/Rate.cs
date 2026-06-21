using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAsyncWPF
{
    internal class Rate
    {
        public int RateId { get; set; }
        public string Code { get; set; }
        public float TaxRate { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{RateId} {Code} {TaxRate} {Name}";
        }
    }
}
