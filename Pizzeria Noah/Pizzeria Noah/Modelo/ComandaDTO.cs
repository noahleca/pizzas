using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria_Noah.Modelo
{
    public class ComandaDTO
    {
        public int NumCda { get; set; }
        public DateTime? HoraCda { get; set; }
        public int QntIng { get; set; }
        public bool MassaFeta { get; set; }
        public int QntIngPosats { get; set; }
        public DateTime? HoraFinal { get; set; }

    }
}
