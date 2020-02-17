using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeFantazia { get; set; }
        public string CNPJ { get; set; }
        public string Endereco { get; set; }
        public string CEP { get; set; }
        public string Telefone { get; set; }
        public string Telefone1 { get; set; }
        public string Celular { get; set; }
        public string Observacao { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Contato { get; set; }
        public string IscricaoEstadual { get; set; }
        public string Email { get; set; }
        public bool Boleto { get; set; }

    }
}
