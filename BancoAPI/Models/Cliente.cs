using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BancoAPI.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Conta = new HashSet<Contum>();
        }

        [Required(ErrorMessage ="Código do Cliente é obrigatório!")]
        public int CodCli { get; set; }


        [Required(ErrorMessage = "Código do Tipo Cliente é obrigatório!")]
        public int CodTipoCli { get; set; }


        [Required(ErrorMessage = "Nome do Cliente é obrigatório!")]
        [MaxLength(100,ErrorMessage ="O tamanho máximo para o Nome do Cliente é de 100 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "Data de Nascimento/Fundação do Cliente é obrigatório!")]
        public DateTime DataNascFund { get; set; }


        [Required(ErrorMessage = "A Renda/Lucro do Cliente é obrigatório!")]
        public decimal RendaLucro { get; set; }


        [MaxLength(1, ErrorMessage = "O tamanho máximo para o Sexo do Cliente é de 1 caracter")]
        public string Sexo { get; set; }



        [Required(ErrorMessage = "Email do Cliente é obrigatório!")]
        [MaxLength(50, ErrorMessage = "O tamanho máximo para o Email do Cliente é de 50 caracteres")]
        public string Email { get; set; }



        [Required(ErrorMessage = "Endereço do Cliente é obrigatório!")]
        [MaxLength(200, ErrorMessage = "O tamanho máximo para o Endereço do Cliente é de 200 caracteres")]
        public string Endereco { get; set; }



        [Required(ErrorMessage = "Documento do Cliente é obrigatório!")]
        [MaxLength(18, ErrorMessage = "O tamanho máximo para o Documento do Cliente é de 18 caracteres")]
        public string Documento { get; set; }

        [MaxLength(50, ErrorMessage = "O tamanho máximo para o Tipo de Empresa é de 50 caracteres")]
        public string TipoEmpresa { get; set; }

        public virtual TipoCli CodTipoCliNavigation { get; set; }
        public virtual ICollection<Contum> Conta { get; set; }
    }
}
