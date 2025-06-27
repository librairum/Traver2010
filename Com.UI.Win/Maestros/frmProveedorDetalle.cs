using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using Inv.BusinessEntities;
using Inv.BusinessLogic;
using Inv.BusinessEntities.DTO;

namespace Com.UI.Win
{
    public partial class frmProveedorDetalle : frmBaseMante
    {
        

        private static frmProveedorDetalle _aForm;
        private frmProveedor FrmParent { get; set; }

        public static frmProveedorDetalle Instance(frmProveedor padre) {
            if (_aForm != null) return new frmProveedorDetalle(padre);
            _aForm = new frmProveedorDetalle(padre);
            return _aForm;
        }

        GlobalLogic datosGlobal = GlobalLogic.Instance;
        CuentaCorrienteLogic datosCtacte = CuentaCorrienteLogic.Instance;
        public frmProveedorDetalle(frmProveedor padre)
        {
            InitializeComponent();
            FrmParent = padre;
            Util.ConfigGridToEnterNavigation(this.gridCuentasBancaria);
            gridCuentasBancaria.CellFormatting += new CellFormattingEventHandler(gridCuentasBancaria_CellFormatting);
            Util.seleccionatFilaCompleta(gridCuentasBancaria);
        }
        private void SeleccionTipoPersona() {
            
            txtRazonSocial.Enabled = false;
            txtNombres.Enabled = false;
            txtApPaterno.Enabled = false;
            txtApMaterno.Enabled = false;

            if (rbNatural.Checked) {
                txtNombres.Enabled = true;
                txtApPaterno.Enabled = true;
                txtApMaterno.Enabled = true;
            }
            else if (rbJuridica.Checked)
            {
                
                txtRazonSocial.Enabled = true;
            }
            else {
                txtRazonSocial.Enabled = true;
            }
        }
        private void CargarCliente() {
            
                GridViewRowInfo fila = FrmParent.gridControl.MasterView.CurrentRow;

                

                txttipdoc.Text = Util.GetCurrentCellText(fila, "ccm02tipana");
                lbltipdoc.Text = Util.GetCurrentCellText(fila, "ccm02cod");
                txtRazonSocial.Text = Util.GetCurrentCellText(fila, "ccm02nom");
                txtDireccion.Text = Util.GetCurrentCellText(fila, "ccm02dir");
                txtTelefono.Text = Util.GetCurrentCellText(fila, "ccm02tel");
                 // Util.GetCurrentCellText(fila, "ccm02tel") == "N": ;
                
                dtpFechaRegistro.Text = Util.GetCurrentCellText(fila, "ccm02fec");
                txtRuc.Text = Util.GetCurrentCellText(fila, "ccm02ruc");
                txtFax.Text = Util.GetCurrentCellText(fila, "ccm02Fax");
                txtCorreoEmail.Text = Util.GetCurrentCellText(fila, "ccm02correo");
                txtCorreoDocEletronico.Text = Util.GetCurrentCellText(fila, "ccm02CorreoFacturaElectronica");
                txtRubroVentas.Text = Util.GetCurrentCellText(fila, "ccm02rubpro");
                txtAtencion.Text = Util.GetCurrentCellText(fila, "ccm02Aten");

                
                string descripcion = "";

                txtEstadoSunatCod.Text = Util.GetCurrentCellText(fila, "ccm02EstadoContribuyente");
                datosGlobal.DameDescripcionCompras("07"+txtEstadoSunatCod.Text.Trim(), "GL", out descripcion);
                txtEstadoSunatDesc.Text = descripcion;

                descripcion = "";
                txtFormaPagoCod.Text = Util.GetCurrentCellText(fila, "ccm02ForPag");
                datosGlobal.DameDescripcionCompras(Logueo.CodigoEmpresa + txtFormaPagoCod.Text.Trim(), "FORPAG", out descripcion);
                txtFormaPagoDesc.Text = descripcion;

                descripcion = "";
                txtDomicilioCod.Text = Util.GetCurrentCellText(fila, "ccm02SituacionDomicilio");
                datosGlobal.DameDescripcionCompras("08" + txtDomicilioCod.Text.Trim(), "GL", out descripcion);
                txtDomicilioDesc.Text = descripcion;

                descripcion = "";
                txtPaisCod.Text = Util.GetCurrentCellText(fila, "ccm02paiscodigo");
                datosGlobal.DameDescripcionCompras("04" + txtPaisCod.Text.Trim(), "GLO02", out descripcion);
                txtPaisDesc.Text = descripcion;

                string moneda = Util.GetCurrentCellText(fila, "ccm02Moneda");
                
                rbSoles.Checked = false; rbDolares.Checked = false;
                if (moneda == "S") {
                    rbSoles.Checked = true;
                }
                else if (moneda == "D") {
                    rbDolares.Checked = true;
                }

                string opciones = Util.GetCurrentCellText(fila, "ccm02TipoAgenteRetencion");
                if (opciones != "") {
                    chkAgenteCombustible.Checked = false; chkAgenteRetenedor.Checked = false;
                    chkAgenteVentaInterna.Checked = false; chkBuenContribuyente.Checked = false;

                    bool esAgenteretenedor = (opciones.Substring(0, 1) == "1");
                    bool esContribuyente = (opciones.Substring(1, 1) == "1");
                    bool esAgentePercepcionCombustible = (opciones.Substring(2, 1) == "1");
                    bool esAgentePercepcionVentaInterna = (opciones.Substring(3, 1) == "1");

                    chkAgenteCombustible.Checked = esAgentePercepcionCombustible;
                    chkAgenteRetenedor.Checked = esAgenteretenedor;
                    chkAgenteVentaInterna.Checked = esAgentePercepcionVentaInterna;
                    chkBuenContribuyente.Checked = esContribuyente;
           
                }

                string tipoRuc = Util.GetCurrentCellText(fila, "ccm02TipoRuc");
                if (tipoRuc == "1")
                {
                    rbNatural.Checked = true;
                    
                }
                else if (tipoRuc == "2")
                {
                    rbJuridica.Checked = true;
                    
                }
                else if (tipoRuc == "3")
                {
                    rbNoDomiciliado.Checked = true;
                }
                else
                {
                    rbNatural.Checked = false;
                    rbJuridica.Checked = false;
                    rbNoDomiciliado.Checked = false;
                }

                txtNombres.Text = Util.GetCurrentCellText(fila, "ccm02Nombres");
                txtApPaterno.Text = Util.GetCurrentCellText(fila, "ccm02ApePaterno");
                txtApMaterno.Text = Util.GetCurrentCellText(fila, "ccm02ApeMaterno");

                txtCtaBancoDetraccion.Text = Util.GetCurrentCellText(fila, "ccm02nroctadetraccion");
                
            txttipdoc.Text = Util.GetCurrentCellText(fila, "ccm02tipdocidentidad");

                string descripcion1 = "";
                GlobalLogic.Instance.ComprasDameDescripcion(Logueo.CodigoEmpresa, "05" + txttipdoc.Text, "GL", out descripcion1);
                lbltipdoc.Text = descripcion1;

        }

