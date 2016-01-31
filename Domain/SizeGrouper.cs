using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class SizeGrouper
    {
        private int v;

        public SizeGrouper(int groupSize)
        {
            this.v = groupSize;
        }
        public IList<IList<Measurement>> Group(List<Measurement> measurements)
        {
            var result = new List<IList<Measurement>>();
            result.Add(measurements);
            return result;
        }
    }
}
