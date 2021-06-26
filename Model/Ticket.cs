using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseBlazorAdmin.Model
{
    public class Ticket
    {
        public Guid id { get; set; }

        public int idConsultor { get; set; }

        public int TipoTicket { get; set; }

        public int Status { get; set; }

        public DateTime DT_Inclusao { get; set; }

        public DateTime DT_Vencimento { get; set; }

        public string Nomecliente { get; set; }
    }
}