        private void ConfiguracionFormulario(FormEstate estado) {
            
            if (estado == FormEstate.New) {
                HabilitarControles(true);
                LimpiarDatos();
                IniciarDatos();
                OcultarBotones();
                
               // txttipdoc.Enabled = false;
                //txttipdoc.Text = "02";

                HabilitaBotonPorNombre(BaseRegBotones.cbbGuardar);
                HabilitaBotonPorNombre(BaseRegBotones.cbbCancelar);
            }
            else if (estado == FormEstate.Edit) {

                HabilitarControles(true);
                LimpiarDatos();
                txttipdoc.Enabled = false;
                lbltipdoc.Enabled = false;
                OcultarBotones();
                HabilitaBotonPorNombre(BaseRegBotones.cbbGuardar);
                HabilitaBotonPorNombre(BaseRegBotones.cbbCancelar);
                CargarCliente();
            }
            else if (estado == FormEstate.List) {
                HabilitarControles(false);
                LimpiarDatos();
                OcultarBotones();
                HabilitaBotonPorNombre(BaseRegBotones.cbbNuevo);
                HabilitaBotonPorNombre(BaseRegBotones.cbbEditar);
                HabilitaBotonPorNombre(BaseRegBotones.cbbEliminar);
                HabilitaBotonPorNombre(BaseRegBotones.cmdPrimero);
                HabilitaBotonPorNombre(BaseRegBotones.cmdAnterior);
                HabilitaBotonPorNombre(BaseRegBotones.cmdSiguiente);
                HabilitaBotonPorNombre(BaseRegBotones.cmdUltimo);                

            }else if (estado == FormEstate.View)
            {

                HabilitarControles(false);
                OcultarBotones();
                HabilitaBotonPorNombre(BaseRegBotones.cmdPrimero);
                HabilitaBotonPorNombre(BaseRegBotones.cmdAnterior);
                HabilitaBotonPorNombre(BaseRegBotones.cmdSiguiente);
                HabilitaBotonPorNombre(BaseRegBotones.cmdUltimo);
                HabilitaBotonPorNombre(BaseRegBotones.cbbCancelar);
                CargarCliente();
            }
        }
        private bool Validar() {
            
            if (lbltipdoc.Text.Trim() == "") {
                Util.ShowAlert("Ingrese Código de Cuenta Corriente");
                lbltipdoc.Focus();
                return false;
            }

            if (rbJuridica.Checked) {
                if (txtRazonSocial.Text == "") {
                    Util.ShowAlert("Ingresar nombre");
                    txtRazonSocial.Focus();
                    return false;
                }
            }
            else if (rbNatural.Checked) {

                if (txtNombres.Text == ""){
                    Util.ShowAlert("Ingresar nombres");
                    txtNombres.Focus();
                    return false;
                }

                if (txtApPaterno.Text == "") {
                    Util.ShowAlert("Ingresar Apellido Paterno");
                    txtApPaterno.Focus();
                    return false;
                }

                if(txtApMaterno.Text == "") {
                    Util.ShowAlert("Ingresar Apellido Materno");
                    txtApMaterno.Focus();
                    return false;
                }                
                
            }
            else if (rbNoDomiciliado.Checked)
            {

                if (txtRazonSocial.Text == "")
                {
                    Util.ShowAlert("Ingresar Nombre");
                    txtRazonSocial.Focus();
                    return false;
                }

            }
            
            if (txttipdoc.Text == "01" || txttipdoc.Text == "02") { 
                //si no es no domiciliado el tipo de persona
                if (rbNoDomiciliado.Checked == false) {
                    if (txtRuc.Text.Trim().Length < 11) {
                        Util.ShowAlert("El Ruc debe tener 11 digitos");
                        txtRuc.Focus();
                        return false;
                    }
                    long numeroRuc = 0;
                    //int.TryParse(txtRuc.Text, out numeroRuc);
                    //long.TryParse(txtRuc.Text, out numeroRuc);
                    long.TryParse(txtRuc.Text, out numeroRuc);
                    if (numeroRuc == 0) {
                        Util.ShowAlert("El valor ingresado no es numero");
                        txtRuc.Focus();
                        return false;
                    }
                }
            }


            if (txtEstadoSunatDesc.Text == "???") {
                Util.ShowAlert("Estado Proveedor No Valido");
                txtEstadoSunatCod.Focus();
                return false;
            }
            if (txtDomicilioDesc.Text == "???") {
                Util.ShowAlert("Domicilio No Valido");
                txtDomicilioCod.Focus();
                return false;
            }
            if (txtFormaPagoDesc.Text == "???") {
                Util.ShowAlert("Forma de Pago  No Valido");
                txtFormaPagoCod.Focus();
                return false;
            }

            if (txtPaisDesc.Text == "???") {
                Util.ShowAlert("Pais No Valido");
                txtPaisCod.Focus();
                return false;
            }
            
            return true;
           
        }
        private void frmProveedorDetalle_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Estado = FrmParent.Estado;
           
