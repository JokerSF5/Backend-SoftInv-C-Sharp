using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftInvPersistance.DAOImpl.util
{
    public class ReporteStockParametros
    {
        private int? año;
        private int? mes;
        private int? almacenId;
        private int? productoId;

        public ReporteStockParametros()
        {
            this.Año = null;
            this.Mes = null;
            this.AlmacenId = null;
            this.ProductoId = null;
        }

        public int? Año { get => año; set => año = value; }
        public int? Mes { get => mes; set => mes = value; }
        public int? AlmacenId { get => almacenId; set => almacenId = value; }
        public int? ProductoId { get => productoId; set => productoId = value; }
    }
}
