using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Inv.BusinessEntities;
using Inv.BusinessLogic;

using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace Fac.UI.Win
{
    public partial class frmRepGuiaHistorico : frmBaseReporte
    {
        private Telerik.WinControls.UI.RadPanel rpControl;
        private Telerik.WinControls.UI.RadButton btnBuscar;
        private Telerik.WinControls.UI.RadGridView gridControl;
        private RadButton btnCopiarTodo;
        private Label label1;
        private Panel panel1;
        private DateTimePicker dtpfin;
        private Label label2;
        private DateTimePicker dtpinicio;
        private RadioButton rbFechas;
        private RadioButton rbHistorico;

        private frmMDI frmParent { get; set; }
        private static frmRepGuiaHistorico _aForm;
        

        public frmRepGuiaHistorico(frmMDI frmPadre)
        {
            InitializeComponent();
            crearColumnas();
            onCargar();
        }

        public static frmRepGuiaHistorico Instance(frmMDI formParent)
        {
            if (_aForm != null) return new frmRepGuiaHistorico(formParent);
            _aForm = new frmRepGuiaHistorico(formParent);
            return _aForm;
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepGuiaHistorico));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.rpControl = new Telerik.WinControls.UI.RadPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpfin = new System.Windows.Forms.DateTimePicker();
            this.btnCopiarTodo = new Telerik.WinControls.UI.RadButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new Telerik.WinControls.UI.RadButton();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpinicio = new System.Windows.Forms.DateTimePicker();
            this.gridControl = new Telerik.WinControls.UI.RadGridView();
            this.rbHistorico = new System.Windows.Forms.RadioButton();
            this.rbFechas = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.rpControl)).BeginInit();
            this.rpControl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopiarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rpControl
            // 
            this.rpControl.Controls.Add(this.panel1);
            this.rpControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpControl.Location = new System.Drawing.Point(0, 33);
            this.rpControl.Name = "rpControl";
            this.rpControl.Size = new System.Drawing.Size(910, 33);
            this.rpControl.TabIndex = 28;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFechas);
            this.panel1.Controls.Add(this.rbHistorico);
            this.panel1.Controls.Add(this.dtpfin);
            this.panel1.Controls.Add(this.btnCopiarTodo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dtpinicio);
            this.panel1.Location = new System.Drawing.Point(12, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 30);
            this.panel1.TabIndex = 44;
            // 
            // dtpfin
            // 
            this.dtpfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfin.Location = new System.Drawing.Point(454, 4);
            this.dtpfin.Name = "dtpfin";
            this.dtpfin.Size = new System.Drawing.Size(75, 20);
            this.dtpfin.TabIndex = 43;
            // 
            // btnCopiarTodo
            // 
            this.btnCopiarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiarTodo.Image")));
            this.btnCopiarTodo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopiarTodo.Location = new System.Drawing.Point(579, 2);
            this.btnCopiarTodo.Name = "btnCopiarTodo";
            this.btnCopiarTodo.Size = new System.Drawing.Size(27, 27);
            this.btnCopiarTodo.TabIndex = 38;
            this.btnCopiarTodo.ThemeName = "Windows8";
            this.btnCopiarTodo.Click += new System.EventHandler(this.btnCopiarTodo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "fec.inicio :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnBuscar.Location = new System.Drawing.Point(546, 1);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(27, 27);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.ThemeName = "Windows8";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "fec.fin:";
            // 
            // dtpinicio
            // 
            this.dtpinicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpinicio.Location = new System.Drawing.Point(305, 4);
            this.dtpinicio.Name = "dtpinicio";
            this.dtpinicio.Size = new System.Drawing.Size(84, 20);
            this.dtpinicio.TabIndex = 41;
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 66);
            // 
            // 
            // 
            this.gridControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridControl.Name = "gridControl";
            // 
            // 
            // 
            this.gridControl.RootElement.AccessibleDescription = null;
            this.gridControl.RootElement.AccessibleName = null;
            this.gridControl.RootElement.Alignment = System.Drawing.ContentAlignment.TopLeft;
            this.gridControl.RootElement.AngleTransform = 0F;
            this.gridControl.RootElement.FlipText = false;
            this.gridControl.RootElement.Margin = new System.Windows.Forms.Padding(0);
            this.gridControl.RootElement.Text = null;
            this.gridControl.RootElement.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.gridControl.Size = new System.Drawing.Size(910, 339);
            this.gridControl.TabIndex = 29;
            this.gridControl.TabStop = false;
            this.gridControl.Text = "radGridView2";
            // 
            // rbHistorico
            // 
            this.rbHistorico.AutoSize = true;
            this.rbHistorico.Location = new System.Drawing.Point(18, 6);
            this.rbHistorico.Name = "rbHistorico";
            this.rbHistorico.Size = new System.Drawing.Size(70, 17);
            this.rbHistorico.TabIndex = 44;
            this.rbHistorico.TabStop = true;
            this.rbHistorico.Text = "historico";
            this.rbHistorico.UseVisualStyleBackColor = true;
            // 
            // rbFechas
            // 
            this.rbFechas.AutoSize = true;
            this.rbFechas.Location = new System.Drawing.Point(108, 5);
            this.rbFechas.Name = "rbFechas";
            this.rbFechas.Size = new System.Drawing.Size(128, 17);
            this.rbFechas.TabIndex = 45;
            this.rbFechas.TabStop = true;
            this.rbFechas.Text = "Por rango de fechas";
            this.rbFechas.UseVisualStyleBackColor = true;
            // 
            // frmRepGuiaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(910, 405);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.rpControl);
            this.Name = "frmRepGuiaHistorico";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reporte historico Guia Remision";
            this.Load += new System.EventHandler(this.frmRepGuiaHistorico_Load);
            this.Controls.SetChildIndex(this.rpControl, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.rpControl)).EndInit();
            this.rpControl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopiarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }
        private void onCargar() {
            string flagBusqueda = rbHistorico.Checked == true ? "H" : "R";

            Cursor.Current = Cursors.WaitCursor;
           
            try
            {
                List<GuiaTransporte> lista = Fac_GuiaTransporteLogic.Instance.Spu_Fac_Trae_GuiaRemisionHistorico(Logueo.CodigoEmpresa,
               dtpinicio.Value.ToShortDateString(),
               dtpfin.Value.ToShortDateString(), flagBusqueda);
                this.gridControl.DataSource = lista;
            
            }
            catch (Exception ex) {
                Util.ShowAlert("Error al cargar :" + ex.Message);
            }

            Cursor.Current = Cursors.Default;
        }
        private void SeleccionarTodoFilas()
        {
            try
            {

                gridControl.SelectAll();

                DataObject dataObj = gridControl.GetClipboardContent();
                if (dataObj != null)
                {
                    Clipboard.SetDataObject(dataObj);
                }
            }
            catch (Exception ex)
            {
                Util.ShowError("Error al copiar todo las filas , detalle:" + ex.Message);
            }
        }
        private void crearColumnas() {
            RadGridView Grid = CreateGrid(this.gridControl);
            
            CreateGridColumn(Grid, "Fecha", "FAC34FECHA", 0, "{0:dd/MM/yyyy}", 40);
            CreateGridColumn(Grid, "nro.Guia", "FAC34NROGUIA", 0, "", 50);
            CreateGridColumn(Grid, "Cliente", "FAC34CLIDES", 0, "", 150);
            CreateGridColumn(Grid, "Producto", "FAC35DESCPROD", 0, "", 200, true, false, false);
            CreateGridColumn(Grid, "Unidad", "FAC35UNIMED", 0, "", 25);
            CreateGridColumn(Grid, "Cantidad", "FAC35CANTIDAD", 0, "{0:###,###0.00}", 35);
            CreateGridColumn(Grid, "GuiaElecEstadoSunat", "GuiaElecEstadoSunat", 0, "", 100);

            Grid.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            onCargar();
        }

        private void frmRepGuiaHistorico_Load(object sender, EventArgs e)
        {
            onCargar();
            //OcultarBotones();
            OcultarBarraBotones();
            //HabilitaBotonPorNombre(BaseRegBotones.cbbExportar);
            

        }
        private void exportarExcel(RadGridView grid, string filePath)
        {
            Excel.Application excelApp = null;
            Excel.Workbook workbook = null;
            Excel.Worksheet worksheet = null;
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                excelApp = new Excel.Application();
                excelApp.Visible = false;
                excelApp.DisplayAlerts = false;

                workbook = excelApp.Workbooks.Add(Type.Missing);
                worksheet = (Excel.Worksheet)workbook.Worksheets[1];
                worksheet.Name = "Datos";

                // ---- Cabecera ----
                int col = 1;
                foreach (GridViewDataColumn column in grid.Columns)
                {
                    if (!column.IsVisible) continue;

                    Excel.Range headerCell = (Excel.Range)worksheet.Cells[1, col];
                    headerCell.Value2 = column.HeaderText;
                    headerCell.Font.Bold = true;
                    col++;
                }

                // ---- Filas ----
                int row = 2;
                Cursor.Current = Cursors.WaitCursor;
                foreach (GridViewRowInfo gridRow in grid.Rows)
                {
                    col = 1;
                    foreach (GridViewDataColumn column in grid.Columns)
                    {
                        if (!column.IsVisible) continue;

                        object cellValue = gridRow.Cells[column.Name].Value;
                        string textValue = cellValue != null ? cellValue.ToString() : string.Empty;

                        Excel.Range cell = (Excel.Range)worksheet.Cells[row, col];

                        // Forzamos formato TEXTO ANTES de asignar el valor
                        // para que Excel no reinterprete fechas, ceros a la izquierda, etc.
                        cell.NumberFormat = "@";
                        cell.Value2 = textValue;

                        col++;
                    }
                    row++;
                }

                worksheet.Columns.AutoFit();
                
                workbook.SaveAs(filePath, Excel.XlFileFormat.xlOpenXMLWorkbook,
                    Type.Missing, Type.Missing, false, false,
                    Excel.XlSaveAsAccessMode.xlNoChange,
                    Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                Cursor.Current = Cursors.Default;
            }
            finally
            {
                // ---- Liberación de recursos COM (CRÍTICO en Interop) ----
                if (workbook != null)
                {
                    workbook.Close(false, Type.Missing, Type.Missing);
                    
                    Marshal.ReleaseComObject(workbook);
                }
                if (excelApp != null)
                {
                    excelApp.Quit();
                    Marshal.ReleaseComObject(excelApp);
                }
                if (worksheet != null) Marshal.ReleaseComObject(worksheet);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
            Cursor.Current = Cursors.Default;

        }
        private void btnCopiarTodo_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "Excel (*.xlsx)|*.xlsx";
                sfd.FileName = "Reporte.xlsx";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    exportarExcel(this.gridControl, sfd.FileName);
                    MessageBox.Show("Exportación completada.");
                }
            }
            //SeleccionarTodoFilas();
        }
        
    }
}
