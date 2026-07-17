using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Inv.BusinessLogic;
using Inv.BusinessEntities;
using Telerik.WinControls.UI;
using System.Linq;
namespace Prod.UI.Win
{

    

    public partial class frmTrazabilidad : frmBaseReporte
    {

        public class ElementoMatriz
        {
            public int Id { get; set; }
            public int IdPadre { get; set; } // 0 si es un nodo raíz (Nivel 1)
            public string Nombre { get; set; }

            public ElementoMatriz(int id, int parentId, string nombre)
            {
                Id = id;
                IdPadre = parentId;
                Nombre = nombre;
            }
        }
        private frmMDI FrmParent { get; set; }        
        private static frmTrazabilidad _aForm;
        private bool nuevo_a, editar_a, eliminar_a, ver_a, imprimir_a, refrescar_a, importar_a, vista_a, guardar_a, cancelar_a,
            expmovi_a, importar_MP;
        CommandBarStripElement menu;
        RadCommandBarBaseItem cbbNuevo;
        RadCommandBarBaseItem cbbEditar;
        RadCommandBarBaseItem cbbEliminar;

        RadCommandBarBaseItem cbbVer;
        RadCommandBarBaseItem cbbVista;
        RadCommandBarBaseItem cbbImprimir;
        RadCommandBarBaseItem cbbRefrescar;
        RadCommandBarBaseItem cbbImportar;

        RadCommandBarBaseItem cbbGuardar;
        RadCommandBarBaseItem cbbCancelar;
                    
        private void ComportarmientoBotones(string accion)
        {

            switch (accion)
            {
                case "cargar":
                    if (cbbNuevo != null) cbbNuevo.Visibility = nuevo_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbEditar != null) cbbEditar.Visibility = editar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbEliminar != null) cbbEliminar.Visibility = eliminar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;

