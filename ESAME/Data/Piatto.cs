using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ESAME.Data
{
    public class Piatto
    {
        /// <summary>
        /// Si Inserisci l'id come campo per poter accedere al dato id in banca dati
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Si inserisce il campo portata di tipo string per accedere al dato portata in banca dati
        /// </summary>
        
        [Required(ErrorMessage ="Devi inserire la portata!!")]
        public string portata { get; set; }

        /// <summary>
        /// Si inserisce il campo portata di tipo string per accedere al dato allergeni in banca dati
        /// </summary>
        /// 

        [Required(ErrorMessage = "Devi inserire gli allergeni!!")]
        public string allergeni { get; set; }

        /// <summary>
        /// Si inserisce il campo portata di tipo string per accedere al dato stagione in banca dati
        /// </summary>

        [Required(ErrorMessage = "Devi inserire la stagione!!")]
        public string stagione { get; set; }

        /// <summary>
        /// Si inserisce il campo portata di tipo string per accedere al dato prezzo in banca dati
        /// </summary>

        [Required(ErrorMessage = "Devi inserire il prezzo!!")]
        public float prezzo { get; set; }

        /// <summary>
        /// Si inserisce un ulteriore campo oltre a quello richiesto, per poter far esprimere al cliente anche un giudizio sul piatto
        /// </summary>
        public string note { get; set; }
    }
}