            ConfiguracionFormulario(Estado);
            Cursor.Current = Cursors.Default;
            crearColumnasCtabancaria();
            if (Estado == FormEstate.View || Estado == FormEstate.List)
            {
                cmdBarAgregar.Enabled = false;
            }
            
            cargarCtaBancaria(txtRuc.Text.Trim());
        }

        protected override void OnNuevo()
        {
                        
            lbltipdoc.Focus();
            Estado = FormEstate.New;
            ConfiguracionFormulario(Estado);
            //resaltar Ayuda
            Util.ResaltarAyuda(txttipdoc);
            Util.ResaltarAyuda(txtFormaPagoCod);
            Util.ResaltarAyuda(txtEstadoSunatCod);
            Util.ResaltarAyuda(txtDomicilioCod);
            Util.ResaltarAyuda(txtPaisCod);
        }

        protected override void OnEditar()
        {
            
            txttipdoc.Enabled = false;
            lbltipdoc.Enabled = false;
            txtFormaPagoCod.Focus();
            Estado = FormEstate.Edit;
            ConfiguracionFormulario(Estado);
            //resaltar Ayuda
            Util.ResaltarAyuda(txttipdoc);
            Util.ResaltarAyuda(txtFormaPagoCod);
            Util.ResaltarAyuda(txtEstadoSunatCod);
            Util.ResaltarAyuda(txtDomicilioCod);
            Util.ResaltarAyuda(txtPaisCod);
        }
        protected override void OnCancelar()
        {
            if (Estado == FormEstate.New) {
                if (FrmParent.gridControl.Rows.Count > 0)
                {
                    FrmParent.gridControl.MasterView.CurrentRow = FrmParent.gridControl.MasterView.Rows[0];
                }
                CargarCliente();
                HabilitarControles(false);
                Estado = FormEstate.View;
                OcultarBotones();
                HabilitaBotonPorNombre(BaseRegBotones.cbbNuevo);
                HabilitaBotonPorNombre(BaseRegBotones.cbbEditar);
                HabilitaBotonPorNombre(BaseRegBotones.cbbEliminar);
                HabilitaBotonPorNombre(BaseRegBotones.cmdPrimero);
                HabilitaBotonPorNombre(BaseRegBotones.cmdAnterior);
                HabilitaBotonPorNombre(BaseRegBotones.cmdSiguiente);
                HabilitaBotonPorNombre(BaseRegBotones.cmdUltimo);
            }
            else if (Estado == FormEstate.Edit) {
                CargarCliente();
                HabilitarControles(false);
                Estado = FormEstate.View;

                OcultarBotones();
                HabilitaBotonPorNombre(BaseRegBotones.cbbNuevo);
                HabilitaBotonPorNombre(BaseRegBotones.cbbEditar);
                HabilitaBotonPorNombre(BaseRegBotones.cbbEliminar);
                HabilitaBotonPorNombre(BaseRegBotones.cmdPrimero);
                HabilitaBotonPorNombre(BaseRegBotones.cmdAnterior);
                HabilitaBotonPorNombre(BaseRegBotones.cmdSiguiente);
                HabilitaBotonPorNombre(BaseRegBotones.cmdUltimo);
            }
            else if (Estado == FormEstate.View || Estado == FormEstate.List) {
                this.Close();
            }
            

      
        }

        protected override void OnPrimero()
        {
            int iIndice = 0;
            FrmParent.gridControl.MasterView.CurrentRow = FrmParent.gridControl.MasterView.Rows[iIndice];
            CargarCliente();
        }

        protected override void OnAnterior()
        {
            int iIndice = FrmParent.gridControl.MasterView.CurrentRow.Index - 1;
            if (iIndice < 0)
            {
                return;
            }
            FrmParent.gridControl.MasterView.CurrentRow = FrmParent.gridControl.MasterView.Rows[iIndice];
            CargarCliente();
        }

        protected override void OnSiguiente()
        {
            int iIndice = FrmParent.gridControl.MasterView.CurrentRow.Index + 1;
            if (iIndice > FrmParent.gridControl.MasterView.Rows.Count - 1)
            {
                return;
            }
            FrmParent.gridControl.MasterView.CurrentRow = FrmParent.gridControl.MasterView.Rows[iIndice];
            CargarCliente();
        }

        protected override void OnUltimo()
        {
            int iIndice = FrmParent.gridControl.MasterView.Rows.Count - 1;
            FrmParent.gridControl.MasterView.CurrentRow = FrmParent.gridControl.MasterView.Rows[iIndice];
            CargarCliente();
        }
        protected override void OnGuardar()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                if (Validar() == false) return;
                CuentaCorriente cta = new CuentaCorriente();
                cta.ccm02emp = Logueo.CodigoEmpresa;
                cta.ccm02tipana = Logueo.TipoAnalisisProveedor;
                cta.ccm02cod = txtRuc.Text.Trim();
                cta.ccm02dir = txtDireccion.Text.Trim();
                cta.ccm02tel = txtTelefono.Text.Trim();
                cta.ccm02fec = dtpFechaRegistro.Value;
                cta.ccm02ruc = txtRuc.Text.Trim();
                cta.ccm02fax = txtFax.Text.Trim();
                cta.ccm02rubpro = txtRubroVentas.Text.Trim();
                cta.ccm02Aten = txtAtencion.Text.Trim();

                if (rbSoles.Checked)
                {
                    cta.ccm02moneda = "S";
                }
                else if (rbDolares.Checked)
                {
                    cta.ccm02moneda = "D";
                }

                cta.Ccm02Forpag = txtFormaPagoCod.Text.Trim();
                cta.ccm02activo = "N";//estado por defecto, se puso N, por qeu significa N: No esta Inactivo
                cta.ccm02correo = txtCorreoEmail.Text.Trim();
                cta.ccm02CorreoFacturaElectronica = txtCorreoDocEletronico.Text.Trim();
      
                string opciones = "";
                if (chkAgenteRetenedor.Checked)
                {
                    opciones += "1";
                }
                else
                {
                    opciones += "0";
                }

                if (chkBuenContribuyente.Checked)
                {
                    opciones += "1";
                }
                else
                {
                    opciones += "0";
                }

