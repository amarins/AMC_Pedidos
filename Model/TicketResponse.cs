using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseBlazorAdmin.Model
{
    public class TicketResponse
    {
        public bool Executado { get; set; }

        public string Menssagem { get; set; }

        public Ticket Ticket { get; set; }
    }
}
