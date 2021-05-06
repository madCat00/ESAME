using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ESAME.Data
{
    /// <summary>
    /// Si eredita dalla classe Dbcontext, quello che serve per poter effettuare la connessione al database
    /// </summary>
    public class BancaDati : DbContext

    {
        /// <summary>
        /// Si indicano quale è la classe per interfacciarsi con il db,(ovvero piatto in questo caso), e la tabella del database
        /// </summary>
        public DbSet<Piatto> piatti { get; set; }

        /// <summary>
        /// Infine si procede con la predisposizione della connessione vera e propria al nostro database
        /// </summary>
        /// <param name="options"></param>
        public BancaDati(DbContextOptions options) : base(options) { }
    }
}