                if (chkAgenteCombustible.Checked)
                {
                    opciones += "1";
                }
                else
                {
                    opciones += "0";
                }

                if (chkAgenteVentaInterna.Checked)
                {
                    opciones += "1";
                }
                else
                {
                    opciones += "0";
                }

                cta.ccm02TipoAgenteRetencion = opciones;

                string tipoRuc = "";
                if (rbNatural.Checked)
                {
                    tipoRuc = "1";
                }

                if (rbJuridica.Checked)
                {
                    tipoRuc = "2";
                }

                if (rbNoDomiciliado.Checked)
                {
                    tipoRuc = "3";
                }

                cta.ccm02TipoRuc = tipoRuc;
                cta.ccm02ApePaterno = txtApPaterno.Text.Trim();
                cta.ccm02ApeMaterno = txtApMaterno.Text.Trim();
                cta.ccm02Nombres = txtNombres.Text.Trim();

                if (tipoRuc == "1")
                {
                    cta.ccm02nom = txtApPaterno.Text.Trim() + " " + txtApMaterno.Text.Trim() + " " + txtNombres.Text.Trim();
                }
                else{
                    cta.ccm02nom = txtRazonSocial.Text.Trim();
                }

                cta.ccm02EstadoContribuyente = txtEstadoSunatCod.Text.Trim();
                cta.ccm02SituacionDomicilio = txtDomicilioCod.Text.Trim();
                cta.ccm02nroctadetraccion = txtCtaBancoDetraccion.Text.Trim();
                cta.ccm02FEPaisCod = txtPaisCod.Text.Trim();

