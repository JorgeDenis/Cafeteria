using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;

namespace Presentacion
{
    public partial class FrmTopVentas : Form
    {
        SqlConnection Conexion = new SqlConnection(@"Data Source=teamtechjb.database.windows.net;Initial Catalog=CAFETERIA;User ID=JorgeDenis;Password=JdBb101095;Connect Timeout=60;Encrypt=True;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmTopVentas()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {
            GrafCategorias();
        }


        private void GrafCategorias()
        {
            // Desvincular la serie actual
            chartProdCat.Series[0].Points.Clear();

            cmd = new SqlCommand("ProdPreferidos", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();

            List<string> ProductoNombres = new List<string>();
            List<int> CantidadVendida = new List<int>();

            while (dr.Read())
            {
                ProductoNombres.Add(dr.GetString(0));  // Nombre del producto en el índice 0
                CantidadVendida.Add(dr.GetInt32(1));    // Cantidad vendida en el índice 1
            }

            // Crear una nueva serie y enlazar los nuevos datos
            Series newSeries = new Series();
            newSeries.ChartType = SeriesChartType.Bar;  // Tipo de gráfico circular
            newSeries.Points.DataBindXY(ProductoNombres, CantidadVendida);


            // Cambiar la paleta de colores de la serie
            newSeries.Palette = ChartColorPalette.Chocolate;

            // Mostrar las cantidades vendidas en las rebanadas (series) con texto blanco
            foreach (DataPoint point in newSeries.Points)
            {
                point.IsValueShownAsLabel = true;
                point.LabelForeColor = Color.Black;  // Cambiar el color del texto a blanco
                point.Font = new Font("Arial", 12f, FontStyle.Regular);
                point.Label = "#VALY";  // Mostrar el valor Y (cantidad vendida) en la etiqueta
            }

            // Configurar las leyendas para mostrar los nombres de los productos
            chartProdCat.Series.Clear();
            chartProdCat.Series.Add(newSeries);
            chartProdCat.Legends[0].Enabled = false;  // Habilitar las leyendas
            chartProdCat.Series[0].LegendText = "#VALX: #VALY";  // Mostrar el nombre del producto y la cantidad en la leyenda

            chartProdCat.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje X
            chartProdCat.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje Y
            chartProdCat.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12f, FontStyle.Regular); // Cambia el tamaño de la fuente para los nombres de productos (12f) y el tipo de fuente según tus preferencias

            dr.Close();
            Conexion.Close();
        }

        private void btnDia_Click(object sender, EventArgs e)
        {
            // Desvincular la serie actual
            chartProdCat.Series[0].Points.Clear();

            cmd = new SqlCommand("ProcProductosDelDiaActual", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();

            List<string> ProductoNombres = new List<string>();
            List<int> CantidadVendida = new List<int>();

            while (dr.Read())
            {
                ProductoNombres.Add(dr.GetString(0));  // Nombre del producto en el índice 0
                CantidadVendida.Add(dr.GetInt32(1));    // Cantidad vendida en el índice 1
            }

            // Crear una nueva serie y enlazar los nuevos datos
            Series newSeries = new Series();
            newSeries.ChartType = SeriesChartType.Bar;  // Tipo de gráfico circular
            newSeries.Points.DataBindXY(ProductoNombres, CantidadVendida);


            // Cambiar la paleta de colores de la serie
            newSeries.Palette = ChartColorPalette.Chocolate;

            // Mostrar las cantidades vendidas en las rebanadas (series) con texto blanco
            foreach (DataPoint point in newSeries.Points)
            {
                point.IsValueShownAsLabel = true;
                point.LabelForeColor = Color.Black;  // Cambiar el color del texto a blanco
                point.Font = new Font("Arial", 12f, FontStyle.Regular);
                point.Label = "#VALY";  // Mostrar el valor Y (cantidad vendida) en la etiqueta
            }
            // Configurar las leyendas para mostrar los nombres de los productos
            chartProdCat.Series.Clear();
            chartProdCat.Series.Add(newSeries);
            chartProdCat.Legends[0].Enabled = false;  // Habilitar las leyendas
            chartProdCat.Series[0].LegendText = "#VALX: #VALY";  // Mostrar el nombre del producto y la cantidad en la leyenda

            chartProdCat.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje X
            chartProdCat.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje Y
            chartProdCat.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12f, FontStyle.Regular);

            dr.Close();
            Conexion.Close();

            this.btnDia.BackColor = Color.MediumSeaGreen;
            this.btnMes.BackColor = Color.FromArgb(217, 127, 48);
            this.btnAnio.BackColor = Color.FromArgb(217, 127, 48);
            this.lblPreferidos.Text = "PRODUCTOS PREFERIDOS DEL DÍA:";
        }

