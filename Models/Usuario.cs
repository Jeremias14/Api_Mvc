using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api_Mvc.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nombre  { get; set; }
        public string? Email {get; set; }
        public string? Password {get; set; }
        public DateTime FechaDealta {get; set; }
        public bool Activo {get; set; }
        public byte[]? PasswordHash {get; set; }
        public byte[]? PasswordSalt {get; set; }
    }
}