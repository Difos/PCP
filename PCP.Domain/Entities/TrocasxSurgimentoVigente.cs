using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCP.Domain.Entities
{
    public class TrocasxSurgimentoVigente
    {
        public string Id { get; set; }
        public int Troca { get; set; }
        public int Surgimento { get; set; }
        public int Meta { get; set; }
    }
}
