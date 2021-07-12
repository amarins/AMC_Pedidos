using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseBlazorAdmin.Model
{
    public class Cliente
    {
        public int id { get; set; }

        //Dados Pessoais
        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu nome completo!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório, Preencha a sua data de nascimento!")]
        public DateTime DT_Nasc { get; set; }

        [MaxLength(14)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu CPF ou CNPJ!")]
        public string CPF_CNPJ { get; set; }

        [MaxLength(14)]
        public string RG { get; set; }

        [MaxLength(20)]
        public string RG_Orgao_Emissor { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha a sua Profissão!")]
        public string Profissao { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha a sua Nacionalidade!")]
        public string Nacionalidade { get; set; }

        [MaxLength(40)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu Estado Civil!")]
        public string Estado_Civil { get; set; }

        [MaxLength(40)]
        public string Regime_de_Bens { get; set; }

        [MaxLength(15)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu Telefone!")]
        public string Telefone { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu Email!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu Sexo!")]
        public int Sexo { get; set; }


        //Dados endereços
        [MaxLength(9)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu CEP!")]
        public string Endereco_CEP { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha a sua Rua de sua Residência!")]
        public string Endereco_Rua { get; set; }

        [MaxLength(10)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o seu numero de sua Residência!")]
        public string Endereco_Numero { get; set; }

        [MaxLength(50)]
        public string Endereco_Complemento { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o Bairro de sua Residência!")]
        public string Endereco_Bairro { get; set; }

        [MaxLength(50)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha a Cidade de sua Residência!")]
        public string Endereco_Cidade { get; set; }

        [MaxLength(2)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha a Estado de sua Residência!")]
        public string Endereco_Estado { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o Codigo de Seu Banco!")]
        public string CodBanco { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o Codigo da Agencia de Seu Banco!")]
        public string CodAgencia { get; set; }

        [MaxLength(20)]
        [Required(ErrorMessage = "Campo Obrigatório, Preencha o Numero de sua Conta!")]
        public string NumConta { get; set; }

      
        public int TipoConta { get; set; }

        [MaxLength(50)]
        public string NomeFavorecido { get; set; }

        [MaxLength(14)]
        public string CPFFavorecido { get; set; }

        //Informaçoes de contrato

        [Required(ErrorMessage = "Campo Obrigatório, Preencha o Valor Inicial do Contrato!")]
        public double ValorContrato { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório, Selecione o Prazo desejado!")]
        public int PrazoContrato { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório, Selecione a forma de Entrega de seu Contrato !")]
        public int TipoEntrega { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório, Selecio o tipo de documento que sera enviado!")]
        public int Tipo_Doc_Identificacao { get; set; }

        [MaxLength(50)]
        public string Foto_Doc_Identificacao { get; set; }

        //Dados diversos
        public int idAcesso { get; set; }

        public int idConsultor { get; set; }

        public int Status { get; set; }


       

      
    }
}
