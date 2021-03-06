
using System.ComponentModel.DataAnnotations;

namespace PCP.Site.ViewModels
{
    public class Disponibilidade_FisicaDto
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="Preencha o campo dia")]
        public string DIA { get; set; }
        //public DateTime CreatedAt { get; set; }
        public string TOTALVAGAO { get; set; }
        public string TEMPO_DISP { get; set; }
        public string TEMPO_IMOB { get; set; }
        public string TEMPO_OFICINA { get; set; }
        public string TEMPO_INTERCAMBIO { get; set; }
        public string TEMPO_CTR { get; set; }
        public string DF { get; set; }
        public string INDISP_TOTAL { get; set; }
        public string INDISP_OFICINA { get; set; }
        public string INDISP_CTR { get; set; }
    }
}