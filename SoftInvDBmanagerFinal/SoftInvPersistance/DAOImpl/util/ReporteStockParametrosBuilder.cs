using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftInvPersistance.DAOImpl.util
{
    public class ReporteStockParametrosBuilder
    {

        private int? año;
        private int? mes;
        private int? almacenId;
        private int? productoId;

        public ReporteStockParametrosBuilder()
        {
            this.Año = null;
            this.Mes = null;
            this.AlmacenId = null;
            this.ProductoId = null;
        }

        public ReporteStockParametrosBuilder conAño(int año)
        {
            this.año = año;
            return this;
        }

        public ReporteStockParametrosBuilder conMes(int mes)
        {
            this.mes = mes;
            return this;
        }

        public ReporteStockParametrosBuilder conAlmacenId(int almacenId)
        {
            this.almacenId = almacenId;
            return this;
        }

        public ReporteStockParametrosBuilder conProductoId(int productoId)
        {
            this.productoId = productoId;
            return this;
        }

        public ReporteStockParametros BuilReporteStockParametros()
        {
            ReporteStockParametros parametros = new ReporteStockParametros();
            parametros.Año = this.Año;
            parametros.Mes = this.Mes;
            parametros.AlmacenId = this.AlmacenId;
            parametros.ProductoId = this.ProductoId;
            return parametros;
        }


        public int? Año { get => año; set => año = value; }
        public int? Mes { get => mes; set => mes = value; }
        public int? AlmacenId { get => almacenId; set => almacenId = value; }
        public int? ProductoId { get => productoId; set => productoId = value; }
    }
}
