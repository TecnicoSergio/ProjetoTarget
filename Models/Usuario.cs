using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using ProjetoTarget.Controllers;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProjetoTarget.Models
{
    public class Usuario
    {
          
        
        //Atalho para propridade (PROP + TAB)
        public int Id { get; set; }
        public string Username { get; set; } = "Sergio";
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }
        
        public byte[] Foto { get; set; }
        public string Latitude { get; set; } = "12132132";
        public string Longitude { get; set; } = "12132132";
        public DateTime? DataAcesso { get; set; } //using System;

        [NotMapped] // using System.ComponentModel.DataAnnotations.Schema
        public string PasswordString { get; set; } = "12132132";
        
       /* [NotMapped]
        public List<Veiculo> veiculos { get; set; }*///using System.Collections.Generic;

        
    }
}
        
