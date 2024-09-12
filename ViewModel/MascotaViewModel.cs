using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarea3_DB.Models;

namespace Tarea3_DB.ViewModel
{
    public class MascotaViewModel
    {
        public Mascota FormMascota { get; set; }
        public IEnumerable<Mascota> ListMascota { get; set; }
    }
}