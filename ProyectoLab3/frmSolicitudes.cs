using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clases;
using System.Data.SqlClient;
namespace ProyectoLab3
{
    public partial class frmSolicitudes : Form
    {
        //zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz

        List<ModeloDetalleSolicitud> SolicitudesDesdeLaSucursal = new List<ModeloDetalleSolicitud>();
        List<ModeloDetalleSolicitud> SolicitudesParaLaSucursal = new List<ModeloDetalleSolicitud>();

        public frmSolicitudes()
        {
            InitializeComponent();

            int IdSession = clsConexion.SucursalSession;

            if (IdSession <= 0) { IdSession = 1; }

            dgvSolicitudes.DataSource = clsSolicitud.MisSolcitudesRecibidasVigentes(IdSession);
            dgvPeticiones.DataSource = clsSolicitud.MisSolcitudesRealizadasVigentes(IdSession);

            dgvDetalle.Columns.Add("cantidadFormateada", "Cantidad");


            DataTable vigente = clsSolicitud.MisSolcitudesRealizadasVigentes(IdSession);


            /*
            for (int i = 0; i< vigente.Rows.Count ; i++ )
            {
                dgvSolicitudes.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud((int)vigente.Rows[i][0]);            
            }*/

            //fechaFin ,estado, fechaInicio


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {

                clsSolicitud.aceptarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells[0].Value);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult dialogResult = MessageBox.Show("¿Quiere Rechazar la solicitud?", "Confirmar Accion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.Yes)
                {
                    clsSolicitud.rechazarSolicitud((int)dgvSolicitudes.SelectedRows[0].Cells["IdSolicitud"].Value);
                }
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void dgvPeticiones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int IdPeticion = (int)dgvPeticiones.SelectedRows[0].Cells[0].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdPeticion);
            }
            catch (Exception ex) { Console.Write(ex); }

        }

        private void dgvSolicitudes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmSolicitudes_Load(object sender, EventArgs e)
        {

        }

        private void dgvSolicitudes_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dgvDetalle.DataSource = null;

                int IdSolicitud = (int)dgvSolicitudes.SelectedRows[0].Cells[0].Value;

                dgvDetalle.DataSource = clsSolicitud.obtenerIngredientesDeSolicitud(IdSolicitud);

                formatearDetalle();
            }
            catch (Exception ex) { Console.Write(ex.Message); }
        }

        private void formatearDetalle()
        {
            dgvDetalle.Columns["cantidad"].Visible = false;


            foreach (DataGridViewRow r in dgvDetalle.Rows)
            {
                double cantidadSinFormato = Convert.ToDouble(r.Cells["cantidad"].Value);
                int unidades = 0;

                if (cantidadSinFormato > 500) { cantidadSinFormato /= 1000; }
                else unidades = (int)cantidadSinFormato;



                if (unidades > 0) r.Cells["cantidadFormateada"].Value = unidades + " Unidades";
                else r.Cells["cantidadFormateada"].Value = cantidadSinFormato + " Kg";

            }

        }

    }
}