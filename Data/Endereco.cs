using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace BaseBlazorAdmin.Data
{
    public class Endereco
    {
        public string street { get; set; }
        public string Cep { get; set; }
        public string neighborhood { get; set; }
        public string City { get; set; }
               
        public string state { get; set; }
    }
}