using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseBlazorAdmin.Model
{
    public class ClienteView
    {
        public int id { get; set; }

        //Dados Pessoais
        [Required(ErrorMessage = "O campo nome é obrigatório!")]
        public string Nome { get; set; }

        public DateTime DT_Nasc { get; set; }

        [Required(ErrorMessage = "O campo é CPF_CNPJ obrigatório!")]
        public string CPF_CNPJ { get; set; }

        [Required(ErrorMessage = "O campo é RG obrigatório!")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O campo é RG_Orgao_Emissor obrigatório!")]
        public string RG_Orgao_Emissor { get; set; }

        [Required(ErrorMessage = "O campo é Profissao obrigatório!")]
        public string Profissao { get; set; }

        [Required(ErrorMessage = "O campo é Nacionalidade obrigatório!")]
        public string Nacionalidade { get; set; }

        [Required(ErrorMessage = "O campo é Estado_Civil  obrigatório!")]
        public string Estado_Civil { get; set; }

        [Required(ErrorMessage = "O campo é Regime_de_Bensobrigatório!")]
        public string Regime_de_Bens { get; set; }

        [Required(ErrorMessage = "O campo éTelefone obrigatório!")]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo é email obrigatório!")]
        public string email { get; set; }

        public string Sexo { get; set; }


        //Dados endereços

        [Required(ErrorMessage = "O campo é Endereco_CEP obrigatório!")]
        public string Endereco_CEP { get; set; }

        [Required(ErrorMessage = "O campo é Endereco_Rua obrigatório!")]
        public string Endereco_Rua { get; set; }

        [Required(ErrorMessage = "O campo é  Endereco_Numeroobrigatório!")]
        public string Endereco_Numero { get; set; }

       
        public string Endereco_Complemento { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Endereco_Bairro { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Endereco_Cidade { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string Endereco_Estado { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CodBanco { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string CodAgencia { get; set; }

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public string NumConta { get; set; }

        
        public int TipoConta { get; set; }


        public string NomeFavorecido { get; set; }

     
        public string CPFFavorecido { get; set; }


        //Informaçoes de contrato

        [Required(ErrorMessage = "O campo é obrigatório!")]
        public double ValorContrato { get; set; }


       
        public int PrazoContrato { get; set; }

     
        public int TipoEntrega { get; set; }

      
        public string Tipo_Doc_Identificacao { get; set; }

      
        public string Foto_Doc_Identificacao { get; set; }


        //Dados diversos

        public int idAcesso { get; set; }
      
        public int idConsultor { get; set; }

        public string Status { get; set; }
    }
}
