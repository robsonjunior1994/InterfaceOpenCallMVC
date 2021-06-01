using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceOpenCallMVC.ViewModel
{
    public class ChamadoViewModel
    {
        public int Id { get; set; }
        public string Protocolo { get; set; }
        public string Tipo { get; set; }
        public string Endereco { get; set; }
        public string Descricao { get; set; }
        public string Status { get; set; }
        public DateTime Data { get; set; }
        public int IdUser { get; set; }
        public bool Ativo { get; set; }
    }
}
