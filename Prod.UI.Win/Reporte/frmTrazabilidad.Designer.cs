namespace Prod.UI.Win
{
    partial class frmTrazabilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.txtOrdenTrabajo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNroCaja = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gridCanastilla = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Size = new System.Drawing.Size(1050, 33);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.txtOrdenTrabajo);
            this.radGroupBox1.Controls.Add(this.label2);
            this.radGroupBox1.Controls.Add(this.btnBuscar);
            this.radGroupBox1.Controls.Add(this.txtNroCaja);
            this.radGroupBox1.Controls.Add(this.label1);
            this.radGroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radGroupBox1.HeaderText = "Opcion de reporte";
            this.radGroupBox1.Location = new System.Drawing.Point(0, 33);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(1050, 43);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Opcion de reporte";
            // 
            // txtOrdenTrabajo
            // 
            this.txtOrdenTrabajo.Location = new System.Drawing.Point(97, 20);
            this.txtOrdenTrabajo.Name = "txtOrdenTrabajo";
            this.txtOrdenTrabajo.Size = new System.Drawing.Size(100, 20);
            this.txtOrdenTrabajo.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Orden trabajo";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(368, 19);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNroCaja
            // 
            this.txtNroCaja.Location = new System.Drawing.Point(263, 20);
            this.txtNroCaja.Name = "txtNroCaja";
            this.txtNroCaja.Size = new System.Drawing.Size(100, 20);
            this.txtNroCaja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "nro caja:";
            // 
            // gridCanastilla
            // 
            this.gridCanastilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCanastilla.Location = new System.Drawing.Point(0, 76);
            // 
            // 
            // 
            this.gridCanastilla.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridCanastilla.Name = "gridCanastilla";
            this.gridCanastilla.Size = new System.Drawing.Size(1050, 385);
            this.gridCanastilla.TabIndex = 8;
            this.gridCanastilla.TabStop = false;
            this.gridCanastilla.Text = "radGridView1";
            this.gridCanastilla.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.gridCanastilla_ViewCellFormatting);
            this.gridCanastilla.RowSourceNeeded += new Telerik.WinControls.UI.GridViewRowSourceNeededEventHandler(this.gridCanastilla_RowSourceNeeded);
            // 
            // frmTrazabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 461);
            this.Controls.Add(this.gridCanastilla);
            this.Controls.Add(this.radGroupBox1);
            this.Name = "frmTrazabilidad";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reporte de validacion de canastilla de productos en proceso";
            this.Load += new System.EventHandler(this.frmTrazabilidad_Load);
            this.Controls.SetChildIndex(this.radGroupBox1, 0);
            this.Controls.SetChildIndex(this.gridCanastilla, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNroCaja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrdenTrabajo;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadGridView gridCanastilla;
    }
}
