using System.ComponentModel.DataAnnotations;

namespace MaskapaiAPI
{
    public class Maskapai
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        public string Nama { get; set; }
        [MaxLength(200)]
        public string Perusahaan { get; set; }
        public int JumlahKru { get; set; }
        public string Deskripsi { get; set; }

    }
}
