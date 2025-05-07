using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftInv.DAOImpl;
using SoftInv.DAOImpl.Util;
using SoftInv.DAO;
using SoftInv.Model;
using SoftInvPersistance.DAO;
using System.ComponentModel;
using SoftInvPersistance.DAOImpl.util;

namespace SoftInvPersistance.DAOImpl
{
    public class ReporteStockDAOImpl : DAOImplBase, ReporteStockDAO
    {

        private ReportesStocksDTO reporte;



        public ReporteStockDAOImpl() : base("INV_REPORTES_STOCKS")
        {

        }


        protected override void ConfigurarListaDeColumnas()
        {
            // No se requiere configurar columnas para este DAO
        }

        public  void insertarDatosDePrueba()
        {
            // Implementar la lógica para insertar datos de prueba en la tabla INV_REPORTES_STOCKS
            // Esto podría incluir la creación de instancias de ReportesStocksDTO y su inserción en la base de datos
            string sql = "SP_INV_INSERTAR_DATOS_PRUEBA_REPORTE_STOCK";
            Boolean conTransaccion = true;
            this.EjecutarProcedimientoAlmacenado(sql, conTransaccion);
        }

        public  void eliminarDatosDePrueba()
        {
            // Implementar la lógica para insertar datos de prueba en la tabla INV_REPORTES_STOCKS
            // Esto podría incluir la creación de instancias de ReportesStocksDTO y su inserción en la base de datos
            String sql = "SP_INV_ELIMINAR_DATOS_PRUEBA_REPORTE_STOCK";
            Boolean conTransaccion = true;
            this.EjecutarProcedimientoAlmacenado(sql, conTransaccion);
        }

        public void generarReporteStock(int año, int mes)
        {
            // Construir parámetros
            object parametros = new ReporteStockParametrosBuilder()
                .conAño(año)
                .conMes(mes)
                .BuilReporteStockParametros();

            // Solo el nombre del procedimiento, sin {call ...}
            string sql = "SP_INV_GENERAR_REPORTE_STOCK";
            bool conTransaccion = true;

            // Llama al procedimiento correctamente con tipo almacenado
            this.EjecutarProcedimientoAlmacenado(sql, this.incluirValorDeParametrosParaGenerarReporteStock, parametros, conTransaccion);
        }

        private void incluirValorDeParametrosParaGenerarReporteStock(object objetoParametros)
        {
            ReporteStockParametros parametros = (ReporteStockParametros)objetoParametros;
            try
            {
                var parameter1 = this.comando.CreateParameter();
                parameter1.ParameterName = "p_anho"; // Usa el nombre real en el SP si aplica
                parameter1.Value = parametros.Año ?? (object)DBNull.Value;
                this.comando.Parameters.Add(parameter1);

                var parameter2 = this.comando.CreateParameter();
                parameter2.ParameterName = "p_mes"; // Usa el nombre real en el SP si aplica
                parameter2.Value = parametros.Mes ?? (object)DBNull.Value;
                this.comando.Parameters.Add(parameter2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al incluir parámetros: " + ex.Message);
            }
        }




        public BindingList<ReportesStocksDTO> listarPorPeriodo(int año, int mes, int almacenId, int productoId)
        {
            throw new NotSupportedException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
        }



    }
}
