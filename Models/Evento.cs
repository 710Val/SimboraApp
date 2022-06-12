using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Simbora04.Models
{
    [Table("Evento")]
    public class Evento
    {
		[Key]
		public int Id { get; set; }

		[Display(Name = "Nome")]
		[Required(ErrorMessage = "Obrigatório informar o nome do evento.")]
		public string Nome { get; set; }

		[Display(Name = "Data")]
		[Required(ErrorMessage = "Obrigatório informar a data do evento.")]
		public DateTime Data { get; set; }



		[Display(Name = "Horário")]
		[Required(ErrorMessage = "Obrigatório informar o horário do evento.")]
		public DateTime Horario { get; set; }

		[Display(Name = "Local")]
		[Required(ErrorMessage = "Obrigatório informar o local do evento.")]
		public string Local { get; set; }

		[Display(Name = "De graça?")]
		public string Degraca { get; set; }



	}
}