        private void btnMes_Click(object sender, EventArgs e)
        {
            // Desvincular la serie actual
            chartProdCat.Series[0].Points.Clear();

            cmd = new SqlCommand("ProcTopProductosDelMes", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();

            List<string> ProductoNombres = new List<string>();
            List<int> CantidadVendida = new List<int>();

            while (dr.Read())
            {
                ProductoNombres.Add(dr.GetString(0));  // Nombre del producto en el índice 0
                CantidadVendida.Add(dr.GetInt32(1));    // Cantidad vendida en el índice 1
            }

            // Crear una nueva serie y enlazar los nuevos datos
            Series newSeries = new Series();
            newSeries.ChartType = SeriesChartType.Bar;  // Tipo de gráfico circular
            newSeries.Points.DataBindXY(ProductoNombres, CantidadVendida);


            // Cambiar la paleta de colores de la serie
            newSeries.Palette = ChartColorPalette.Chocolate;

            // Mostrar las cantidades vendidas en las rebanadas (series) con texto blanco
            foreach (DataPoint point in newSeries.Points)
            {
                point.IsValueShownAsLabel = true;
                point.LabelForeColor = Color.Black;  // Cambiar el color del texto a blanco
                point.Font = new Font("Arial", 12f, FontStyle.Regular);
                point.Label = "#VALY";  // Mostrar el valor Y (cantidad vendida) en la etiqueta
            }
            // Configurar las leyendas para mostrar los nombres de los productos
            chartProdCat.Series.Clear();
            chartProdCat.Series.Add(newSeries);
            chartProdCat.Legends[0].Enabled = false;  // Habilitar las leyendas
            chartProdCat.Series[0].LegendText = "#VALX: #VALY";  // Mostrar el nombre del producto y la cantidad en la leyenda

            chartProdCat.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje X
            chartProdCat.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje Y
            chartProdCat.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12f, FontStyle.Regular);

            dr.Close();
            Conexion.Close();

            this.btnDia.BackColor = Color.FromArgb(217, 127, 48);
            this.btnMes.BackColor = Color.MediumSeaGreen;
            this.btnAnio.BackColor = Color.FromArgb(217, 127, 48);
            this.lblPreferidos.Text = "PRODUCTOS PREFERIDOS DEL MES:";
        }

        private void btnAnio_Click(object sender, EventArgs e)
        {
            // Desvincular la serie actual
            chartProdCat.Series[0].Points.Clear();

            cmd = new SqlCommand("ProcProductosDelAnoActual", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();

            List<string> ProductoNombres = new List<string>();
            List<int> CantidadVendida = new List<int>();

            while (dr.Read())
            {
                ProductoNombres.Add(dr.GetString(0));  // Nombre del producto en el índice 0
                CantidadVendida.Add(dr.GetInt32(1));    // Cantidad vendida en el índice 1
            }

            // Crear una nueva serie y enlazar los nuevos datos
            Series newSeries = new Series();
            newSeries.ChartType = SeriesChartType.Bar;  // Tipo de gráfico circular
            newSeries.Points.DataBindXY(ProductoNombres, CantidadVendida);


            // Cambiar la paleta de colores de la serie
            newSeries.Palette = ChartColorPalette.Chocolate;

            // Mostrar las cantidades vendidas en las rebanadas (series) con texto blanco
            foreach (DataPoint point in newSeries.Points)
            {
                point.IsValueShownAsLabel = true;
                point.LabelForeColor = Color.Black;  // Cambiar el color del texto a blanco
                point.Font = new Font("Arial", 12f, FontStyle.Regular);
                point.Label = "#VALY";  // Mostrar el valor Y (cantidad vendida) en la etiqueta
            }
            // Configurar las leyendas para mostrar los nombres de los productos
            chartProdCat.Series.Clear();
            chartProdCat.Series.Add(newSeries);
            chartProdCat.Legends[0].Enabled = false;  // Habilitar las leyendas
            chartProdCat.Series[0].LegendText = "#VALX: #VALY";  // Mostrar el nombre del producto y la cantidad en la leyenda

            chartProdCat.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje X
            chartProdCat.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje Y
            chartProdCat.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12f, FontStyle.Regular);

            dr.Close();
            Conexion.Close();

            this.btnDia.BackColor = Color.FromArgb(217, 127, 48);
            this.btnMes.BackColor = Color.FromArgb(217, 127, 48);
            this.btnAnio.BackColor = Color.MediumSeaGreen;
            this.lblPreferidos.Text = "PRODUCTOS PREFERIDOS DEL AÑO:";
        }