                int flag = 0; string mensaje = "";
                if (Estado == FormEstate.New)
                {
                    datosCtacte.ComprasInsertarCuentaCorriente(cta, out flag, out mensaje);

                    Util.ShowMessage(mensaje, flag);
                    if (flag == 1)
                    {
                        Estado = FormEstate.List;
                        string codigoCliente = txtRuc.Text.Trim();
                        ConfiguracionFormulario(Estado);
                        
                        FrmParent.Cargar();
                        Util.enfocarFila(FrmParent.gridControl, "ccm02cod", codigoCliente);                       
                        CargarCliente();
                    }
                }
                else if (Estado == FormEstate.Edit)
                {
                    datosCtacte.ComprasActualizarCuentaCorriente(cta, out flag, out mensaje);

                    Util.ShowMessage(mensaje, flag);
                    if (flag == 1)
                    {
                        Estado = FormEstate.List;
                        //ConfiguracionFormulario(Estado);
                        
                        HabilitarControles(false);
                        string codigoCliente = txtRuc.Text.Trim();
                        FrmParent.Cargar();
                        Util.enfocarFila(FrmParent.gridControl, "ccm02cod", codigoCliente);
                        CargarCliente();
                        //botones 
                        OcultarBotones();
                        HabilitaBotonPorNombre(BaseRegBotones.cbbNuevo);
                        HabilitaBotonPorNombre(BaseRegBotones.cbbEditar);
                        HabilitaBotonPorNombre(BaseRegBotones.cbbEliminar);
                        HabilitaBotonPorNombre(BaseRegBotones.cmdPrimero);
                        HabilitaBotonPorNombre(BaseRegBotones.cmdAnterior);
                        HabilitaBotonPorNombre(BaseRegBotones.cmdSiguiente);
                        HabilitaBotonPorNombre(BaseRegBotones.cmdUltimo);
                    }
                }



            }
            catch (Exception ex)
            {
                Util.ShowAlert("Error al guardar");
            }
            Cursor.Current = Cursors.Default;
        }
        protected override void OnEliminar()
        {
            try
            {
                bool respuesta = Util.ShowQuestion("¿Desea eliminar el registro?");
                if (respuesta == false) return;

                Cursor.Current = Cursors.WaitCursor;

                int flag = 0; string mensaje = "";
                datosCtacte.ComprasEliminarCuentaCorriente(Logueo.CodigoEmpresa, txttipdoc.Text.Trim(),
                    lbltipdoc.Text.Trim(), out flag, out mensaje);
                Util.ShowMessage(mensaje, flag);
                if (flag == 1)
                {
                    FrmParent.Cargar();
                    this.Close();
                }
                Cursor.Current = Cursors.Default;
            }
            catch (Exception ex)
            {
                Util.ShowAlert("Error al elimianr");
            }
        }
        private void HabilitarControles(bool estado) {

            txttipdoc.Enabled = estado;
            lbltipdoc.Enabled = false;
            txtRuc.Enabled = estado;
            

            rbJuridica.Enabled = estado;
            rbNatural.Enabled = estado;
            rbNoDomiciliado.Enabled = estado;
            
            dtpFechaRegistro.Enabled = estado;

            txtFormaPagoCod.Enabled = estado;
            txtFormaPagoDesc.Enabled = false;

            rbSoles.Enabled = estado;
            rbDolares.Enabled = estado;

            txtRazonSocial.Enabled = estado;
            txtApPaterno.Enabled = estado;
            txtApMaterno.Enabled = estado;
            txtNombres.Enabled = estado;

            txtDireccion.Enabled = estado;

            txtPaisCod.Enabled = estado;
            txtPaisDesc.Enabled = false;

            txtEstadoSunatCod.Enabled = estado;
            txtEstadoSunatDesc.Enabled = false;

            txtDomicilioCod.Enabled = estado;
            txtDomicilioDesc.Enabled = false;
            
            txtAtencion.Enabled = estado;


            txtCorreoEmail.Enabled = estado;
            txtCorreoDocEletronico.Enabled = estado;
                                                                                   
            txtTelefono.Enabled = estado;
            txtFax.Enabled = estado;
            txtRubroVentas.Enabled = estado;
            
            chkAgenteCombustible.Enabled = estado;
            chkAgenteRetenedor.Enabled = estado;
            chkAgenteVentaInterna.Enabled = estado;
            chkBuenContribuyente.Enabled = estado;

            txtCtaBancoDetraccion.Enabled = estado;

        }
        private void IniciarDatos() {
            txttipdoc.Text = "";
            txtFormaPagoCod.Text = "04";
            rbSoles.Checked = true;
            txtEstadoSunatCod.Text = "01";
            txtDomicilioCod.Text = "01";
            
            //GlobalLoic DameDescripcionCompras(
            string descripcion = "";
            datosGlobal.DameDescripcionCompras(txttipdoc.Text.Trim(), "", out descripcion);
            lbltipdoc.Text = descripcion;
            
            //Formapago
            descripcion = "";
            datosGlobal.DameDescripcionCompras(Logueo.CodigoEmpresa + txtFormaPagoCod.Text.Trim(), "FORPAG", out descripcion);
            txtFormaPagoDesc.Text = descripcion;
            
            //Situacion Sunat
            descripcion = "";
            datosGlobal.DameDescripcionCompras("07"+txtEstadoSunatCod.Text.Trim(), "GL", out descripcion);
            txtEstadoSunatDesc.Text = descripcion;
            
            //Domicilio
            descripcion = "";
            datosGlobal.DameDescripcionCompras("08" + txtDomicilioCod.Text.Trim(), "GL", out descripcion);
            txtDomicilioDesc.Text = descripcion;
            
            //Pais
            descripcion = "";
            datosGlobal.DameDescripcionCompras("35" + txtPaisCod.Text.Trim(), "GLO02", out descripcion);
            txtPaisDesc.Text = descripcion;

            dtpFechaRegistro.Value = DateTime.Now;

            Util.ResaltarAyuda(txttipdoc);
            Util.ResaltarAyuda(txtFormaPagoCod);
            Util.ResaltarAyuda(txtEstadoSunatCod);
            Util.ResaltarAyuda(txtDomicilioCod);
            Util.ResaltarAyuda(txtPaisCod);
        }

        private void LimpiarDatos() {
            txttipdoc.Text = "";
            lbltipdoc.Text = "";
            txtRuc.Text = "";

            rbJuridica.Checked = false; rbNatural.Checked = false; rbNoDomiciliado.Checked = false;

            dtpFechaRegistro.Value = DateTime.Now;
            txtFormaPagoCod.Text = "";
            txtFormaPagoDesc.Text = "";

            rbSoles.Checked = false; rbDolares.Checked = false;

            txtRazonSocial.Text = "";
            txtApPaterno.Text = ""; txtApMaterno.Text = ""; txtNombres.Text = "";
            txtDireccion.Text = "";

            txtPaisCod.Text = ""; txtPaisDesc.Text = "";
            
            txtEstadoSunatCod.Text = ""; txtEstadoSunatDesc.Text = "";

            txtDomicilioCod.Text = ""; txtDomicilioDesc.Text = "";

            txtAtencion.Text = "";

            txtCorreoEmail.Text = "";
            txtCorreoDocEletronico.Text = "";

            txtTelefono.Text = ""; txtFax.Text = ""; txtRubroVentas.Text = "";

            chkAgenteCombustible.Checked = false; chkAgenteRetenedor.Checked = false;
            chkAgenteVentaInterna.Checked = false; chkBuenContribuyente.Checked = false;

            txtCtaBancoDetraccion.Text = "";            
        }

        private void TraerAyuda(enmAyuda tipo) {
            frmBusqueda frm;
            string[] datos;
            switch (tipo) { 
                case enmAyuda.enmCliente_FormaPago:
                    frm = new frmBusqueda(tipo);
                    frm.ShowDialog();
                    if (frm.Result == null) return;
                    if (frm.Result.ToString() == "") return;
                    datos = frm.Result.ToString().Split('|');
                    txtFormaPagoCod.Text = datos[0];
                    txtFormaPagoDesc.Text = datos[1];
                    break;
                case enmAyuda.enmCliente_SituacionSunat:
                    frm = new frmBusqueda(tipo);
                    frm.ShowDialog();
                    if (frm.Result == null) return;
                    if (frm.Result.ToString() == "") return;
                    datos = frm.Result.ToString().Split('|');
                    txtEstadoSunatCod.Text = datos[0];
                    txtEstadoSunatDesc.Text = datos[1];
                    break;
                case enmAyuda.enmCliente_Pais:
                    frm = new frmBusqueda(tipo);
                    frm.ShowDialog();
                    if (frm.Result == null) return;
                    if (frm.Result.ToString() == "") return;
                    datos = frm.Result.ToString().Split('|');
                    txtPaisCod.Text = datos[0];
                    txtPaisDesc.Text = datos[1];
                    break;
                case enmAyuda.enmCliente_SituacionDomi:
                    frm = new frmBusqueda(tipo);
                    frm.ShowDialog();
                    if (frm.Result == null) return;
                    if (frm.Result.ToString() == "") return;
                    datos = frm.Result.ToString().Split('|');
                    txtDomicilioCod.Text = datos[0];
                    txtDomicilioDesc.Text = datos[1];

                    break;
                case enmAyuda.enmCliente_TipoDoc:
                    frm = new frmBusqueda(tipo);
                    frm.ShowDialog();
                    if (frm.Result == null) return;
                    if (frm.Result.ToString() == "") return;
                    datos = frm.Result.ToString().Split('|');
                    txttipdoc.Text = datos[0];
                    lbltipdoc.Text = datos[1];
                    
                    //
                   if (txttipdoc.Text=="06")
                    {rbJuridica.Checked = true; }
                   else if (txttipdoc.Text=="01")
                    {rbNatural.Checked = true;}    
                   else 
                    {rbNoDomiciliado.Checked = true;}

                    break;
                default: 
                    break;
            }
        }

        private void txtPaisCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1) {
                TraerAyuda(enmAyuda.enmCliente_Pais);
            }
        }

        private void txtEstadoSunatCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                TraerAyuda(enmAyuda.enmCliente_SituacionSunat);
            }
        }

        private void txtDomicilioCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                TraerAyuda(enmAyuda.enmCliente_SituacionDomi);
            }
        }

        private void txtFormaPagoCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                TraerAyuda(enmAyuda.enmCliente_FormaPago);
            }
        }

        private void rbJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (Estado == FormEstate.List || Estado == FormEstate.View) return;
            SeleccionTipoPersona();
        }

        private void rbNatural_CheckedChanged(object sender, EventArgs e)
        {
            if (Estado == FormEstate.List || Estado == FormEstate.View) return;
            SeleccionTipoPersona();
        }

        private void rbNoDomiciliado_CheckedChanged(object sender, EventArgs e)
        {
            if (Estado == FormEstate.List || Estado == FormEstate.View) return;
            SeleccionTipoPersona();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            //if (lbltipdoc.Text.Trim().Length > 0) {
            //    txtRuc.Text = lbltipdoc.Text;
            //}
        }

       
        private void Guardar() {
           
        
        }

        private void txttipdoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.F1)
            {
                TraerAyuda(enmAyuda.enmCliente_TipoDoc);
            }
        }


        #region "mantenimiento cuenta bancaria"
        private void crearColumnasCtabancaria()
        {
            RadGridView Grid =  this.CreateGridVista(this.gridCuentasBancaria);
            CreateGridColumn(Grid, "ccm04emp", "ccm04emp", 0, "", 90, false, false, false, false);
            CreateGridColumn(Grid, "ccm04ctacod", "ccm04ctacod", 0, "", 90, false, false, false, false);
            CreateGridColumn(Grid, "nomnbreProveedor", "nomnbreProveedor", 0, "", 300,true, false, false);
            //tipo cuenta bancaria
            CreateGridColumn(Grid, "ccm04tipocuenta", "ccm04tipocuenta", 0, "", 90, false, true, false, false);
            CreateGridColumn(Grid, "TipoCuenta", "nombreTipoCuenta", 0, "", 90, true, false, true, false);
            

            //banco    
            CreateGridColumn(Grid, "Idbanco", "ccm04idbanco", 0, "", 90, false, true, false, false);
            CreateGridColumn(Grid, "nombreBanco", "nombreBanco", 0, "", 150,true, false, true, false);
            
            //tipo de analisis
            CreateGridColumn(Grid, "Tip.Analisi", "ccm04tipana", 0, "", 90, true, false, false, false);
            
            //moneda
            CreateGridColumn(Grid, "ccm04moneda", "ccm04moneda", 0, "", 90, false, false, false, false);
            CreateGridColumn(Grid, "moneda", "moneda", 0, "", 100, true, true, true, false);
            
            CreateGridColumn(Grid, "Nro.Cta", "ccm04idcuenta", 0, "", 150, false, true, true, false);
            CreateGridColumn(Grid, "CCI", "ccm04cci", 0, "", 150, false, true, true, false);
            //sugerir descripcion de la concatenacion nombrebanco  + tipo
            CreateGridColumn(Grid, "descripcion", "ccm04descripcion", 0, "", 200, false, true, true, false);
            
            CreateGridChkColumn(Grid, "ctaxdefecto", "ccm04ctadefecto", 0, "", 100, false, true);
            
            CreateGridColumn(Grid, "Cod.Oficina", "ccm04codigooficina", 0, "", 120, false, true, true, false);

            
            //CreateGridColumn(Grid, "ccm04ctadefecto", "ccm04ctadefecto", 0, "", 70, false, true, true, false);
            
            //CreateGridColumn(Grid, "ccm04ctadefecto", "ccm04ctadefecto", 0, "", 70, false, true);
            //CreateGridChkColumn(Grid, "ctaxdefecto", "ctaxdefecto", 0, "", 70, false, true);

            
            CreateGridColumn(Grid, "flag", "flag", 0, "", 90, false, true, false, false);
            CreateGridColumn(Grid, "flagBotones", "flagBotones", 0, "", 70, true, false, false);

            Util.AddButtonsToGrid(Grid);
            //Util.ResaltarAyuda(gridCuentasBancaria, "nombreBanco");
            //Util.ResaltarAyuda(gridCuentasBancaria, "nombreTipoCuenta");
            //Util.ResaltarAyuda(gridCuentasBancaria, "moneda");
            Util.ResaltarAyuda(gridCuentasBancaria.CurrentRow.Cells["moneda"]);


        }

        private void traerAyudaBanco() { 
            
        }
        private void nuevoCtabancaria()
        {
            
            GridViewRowInfo  fila = gridCuentasBancaria.CurrentRow;
            try
            {
                if (gridCuentasBancaria.Rows.Count > 0) {
                    if (gridCuentasBancaria.CurrentRow.Cells["flag"].Value != null) {
                        Util.ShowError("Debe completar el registro actual");
                        return;
                    }
                }
                this.gridCuentasBancaria.Rows.AddNew();
                Util.SetValueCurrentCellText(gridCuentasBancaria, "ccm04tipana", "02");
                Util.SetValueCurrentCellText(gridCuentasBancaria, "flag", "0");
                Util.SetValueCurrentCellText(gridCuentasBancaria, "flagBotones", "E");
                Util.SetValueCurrentCellText(gridCuentasBancaria, "ccm04emp", Logueo.CodigoEmpresa);
                Util.SetValueCurrentCellText(gridCuentasBancaria, "ccm04ctacod", txtRuc.Text);
                Util.SetValueCurrentCellText(gridCuentasBancaria, "nomnbreProveedor", txtRazonSocial.Text);
                /*
                 CreateGridColumn(Grid, "ccm04emp", "ccm04emp", 0, "", 90, false, false, false, false);
            CreateGridColumn(Grid, "ccm04ctacod", "ccm04ctacod", 0, "", 90, false, false, false, false);
            CreateGridColumn(Grid, "nomnbreProveedor", "nomnbreProveedor", 0, "", 300);
                 */

            }
            catch (Exception ex) {
                Util.ShowError("Error al agregar fila: " + ex.Message); 
            }

        }
        
        private void cancelarCtaBancaria() {
            try
            {
                cargarCtaBancaria(txtRuc.Text.Trim());
            }
            catch (Exception ex) {
                Util.ShowError("Error al cancelar: " + ex.Message);
            }
            
        }

        private void editaCtaBancaria() {
            try
            {
                Util.SetValueCurrentCellText(gridCuentasBancaria, "flag", "1");
                Util.SetValueCurrentCellText(gridCuentasBancaria, "flagBotones", "E");
            }
            catch (Exception ex) { 
            
            }
            
        }

        private void eliminaCtaBancaria() {
            //ProveedorCtaBco entidad = new ProveedorCtaBco();
            try
            {
                string codigoProveedor = txtRuc.Text;
                string idbanco = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04idbanco");
                string idcuenta = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04idcuenta");
                string tipAna = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04tipana");
                string tipoCuenta = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04tipocuenta");
                int flag = 0; string mensaje = "";
                CuentaCorrienteLogic.Instance.EliminaCtabancaria(Logueo.CodigoEmpresa,
                    codigoProveedor,idbanco, tipAna ,tipoCuenta,  idcuenta, out flag, out mensaje);
                



                Util.ShowMessage(mensaje, flag);
                if (flag == 1)
                {
                    cargarCtaBancaria(codigoProveedor);
                }
            }
            catch (Exception ex) {
                Util.ShowError("Error al eliminar:" + ex.Message);
            } 
            
            
        }
        private void guardarCtaBancaria() {
            try
            {
                ProveedorCtaBco entidad = new ProveedorCtaBco();
               
                entidad.ccm04emp = Logueo.CodigoEmpresa;
                entidad.ccm04ctacod = txtRuc.Text.Trim();
                entidad.ccm04idbanco = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04idbanco");
                entidad.ccm04descripcion = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04descripcion");
                entidad.ccm04codigooficina = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04codigooficina");
                entidad.ccm04tipana = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04tipana");
                entidad.ccm04idcuenta = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04idcuenta");
                entidad.ccm04cci = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04cci");
                entidad.ccm04tipocuenta = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04tipocuenta").Trim() ;
                string ctaxdefectoValor = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04ctadefecto");


                if (ctaxdefectoValor.Equals("1"))
                {
                    entidad.ccm04ctadefecto = "S";
                }
                else {
                    entidad.ccm04ctadefecto = "N";
                }
                //entidad.ccm04ctadefecto = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04ctadefecto");
                entidad.ccm04moneda = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04moneda");
                int flag = 0; string mensaje = "";
                string esNuevo = Util.GetCurrentCellText(gridCuentasBancaria.CurrentRow, "flag");
                if (esNuevo.Equals("0"))
                {
                    CuentaCorrienteLogic.Instance.InsertaCtaBancaria(entidad, out flag, out mensaje);
                    Util.ShowMessage(mensaje, flag);
                }
                else
                {
                    CuentaCorrienteLogic.Instance.ActualizaCtaBancaria(entidad, out flag, out mensaje);
                    Util.ShowMessage(mensaje, flag);
                }
                
                
                //entidad.ccm04cci
                //entidad.ccm04ctadefecto
                //    entidad.ccm04moneda
                cargarCtaBancaria(entidad.ccm04ctacod);
            }
            catch (Exception ex) {
                Util.ShowError("Error en :" + ex.Message);
            }
            
        }
        private void cargarCtaBancaria(string codigoProveedor) {
            try
            {
                List<TraeProveedorCtaBco> lista =  CuentaCorrienteLogic.Instance.TraeProveedorCtaBco(Logueo.CodigoEmpresa, codigoProveedor);
                this.gridCuentasBancaria.DataSource = lista;
            }
            catch (Exception ex) {
                Util.ShowError(ex.Message);
            }
        }
        #endregion

        private void gridCuentasBancaria_KeyDown(object sender, KeyEventArgs e)
        {
            bool esSeleccionadoMoneda = Util.IsCurrentColumn(gridCuentasBancaria.CurrentColumn, "moneda");
            bool esSeleccionadoBanco = Util.IsCurrentColumn(gridCuentasBancaria.CurrentColumn, "nombreBanco");
            bool esSeleccionadoTipoCuenta = Util.IsCurrentColumn(gridCuentasBancaria.CurrentColumn, "nombreTipoCuenta");
            if (e.KeyValue != (char)Keys.F1) return;
            if (esSeleccionadoBanco)
            {


                
                frmBusqueda frm = new frmBusqueda(enmAyuda.enmEntidadBancaria);
                frm.ShowDialog();


                if (frm.Result != null)
                {

                    if (frm.Result.ToString() == "") return;

                    string[] datos = frm.Result.ToString().Split('|');
                    GridViewRowInfo fila = this.gridCuentasBancaria.CurrentRow;
                    Util.SetValueCurrentCellText(fila, "ccm04idbanco", datos[0]);
                    Util.SetValueCurrentCellText(fila, "nombreBanco", datos[1]);

                }

            }
            else if (esSeleccionadoMoneda) {

                frmBusqueda frm = new frmBusqueda(enmAyuda.enmMoneda);
                frm.ShowDialog();
                if (frm.Result != null)
                {

                    if (frm.Result.ToString() == "") return;

                    string[] datos = frm.Result.ToString().Split('|');
                    GridViewRowInfo fila = this.gridCuentasBancaria.CurrentRow;
                    Util.SetValueCurrentCellText(fila, "ccm04moneda", datos[0]);
                    Util.SetValueCurrentCellText(fila, "moneda", datos[1]);

                }
            }
            else if (esSeleccionadoTipoCuenta) {
                frmBusqueda frm = new frmBusqueda(enmAyuda.enmTipoCuentaBancaria);
                frm.ShowDialog();
                if (frm.Result != null) {
                    if (frm.Result.ToString() == "") return;
                    string[] datos = frm.Result.ToString().Split('|');
                    GridViewRowInfo fila = this.gridCuentasBancaria.CurrentRow;
                    Util.SetValueCurrentCellText(fila, "ccm04tipocuenta", datos[0]);
                    Util.SetValueCurrentCellText(fila, "nombreTipoCuenta", datos[1]);
                }
            }



            

        }
        bool esNuevo = false;
        private void cmdBarAgregar_Click(object sender, EventArgs e)
        {
            //esNuevo = true;
            //gridCuentasBancaria.Rows.AddNew();
            //GridViewRowInfo row = gridCuentasBancaria.CurrentRow;
            nuevoCtabancaria();
            Util.ResaltarAyuda(gridCuentasBancaria.CurrentRow.Cells["nombreTipoCuenta"]);
            Util.ResaltarAyuda(gridCuentasBancaria.CurrentRow.Cells["nombreBanco"]);
            Util.ResaltarAyuda(gridCuentasBancaria.CurrentRow.Cells["moneda"]);
            
        }

        private void cmdBarEditar_Click(object sender, EventArgs e)
        {
            
        }

        private void gridCuentasBancaria_CellBeginEdit(object sender, GridViewCellCancelEventArgs e)
        {
            /*
             ccm04idcuenta	
ccm04cci	
ccm04ctadefecto	
ccm04descripcion	
ccm04codigooficina	
ccm04moneda
             */
            if (gridCuentasBancaria.Rows.Count == 0) return;
            if(e.Row!= null)
                if(Util.GetCurrentCellText(e.Row, "flag") == "")
                    e.Cancel = true;

        }



        private void deshabilitarBotonProdDet(string nombre, GridCommandCellElement CommandCell)
        {
            GridCommandCellElement cellElement = CommandCell;
            switch (nombre)
            {
                case "btnGrabarDet":

                    cellElement.CommandButton.Image = Properties.Resources.save_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = false;
                    break;
                case "btnCancelarDet":
                    cellElement.CommandButton.Image = Properties.Resources.cancel_disabled;

                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = false;
                    break;
                case "btnEliminarDet":
                    cellElement.CommandButton.Image = Properties.Resources.delete_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = false;
                    break;
                case "btnEditarDet":
                    cellElement.CommandButton.Image = Properties.Resources.edited_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = false;
                    break;
                default:
                    break;
            }

        }
        private void habilitarBotonProdDet(string nombre, GridCommandCellElement CommandCell,
            bool bGrabar, bool bCancelar, bool bEliminar, bool bEditar)
        {
            GridCommandCellElement cellElement = CommandCell;
            switch (nombre)
            {
                case "btnGrabarDet":
                    cellElement.CommandButton.Image = bGrabar ? Properties.Resources.save_enabled : Properties.Resources.save_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = bGrabar;
                    break;
                case "btnCancelarDet":
                    cellElement.CommandButton.Image = bCancelar ? Properties.Resources.cancel_enabled : Properties.Resources.cancel_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = bCancelar;
                    break;

                case "btnEliminarDet":
                    cellElement.CommandButton.Image = bEliminar ? Properties.Resources.delete_enabled : Properties.Resources.delete_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = bEliminar;
                    break;

                case "btnEditarDet":
                    cellElement.CommandButton.Image = bEditar ? Properties.Resources.edit_enabled : Properties.Resources.edited_disabled;
                    cellElement.CommandButton.ImageAlignment = ContentAlignment.MiddleCenter;
                    cellElement.CommandButton.Enabled = bEditar;
                    break;


                default:
                    break;
            }
        }


        private void gridCuentasBancaria_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            try
            {
                GridCommandCellElement cellElement = e.CellElement as GridCommandCellElement;
                if (cellElement == null) return;

                if (e.CellElement.ColumnInfo is GridViewCommandColumn)
                {

                    RadButtonElement commandButton = ((RadButtonElement)((GridCommandCellElement)e.CellElement).Children[0]);

                    if (Estado == FormEstate.View) { deshabilitarBotonProdDet(e.Column.Name, cellElement); return; }




                    //if (gridControl.Rows[e.RowIndex].Cells["Orden"].Value == null) return;
                    if (e.RowIndex == -1) return;

                    //AGREGA LAS IMAGENES A LOS BOTONES DENTRO DE LA GRILLA
                    if (gridCuentasBancaria.Rows[e.RowIndex].Cells["Flag"].Value == null)
                    { habilitarBotonProdDet(e.Column.Name, cellElement, false, false, true, true); }
                    else { habilitarBotonProdDet(e.Column.Name, cellElement, true, true, false, false); }


                }
            }
            catch (Exception ex)
            {
                //Util.ShowError(ex.Message);
            }

        }

        private void gridCuentasBancaria_CommandCellClick(object sender, EventArgs e)
        {
            if (this.gridCuentasBancaria.Columns["btnGrabarDet"].IsCurrent)
            {
                guardarCtaBancaria();
                
            }

            if (this.gridCuentasBancaria.Columns["btnEditarDet"].IsCurrent)
            {
                //editarDetProducto();
                editaCtaBancaria();
            }

            if (this.gridCuentasBancaria.Columns["btnEliminarDet"].IsCurrent)
            {
                //EliminarDetProducto();
                eliminaCtaBancaria();

            }

            if (this.gridCuentasBancaria.Columns["btnCancelarDet"].IsCurrent)
            {
                //cancelarDetProducto();
                cancelarCtaBancaria();
            }
        }

        private void gridCuentasBancaria_CellEndEdit(object sender, GridViewCellEventArgs e)
        {
            if (e.Column.Name.Equals("nombreTipoCuenta") |  e.Column.Name.Equals("nombreBanco") |
                e.Column.Name.Equals("moneda") | e.Column.Name.Equals("ccm04idcuenta") ) 
            {
                string nomTipCuenta = "", nomBanco = "", moneda = "", idcuenta = "";
                nomTipCuenta = Util.GetCurrentCellText(gridCuentasBancaria, "nombreTipoCuenta");
                nomBanco = Util.GetCurrentCellText(gridCuentasBancaria, "nombreBanco");
                moneda = Util.GetCurrentCellText(gridCuentasBancaria, "moneda");
                idcuenta = Util.GetCurrentCellText(gridCuentasBancaria, "ccm04idcuenta");

                Util.SetValueCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04descripcion", nomTipCuenta + " " + nomBanco + " " + moneda + " " + idcuenta);
                //Util.SetValueCurrentCellText(gridCuentasBancaria.CurrentRow, "ccm04descripcion", "");

            }
        }

        

    }
}
