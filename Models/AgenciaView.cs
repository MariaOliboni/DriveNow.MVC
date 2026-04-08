using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace DriveNow.MVC.Models
{
    public class AgenciaView
    {
        public int Id { get; set; }
        public string NomeFantasia { get; set; }
        public string Cep { get; set; }
        [BindNever]
        public string? Logradouro { get; set; }
        [BindNever]
        public string? Bairro { get; set; }
        [BindNever]
        public string? Localidade { get; set; }
        [BindNever]
        public string? Uf { get; set; }


    }
}