                    if (cbbVer != null) cbbVer.Visibility = ver_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbVista != null) cbbVista.Visibility = vista_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbImprimir != null) cbbImprimir.Visibility = imprimir_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbRefrescar != null) cbbRefrescar.Visibility = refrescar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbImportar != null) cbbImportar.Visibility = ElementVisibility.Collapsed;

                    if (cbbGuardar != null) cbbGuardar.Visibility = ElementVisibility.Collapsed;
                    if (cbbCancelar != null) cbbCancelar.Visibility = ElementVisibility.Collapsed;

                    break;
                case "nuevo":

                    if (cbbNuevo != null) cbbNuevo.Visibility = ElementVisibility.Collapsed;
                    if (cbbEditar != null) cbbEditar.Visibility = ElementVisibility.Collapsed;
                    if (cbbEliminar != null) cbbEliminar.Visibility = ElementVisibility.Collapsed;

                    if (cbbVer != null) cbbVer.Visibility = ElementVisibility.Collapsed;
                    if (cbbVista != null) cbbVista.Visibility = ElementVisibility.Collapsed;
                    if (cbbImprimir != null) cbbImprimir.Visibility = ElementVisibility.Collapsed;
                    if (cbbRefrescar != null) cbbRefrescar.Visibility = ElementVisibility.Collapsed;
                    if (cbbImportar != null) cbbImportar.Visibility = ElementVisibility.Collapsed;

                    if (cbbGuardar != null) cbbGuardar.Visibility = guardar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbCancelar != null) cbbCancelar.Visibility = cancelar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    break;
                case "editar":
                    if (cbbNuevo != null) cbbNuevo.Visibility = ElementVisibility.Collapsed;
                    if (cbbEditar != null) cbbEditar.Visibility = ElementVisibility.Collapsed;
                    if (cbbEliminar != null) cbbEliminar.Visibility = ElementVisibility.Collapsed;

                    if (cbbVer != null) cbbVer.Visibility = ElementVisibility.Collapsed;
                    if (cbbVista != null) cbbVista.Visibility = ElementVisibility.Collapsed;
                    if (cbbImprimir != null) cbbImprimir.Visibility = ElementVisibility.Collapsed;
                    if (cbbRefrescar != null) cbbRefrescar.Visibility = ElementVisibility.Collapsed;
                    if (cbbImportar != null) cbbImportar.Visibility = ElementVisibility.Collapsed;

                    if (cbbGuardar != null) cbbGuardar.Visibility = guardar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbCancelar != null) cbbCancelar.Visibility = cancelar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    break;
                case "grabar":
                    if (cbbNuevo != null) cbbNuevo.Visibility = nuevo_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbEditar != null) cbbEditar.Visibility = editar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbEliminar != null) cbbEliminar.Visibility = eliminar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;

                    if (cbbVer != null) cbbVer.Visibility = ElementVisibility.Collapsed;
                    if (cbbVista != null) cbbVista.Visibility = ElementVisibility.Collapsed;
                    if (cbbImprimir != null) cbbImprimir.Visibility = ElementVisibility.Collapsed;
                    if (cbbRefrescar != null) cbbRefrescar.Visibility = ElementVisibility.Collapsed;
                    if (cbbImportar != null) cbbImportar.Visibility = ElementVisibility.Collapsed;

                    if (cbbGuardar != null) cbbGuardar.Visibility = ElementVisibility.Collapsed;
                    if (cbbCancelar != null) cbbCancelar.Visibility = ElementVisibility.Collapsed;
                    break;
                case "cancelar":
                    if (cbbNuevo != null) cbbNuevo.Visibility = nuevo_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbEditar != null) cbbEditar.Visibility = editar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;
                    if (cbbEliminar != null) cbbEliminar.Visibility = eliminar_a ? ElementVisibility.Visible : ElementVisibility.Collapsed;

                    if (cbbVer != null) cbbVer.Visibility = ElementVisibility.Collapsed;
                    if (cbbVista != null) cbbVista.Visibility = ElementVisibility.Collapsed;
                    if (cbbImprimir != null) cbbImprimir.Visibility = ElementVisibility.Collapsed;
                    if (cbbRefrescar != null) cbbRefrescar.Visibility = ElementVisibility.Collapsed;
                    if (cbbImportar != null) cbbImportar.Visibility = ElementVisibility.Collapsed;

                    if (cbbGuardar != null) cbbGuardar.Visibility = ElementVisibility.Collapsed;
                    if (cbbCancelar != null) cbbCancelar.Visibility = ElementVisibility.Collapsed;
                    break;
            }

        }
        private void accesobtonesxperfil()
        {
            SegMenuPorPerfilLogic.Instance.asiganrpermisosxbotones(Logueo.codigoPerfil, Logueo.codModulo, this.Name, out nuevo_a,
                                                                    out editar_a, out eliminar_a, out ver_a, out imprimir_a,
                                                                     out refrescar_a, out importar_a, out vista_a,
                                                                    out guardar_a, out cancelar_a, out expmovi_a, out importar_MP);
        }
        public static frmTrazabilidad Instance(frmMDI mdiPrincipal) 
        {
            if (_aForm != null) return new frmTrazabilidad(mdiPrincipal);
            _aForm = new frmTrazabilidad(mdiPrincipal);
            return _aForm;
        }
        public frmTrazabilidad(frmMDI padre)
        {
            InitializeComponent();
            FrmParent = padre;


            ConfigurarGrid();
            ConfigurarJerarquia();

            menu = toolBar.CommandBarElement.Rows[0].Strips[0];

            cbbNuevo = menu.Items["cbbNuevo"];
            cbbEditar = menu.Items["cbbEditar"];
            cbbEliminar = menu.Items["cbbEliminar"];

            cbbVer = menu.Items["cbbVer"];
            cbbVista = menu.Items["cbbVista"];
            cbbImprimir = menu.Items["cbbImprimir"];
            cbbRefrescar = menu.Items["cbbRefrescar"];
            cbbImportar = menu.Items["cbbImportar"];

            cbbGuardar = menu.Items["cbbGuardar"];
            cbbCancelar = menu.Items["cbbCancelar"];

            accesobtonesxperfil();
            ComportarmientoBotones("cargar");
            //CargarTreeViewDesdeMatriz();
            
        }
        private void IniciarFormulario() {
            //rbPeriodo.CheckState = CheckState.Checked;
        }

        protected override void OnVista()
        {
            Cursor.Current = Cursors.WaitCursor;
            //string titulo = "";
            //string subtitulo = "";

            Reporte reporte = new Reporte("Documento");
            reporte.Ruta = Logueo.GetRutaReporte();
            ///SubTitulo = "Del  " + cboperiodosini.SelectedValue.ToString() + " Al " + cboperiodosfin.SelectedValue.ToString(); 
            DataTable datos = null;
            //titulo = "VALIDACIONES";
            Titulo = "Rendimiento";
            reporte.Nombre = "RptValidacionesCanastilla.rpt";
            
            datos = TipoDocumentoLogic.Instance.Spu_Pro_Rep_Validaciones(Logueo.CodigoEmpresa);
            reporte.DataSource = datos;
            reporte.FormulasFields.Add( new Formula("NombreEmpresa", Logueo.NombreEmpresa));
            reporte.FormulasFields.Add(new Formula("Anio", Logueo.Anio));
            reporte.FormulasFields.Add(new Formula("titulo", Titulo));
            //reporte.FormulasFields.Add( new Formula("subtitulo", subtitulo));
            ReporteControladora controles = new ReporteControladora(reporte);
            controles.VistaPrevia(enmWindowState.Normal);
            Cursor.Current = Cursors.Default;
        }
        

        /// <summary>
        /// Método recursivo que busca los hijos de un nodo y los añade a su colección.
        /// </summary>
        private void AgregarHijosRecursivos(TreeNode nodoPadre, List<ElementoMatriz> matriz)
        {
            // El ID del padre actual nos sirve para buscar quiénes apuntan a él
            int idPadreActual = (int)nodoPadre.Tag;

            // Buscamos en la matriz todos los elementos cuyo IdPadre coincida
            
            var hijos = matriz.Where(x => x.IdPadre == idPadreActual).ToList();

            foreach (var hijo in hijos)
            {
                TreeNode nuevoNodoHijo = new TreeNode(hijo.Nombre);
                nuevoNodoHijo.Tag = hijo.Id;

                // Volvemos a llamarse a sí mismo para buscar si este hijo tiene más hijos (Nivel 3, 4, etc.)
                AgregarHijosRecursivos(nuevoNodoHijo, matriz);

                // Añadimos el hijo al nodo padre actual
                nodoPadre.Nodes.Add(nuevoNodoHijo);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            CargarNivel1(txtOrdenTrabajo.Text.Trim(), txtNroCaja.Text.Trim());


            Cursor.Current = Cursors.Default;
           

        }

    

        private void cargarGrillaJerarquica() {

            //this.gridControl.AutoGenerateHierarchy = true;
        }

        
        private void frmTrazabilidad_Load(object sender, EventArgs e)
        {
            
            try
            {

                //this.gridCanastilla.RowSourceNeeded += new GridViewRowSourceNeededEventHandler(gridCanastilla_RowSourceNeeded);
                 
                
                //this.gridControl.DataSource = dt;
            }
            catch (Exception ex) {
                Util.ShowAlert("Erro al traer datos de trazabilidad canastila produccion");
            }

        }

       
        private void ConfigurarGrid()
        {
            RadGridView grillaCanastilla = CreateGrid(this.gridCanastilla);
            grillaCanastilla.AutoGenerateColumns = false;
            grillaCanastilla.Columns.Clear();

            CreateGridColumn(grillaCanastilla, "Actividad", "Actividad", 0, "", 100);
            CreateGridColumn(grillaCanastilla, "Fecha", "Fecha", 0, "", 100);
            CreateGridColumn(grillaCanastilla, "OT", "OT", 0, "", 70);
            CreateGridColumn(grillaCanastilla, "nroDoc", "nroDoc", 0, "", 80);
            CreateGridColumn(grillaCanastilla, "Caja", "Caja", 0, "", 60);
            CreateGridColumn(grillaCanastilla, "Pzas", "Pzas", 0, "", 60);
            CreateGridColumn(grillaCanastilla, "Producto", "Producto", 0, "", 250);
            CreateGridColumn(grillaCanastilla, "llaveIngreso", "llaveIngreso", 0, "", 60);
            
            
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("Actividad"));
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("Fecha"));
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("OT"));
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("nroDoc"));
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("Caja"));
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("Pzas"));
            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("Producto"));

            //grillaCanastilla.Columns.Add(new GridViewTextBoxColumn("llaveIngreso"));
            grillaCanastilla.Columns["llaveIngreso"].IsVisible = false;
            grillaCanastilla.AllowAddNewRow = false;
        }


        private void CargarNivel1(string nroOrdentrabajo, string nroCaja)
        {
            DataTable dt = DocumentoLogic.Instance.TraerCanastillaProdcuccionNivel1(
                Logueo.CodigoEmpresa, nroOrdentrabajo, nroCaja);

            gridCanastilla.DataSource = dt;
            // Limpiar antes de reconstruir la cadena de templates
            gridCanastilla.Templates.Clear();
            ConfigurarJerarquia();
       }


        private const int MAX_NIVELES_JERARQUIA = 10; // ajusta según el máximo real esperado
        private List<GridViewTemplate> templatesJerarquia = new List<GridViewTemplate>();

        private void ConfigurarJerarquia()
        {
            gridCanastilla.ViewCellFormatting += new CellFormattingEventHandler(gridCanastilla_ViewCellFormatting);
            gridCanastilla.ChildViewExpanding += new ChildViewExpandingEventHandler(gridCanastilla_ChildViewExpanding);

            templatesJerarquia.Clear();
            GridViewTemplate templateAnterior = null;

            for (int i = 0; i < MAX_NIVELES_JERARQUIA; i++)
            {
                GridViewTemplate nuevoTemplate = CrearTemplateNivel();
                templatesJerarquia.Add(nuevoTemplate);

                if (i == 0)
                {
                    // El primer template hijo cuelga directo del grid maestro
                    gridCanastilla.Templates.Add(nuevoTemplate);
                }
                else
                {
                    // Cada siguiente template cuelga del anterior (anidación real)
                    templateAnterior.Templates.Add(nuevoTemplate);
                }

                // Habilita la carga dinámica en CADA nivel
                nuevoTemplate.HierarchyDataProvider = new GridViewEventDataProvider(nuevoTemplate);

                templateAnterior = nuevoTemplate;
            }
        }
        private GridViewTemplate CrearTemplateNivel()
        {
            GridViewTemplate t = new GridViewTemplate();
            t.AutoGenerateColumns = false;
            //CreateGridColumn(t, "Actividad", "Actividad", 0, "", 100);
            t.Columns.Add(new GridViewTextBoxColumn("Actividad")); // 0 
            t.Columns.Add(new GridViewTextBoxColumn("Fecha")); // 1
            t.Columns.Add(new GridViewTextBoxColumn("OT"));         // 2    
            t.Columns.Add(new GridViewTextBoxColumn("nroDoc")); // 3
            t.Columns.Add(new GridViewTextBoxColumn("Caja")); // 4
            t.Columns.Add(new GridViewTextBoxColumn("Pzas"));      // 5                               
            t.Columns.Add(new GridViewTextBoxColumn("Producto")); // 6
            t.Columns.Add(new GridViewTextBoxColumn("llaveIngreso"));
            //t.Columns.Add(new GridViewTextBoxColumn("TieneMovimiento"));
            t.Columns[0].Width = 120;
            t.Columns[1].Width = 100;
            t.Columns[2].Width = 60;            
            t.Columns[3].Width = 80;
            t.Columns[6].MinWidth = 500; // producto
            //t.Columns[7].MinWidth = 1000;
            t.Columns["llaveIngreso"].IsVisible = false;
            //t.Columns["TieneMovimiento"].IsVisible = true;
            t.AllowAddNewRow = false;
            t.AllowEditRow = false;

            return t;
        }
        private void gridCanastilla_RowSourceNeeded(object sender, GridViewRowSourceNeededEventArgs e)
        {
            try
                {
                    // No importa el nivel: siempre se lee la propia fila que se está expandiendo
                    string llaveIngreso = e.ParentRow.Cells["llaveIngreso"].Value.ToString();
                    string nroCaja = e.ParentRow.Cells["Caja"].Value.ToString();

                    DataTable dt = DocumentoLogic.Instance.TraerCanastilaProduccionNivel2(
                        Logueo.CodigoEmpresa, llaveIngreso, nroCaja);

                    if (dt == null || dt.Rows.Count == 0) return;
                    
                        foreach (DataRow row in dt.Rows)
                        {
                            GridViewRowInfo newRow = e.Template.Rows.NewRow();

                            newRow.Cells["OT"].Value = row["OT"];
                            newRow.Cells["Caja"].Value = row["Caja"];
                            newRow.Cells["Pzas"].Value = row["Pzas"];
                            newRow.Cells["nroDoc"].Value = row["nroDoc"];
                            newRow.Cells["Fecha"].Value = row["fecha"];
                            newRow.Cells["Actividad"].Value = row["Actividad"];
                            newRow.Cells["Producto"].Value = row["Producto"];
                            newRow.Cells["llaveIngreso"].Value = row["llaveIngreso"]; // clave para que el hijo pueda seguir bajando
                            //newRow.Cells["TieneMovimiento"].Value = row["TieneMovimiento"];
                            //bool tieneHijos = row["TieneMovimiento"] != DBNull.Value && Convert.ToInt32(row["TieneMovimiento"]) == 1;
                            //newRow.Cells["TieneMovimiento"].Value = tieneHijos;

                            e.SourceCollection.Add(newRow);
                        }
                    
                    
                }
                catch (Exception ex)
                {
                    Util.ShowAlert("Error al cargar datos jerárquicos: " + ex.Message);
                }
        }

        //private bool esExpandible(GridViewRowInfo rowInfo)
        //{

        //    // Fila de nivel 1 (maestro): siempre expandible, ya que ahí no manejamos el flag
        //    if (rowInfo.Cells["TieneMovimiento"] == null) return true;

        //    var valor = rowInfo.Cells["TieneMovimiento"].Value;
        //    if (valor == null || valor == DBNull.Value) return true; // por seguridad, si no hay dato, deja expandir


        //    return Convert.ToBoolean(valor);
        //}

        private void gridCanastilla_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            //try
            //{
            //    GridGroupExpanderCellElement cell = e.CellElement as GridGroupExpanderCellElement;
            //    if (cell != null && e.CellElement.RowElement is GridDataRowElement)
            //    {
            //        if (!esExpandible(cell.RowInfo))
            //        {
            //            cell.Expander.Visibility = Telerik.WinControls.ElementVisibility.Hidden;
            //        }
            //        else
            //        {
            //            cell.Expander.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            //        }
            //    }
            //}
            //catch (Exception ex) {
            //    Util.ShowAlert("Error en gridcanastilla viewCellFormatting");
            //}
            
        }

        private void gridCanastilla_ChildViewExpanding(object sender, ChildViewExpandingEventArgs e)
        {

            try
            {
                // Aquí SOLO bloqueamos la expansión si no hay hijos; no cargamos datos aquí (eso lo sigue haciendo RowSourceNeeded)
                //e.Cancel = !esExpandible(e.ParentRow);
            }
            catch (Exception ex) {
                Util.ShowAlert("Error gridcanastilla childViewExpanding");
            }
        }

        //private void evneotSourceNeed() {
        //    try
        //    {
        //        string llaveIngreso = e.ParentRow.Cells["llaveIngreso"].Value.ToString();
        //        string nroCaja = e.ParentRow.Cells["IN07NROCAJA"].Value.ToString();

        //        DataTable dt = DocumentoLogic.Instance.TraerCanastilaProduccionNivel2(
        //            Logueo.CodigoEmpresa, llaveIngreso, nroCaja);

        //        if (dt != null && dt.Rows.Count > 0)
        //        {
        //            foreach (DataRow row in dt.Rows)
        //            {
        //                // Crear una nueva fila de RadGridView
        //                GridViewRowInfo newRow = e.Template.Rows.NewRow();

        //                newRow.Cells["OT"].Value = row["OT"];
        //                newRow.Cells["Caja"].Value = row["Caja"];
        //                newRow.Cells["Pzas"].Value = row["Pzas"];
        //                newRow.Cells["nroDoc"].Value = row["nroDoc"];
        //                newRow.Cells["Fecha"].Value = row["Fecha"];
        //                newRow.Cells["Producto"].Value = row["Producto"];
        //                newRow.Cells["Actividad"].Value = row["Actividad"];

        //                // Añadir la fila a la colección
        //                e.SourceCollection.Add(newRow);
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Util.ShowAlert("Error al cargar datos jerárquicos: " + ex.Message);
        //    }
        //}
        //private void gridCanastilla_ChildViewExpanding(object sender, ChildViewExpandingEventArgs e)
        //{
        //    //                // 1. Aseguramos que la fila que se expande sea del tipo jerárquico correcto
        //    //GridViewHierarchyRowInfo parentRow = e.ParentRow ;
        //    //if (parentRow == null) return;
        //    //string nroCaja = ""; string llaveIngreso = "";
        //    //if (parentRow.Cells["Caja"].Value == null)
        //    //{
        //    //        nroCaja = "";
        //    //}else{
        //    //    nroCaja = parentRow.Cells["Caja"].Value.ToString();
        //    //}
        //    ////string nroCaja = parentRow.Cells["IN07NROCAJA"].Value?.ToString() ?? string.Empty;
            
        //    //if(parentRow.Cells["llaveIngreso"].Value == null){
        //    //        llaveIngreso = "";
        //    //}else{
        //    //    llaveIngreso = parentRow.Cells["llaveIngreso"].Value.ToString();
        //    //}
        //    ////string llaveIngreso = parentRow.Cells["llaveIngreso"].Value?.ToString() ?? string.Empty;
           
        //    //// 2. Traer los datos de la base de datos para el Nivel 2
        //    //DataTable dt = DocumentoLogic.Instance.TraerCanastilaProduccionNivel2(
        //    //    Logueo.CodigoEmpresa, llaveIngreso, nroCaja);

        //    //if (dt != null)
        //    //{
        //    //    // En Telerik, para suspender el refresco visual durante la carga se usa el GridView principal:
        //    //    //this.gridCanastilla.GridViewElement.SuspendLayout();
        //    //    try
        //    //    {
        //    //        // 3. Obtener la colección de filas de la vista hija activa de esta fila padre
        //    //        // En la jerarquía de Telerik, esta es la colección real que almacena los datos secundarios

        //    //        System.Collections.IList childRowsCollection = parentRow.ActiveView.Rows;
        //    //        var childView =  parentRow.ActiveView;
        //    //        // Limpiamos los elementos previos (como el nodo "cargando..." o vacíos)
        //    //        childRowsCollection.Clear();

        //    //        foreach (DataRow row in dt.Rows)
        //    //        {
        //    //            GridViewTemplate nivel2 =  this.gridCanastilla.Templates[0];
        //    //            // 4. Crear la nueva fila hija asociada a la plantilla (ActiveView) correcta
        //    //            GridViewRowInfo fila = nivel2.Rows.AddNew();
                
        //    //            //e.chi
        //    //            // 5. Asignar los valores a las celdas usando los nombres de columna de la plantilla hija
        //    //            fila.Cells["OT"].Value = row["OT"];
        //    //            fila.Cells["Caja"].Value = row["Caja"];
        //    //            fila.Cells["Pzas"].Value = row["Pzas"];
        //    //            fila.Cells["nroDoc"].Value = row["nroDoc"];
        //    //            fila.Cells["Fecha"].Value = row["Fecha"];
        //    //            fila.Cells["Producto"].Value = row["Producto"];
        //    //            fila.Cells["Actividad"].Value = row["Actividad"];
        //    //            //newRow.Cells["OT"].Value = row["OT"];
        //    //            //newRow.Cells["Caja"].Value = row["Caja"];
        //    //            //newRow.Cells["Pzas"].Value = row["Pzas"];
        //    //            //newRow.Cells["nroDoc"].Value = row["nroDoc"];
        //    //            //newRow.Cells["Fecha"].Value = row["fecha"];
        //    //            //newRow.Cells["Producto"].Value = row["Producto"];
        //    //            //newRow.Cells["Actividad"].Value = row["Actividad"];
                        
        //    //            // 6. Agregar la fila directamente a la colección de filas hijas
        //    //            //childRowsCollection.Add(newRow);
        //    //        }
        //    //    }
        //    //    finally
        //    //    {
        //    //        // Reanudamos el refresco visual del Grid
        //    //        this.gridCanastilla.GridViewElement.ResumeLayout(true);
        //    //    }
        //    //}
        //}
       
    }


}
