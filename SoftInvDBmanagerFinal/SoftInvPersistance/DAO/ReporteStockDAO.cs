using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftInv.Model;

namespace SoftInvPersistance.DAO
{
    public interface ReporteStockDAO
    {

         BindingList<ReportesStocksDTO> listarPorPeriodo(int anio, int mes, int almacenId,int productoId);

         void insertarDatosDePrueba();

         void eliminarDatosDePrueba();

         void generarReporteStock(int año, int mes);



    }
}
