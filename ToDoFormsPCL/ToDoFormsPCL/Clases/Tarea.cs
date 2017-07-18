using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoFormsPCL.Clases
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        [MaxLength(150)]
        public string Nombre { get; set; }

        public DateTime Fecha { get; set; }

        public TimeSpan Hora { get; set; }

        public bool Completada { get; set; }
    }
}