        private void dtpInicio_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void ObtenerProductosVendidosPorRangoDeFechas()
        {
            // Desvincular la serie actual
            chartProdCat.Series[0].Points.Clear();

            DateTime startDate = dtpInicio.Value;
            DateTime endDate = dtpFinal.Value;

            // Desvincular la serie actual
            chartProdCat.Series[0].Points.Clear();

            cmd = new SqlCommand("GetProductsSoldByDateRange", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@startDate", startDate);
            cmd.Parameters.AddWithValue("@endDate", endDate);
            Conexion.Open();
            dr = cmd.ExecuteReader();
            

            List<string> ProductoNombres = new List<string>();
            List<int> CantidadVendida = new List<int>();

            while (dr.Read())
            {
                ProductoNombres.Add(dr.GetString(0));  // Nombre del producto en el índice 0
                CantidadVendida.Add(dr.GetInt32(1));    // Cantidad vendida en el índice 1
            }

            // Crear una nueva serie y enlazar los nuevos datos
            Series newSeries = new Series();
            newSeries.ChartType = SeriesChartType.Bar;  // Tipo de gráfico circular
            newSeries.Points.DataBindXY(ProductoNombres, CantidadVendida);


            // Cambiar la paleta de colores de la serie
            newSeries.Palette = ChartColorPalette.Chocolate;

            // Mostrar las cantidades vendidas en las rebanadas (series) con texto blanco
            foreach (DataPoint point in newSeries.Points)
            {
                point.IsValueShownAsLabel = true;
                point.LabelForeColor = Color.Black;  // Cambiar el color del texto a blanco
                point.Font = new Font("Arial", 12f, FontStyle.Regular);
                point.Label = "#VALY";  // Mostrar el valor Y (cantidad vendida) en la etiqueta
            }

            // Configurar las leyendas para mostrar los nombres de los productos
            chartProdCat.Series.Clear();
            chartProdCat.Series.Add(newSeries);
            chartProdCat.Legends[0].Enabled = false;  // Habilitar las leyendas
            chartProdCat.Series[0].LegendText = "#VALX: #VALY";  // Mostrar el nombre del producto y la cantidad en la leyenda

            chartProdCat.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje X
            chartProdCat.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.White; // Cambia el color de la malla del eje Y
            chartProdCat.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Arial", 12f, FontStyle.Regular);

            dr.Close();
            Conexion.Close();

            string fechaInicioTexto = startDate.ToString("dd ' de ' MMMM ' de ' yyyy");
            string fechaFinalTexto = endDate.ToString("dd ' de ' MMMM ' de ' yyyy");

            this.lblPreferidos.Text = "PRODUCTOS PREFERIDOS ENTRE EL " + fechaInicioTexto.ToUpper()+" Y "+ fechaFinalTexto.ToUpper()+":";
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ObtenerProductosVendidosPorRangoDeFechas();
            this.btnDia.BackColor = Color.FromArgb(217, 127, 48);
            this.btnMes.BackColor = Color.FromArgb(217, 127, 48);
            this.btnAnio.BackColor = Color.FromArgb(217, 127, 48);
        }
    }
}
