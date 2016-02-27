using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CVGitCustom.Class;

namespace CVGitCustom.Models
{
    public class File
    {
        public int FileId { get; set; }
        [StringLength(255)]
        public string FileName { get; set; }
        [StringLength(100)]
        public string ContentType { get; set; }
        public byte[] Content { get; set; }
        public TypeOfFile FileType { get; set; }
        public int PersonId { get; set; }
        public virtual Annonce Annonce { get; set; }
    }
}
