using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ProyectoFinal.Data;
using ProyectoFinal.Modelo;

namespace ProyectoFinal
{
    public partial class frmProyecto : Form
    {
        public frmProyecto()
        {
            InitializeComponent();
            
        }

        //objPersona.clsPersona Pers = new objPersona.clsPersona();

        

        private void frmProyecto_Load(object sender, EventArgs e)
        {
         
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            /*
            txtApellido.ReadOnly = false;
            txtNombre.ReadOnly = false;
            txtDireccion.ReadOnly = false;
            txtNacimiento.ReadOnly = false;
            txtOcupacion.ReadOnly = false;
            txtDNI.ReadOnly = false;
            txtEdad.ReadOnly = false;
            txtTelef.ReadOnly = false;
            txtProcedencia.ReadOnly = false;
            txtReferido.ReadOnly = false;
            dtpFNacimiento.Enabled = true;

            txtDiabetico.ReadOnly = false;
            txtHipertenso.ReadOnly = false;
            txtCardiacos.ReadOnly = false;
            txtLagrimeo.ReadOnly = false;
            txtOtros.ReadOnly = false;
            txtAlergico.ReadOnly = false;
            txtMedicamentos.ReadOnly = false;
            txtAnestesicos.ReadOnly = false;
            txtMedicamentosU.ReadOnly = false;
            txtParpadosOD.ReadOnly = false;
            txtParpadosOI.ReadOnly = false;
            txtViasOD.ReadOnly = false;
            txtViasOI.ReadOnly = false;
            txtConjuntivaOD.ReadOnly = false;
            txtConjuntivaOI.ReadOnly = false;
            txtCorneaOD.ReadOnly = false;
            txtCorneaOI.ReadOnly = false;
            txtIrisOD.ReadOnly = false;
            txtIrisOI.ReadOnly = false;
            txtCristalinoOD.ReadOnly = false;
            txtCristalinoOI.ReadOnly = false;
            txtVitreoOD.ReadOnly = false;
            txtVitreoOI.ReadOnly = false;
            txtRetinaOD.ReadOnly = false;
            txtRetinaOI.ReadOnly = false;
            txtFondoOD.ReadOnly = false;
            txtODSC.ReadOnly = false;
            txtODCC.ReadOnly = false;
            txtODAE.ReadOnly = false;
            txtODPio.ReadOnly = false;
            txtOISC.ReadOnly = false;
            txtOICC.ReadOnly = false;
            txtODAE.ReadOnly = false;
            txtODPio.ReadOnly = false;
            txtReOD.ReadOnly = false;
            txtReOI.ReadOnly = false;
            txtADD.ReadOnly = false;
            txtDIP.ReadOnly = false;
            txtKAOD.ReadOnly = false;
            txtKAOI.ReadOnly = false;
            txtBIOD.ReadOnly = false;
            txtBIOI.ReadOnly = false;
            txtFondoOI.ReadOnly = false;
            txtDiagnostico.ReadOnly = false;
            txtTratamiento.ReadOnly = false;
            txtMedico.ReadOnly = false;
            dtpFecha.Enabled = true;
            ckbDolor.Enabled = true;
            ckbORojo.Enabled = true;
            ckbDisminuciónV.Enabled = true;
            ckbVisionD.Enabled = true;
            ckbOtros.Enabled = true;


            btnRegistrar.Enabled = true;
            btnNuevo.Enabled = true;


            txtApellido.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNacimiento.Clear();
            txtOcupacion.Clear();
            txtDNI.Clear();
            txtEdad.Clear();
            txtTelef.Clear();
            txtProcedencia.Clear();
            txtReferido.Clear();
            dtpFNacimiento.Value = DateTime.Now;
            txtCodigo.Clear();
            txtDiabetico.Clear();
            txtHipertenso.Clear();
            txtCardiacos.Clear();
            txtLagrimeo.Clear();
            txtOtros.Clear();
            txtAlergico.Clear();
            txtMedicamentos.Clear();
            txtAnestesicos.Clear();
            txtMedicamentosU.Clear();
            txtParpadosOD.Clear();
            txtParpadosOI.Clear();
            txtViasOD.Clear();
            txtViasOI.Clear();
            txtConjuntivaOD.Clear();
            txtConjuntivaOI.Clear();
            txtCorneaOD.Clear();
            txtCorneaOI.Clear();
            txtIrisOD.Clear();
            txtIrisOI.Clear();
            txtCristalinoOD.Clear();
            txtCristalinoOI.Clear();
            txtVitreoOD.Clear();
            txtVitreoOI.Clear();
            txtRetinaOD.Clear();
            txtRetinaOI.Clear();
            txtFondoOD.Clear();
            txtODSC.Clear();
            txtODCC.Clear();
            txtODAE.Clear();
            txtODPio.Clear();
            txtOISC.Clear();
            txtOICC.Clear();
            txtODAE.Clear();
            txtODPio.Clear();
            txtReOD.Clear();
            txtReOI.Clear();
            txtADD.Clear();
            txtDIP.Clear();
            txtKAOD.Clear();
            txtKAOI.Clear();
            txtBIOD.Clear();
            txtBIOI.Clear();
            txtFondoOI.Clear();
            txtDiagnostico.Clear();
            txtTratamiento.Clear();
            txtMedico.Clear();
            dtpFecha.Value = DateTime.Now;
            ckbDolor.Checked = false;
            ckbORojo.Checked = false;
            ckbDisminuciónV.Checked = false;
            ckbVisionD.Checked = false;
            ckbOtros.Checked = false;
            */
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            insertarPersona();
            
        }
        private void insertarPersona()
        {
            dtPersonal dtPersona = new dtPersonal();
            mdPersonal mdPersona = new mdPersonal();
            try
            {
                dtPersona.CodPersona = txtCodPersonal.Text;
                dtPersona.Dni = txtDNI.Text;
                dtPersona.Edad= Convert.ToInt32(txtEdad.Text);
                dtPersona.Telefono=txtTelef.Text;
                dtPersona.Apellido = txtApellido.Text;
                dtPersona.Nombre = txtNombre.Text;
                dtPersona.Direccion = txtDireccion.Text;
                dtPersona.LNacimiento = txtNacimiento.Text;
                dtPersona.Ocupacion = txtOcupacion.Text;
                dtPersona.Procedencia = txtProcedencia.Text;
                dtPersona.Referido = txtReferido.Text;
                dtPersona.FNacimiento = Convert.ToDateTime( dtpFNacimiento.Text);

                mdPersona.insertarPersona(dtPersona);
            }
           

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
    }

