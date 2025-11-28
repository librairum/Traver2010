namespace Prod.UI.Win
{
    partial class FrmRepSaldoMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRepSaldoMP));
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGroupBox3 = new Telerik.WinControls.UI.RadGroupBox();
            this.cboLineas = new Telerik.WinControls.UI.RadDropDownList();
            this.radGroupBox1 = new Telerik.WinControls.UI.RadGroupBox();
            this.btnRefrescar = new Telerik.WinControls.UI.RadButton();
            this.rbPeriodo = new Telerik.WinControls.UI.RadRadioButton();
            this.cboperiodosini = new Telerik.WinControls.UI.RadDropDownList();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.btnCopiarTodo = new Telerik.WinControls.UI.RadButton();
            this.gridControl = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).BeginInit();
            this.radGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).BeginInit();
            this.radGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbPeriodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboperiodosini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopiarTodo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Size = new System.Drawing.Size(1171, 33);
            // 
            // radGroupBox3
            // 
            this.radGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox3.Controls.Add(this.cboLineas);
            this.radGroupBox3.HeaderText = "Linea";
            this.radGroupBox3.Location = new System.Drawing.Point(17, 8);
            this.radGroupBox3.Name = "radGroupBox3";
            this.radGroupBox3.Size = new System.Drawing.Size(222, 43);
            this.radGroupBox3.TabIndex = 6;
            this.radGroupBox3.Text = "Linea";
            // 
            // cboLineas
            // 
            this.cboLineas.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.cboLineas.Location = new System.Drawing.Point(15, 18);
            this.cboLineas.Name = "cboLineas";
            this.cboLineas.Size = new System.Drawing.Size(202, 20);
            this.cboLineas.TabIndex = 11;
            this.cboLineas.Text = "radDropDownList1";
            this.cboLineas.SelectedValueChanged += new System.EventHandler(this.cboLineas_SelectedValueChanged);
            // 
            // radGroupBox1
            // 
            this.radGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.radGroupBox1.Controls.Add(this.btnRefrescar);
            this.radGroupBox1.Controls.Add(this.rbPeriodo);
            this.radGroupBox1.Controls.Add(this.cboperiodosini);
            this.radGroupBox1.HeaderText = "Opcion de fecha";
            this.radGroupBox1.Location = new System.Drawing.Point(245, 8);
            this.radGroupBox1.Name = "radGroupBox1";
            this.radGroupBox1.Size = new System.Drawing.Size(410, 49);
            this.radGroupBox1.TabIndex = 5;
            this.radGroupBox1.Text = "Opcion de fecha";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(312, 17);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(87, 25);
            this.btnRefrescar.TabIndex = 13;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // rbPeriodo
            // 
            this.rbPeriodo.Location = new System.Drawing.Point(28, 21);
            this.rbPeriodo.Name = "rbPeriodo";
            this.rbPeriodo.Size = new System.Drawing.Size(59, 18);
            this.rbPeriodo.TabIndex = 10;
            this.rbPeriodo.Text = "Periodo";
            // 
            // cboperiodosini
            // 
            this.cboperiodosini.Location = new System.Drawing.Point(118, 21);
            this.cboperiodosini.Name = "cboperiodosini";
            this.cboperiodosini.Size = new System.Drawing.Size(188, 20);
            this.cboperiodosini.TabIndex = 0;
            this.cboperiodosini.Text = "radDropDownList1";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.btnCopiarTodo);
            this.radPanel2.Controls.Add(this.radGroupBox3);
            this.radPanel2.Controls.Add(this.radGroupBox1);
            this.radPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.radPanel2.Location = new System.Drawing.Point(0, 33);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1171, 66);
            this.radPanel2.TabIndex = 9;
            // 
            // btnCopiarTodo
            // 
            this.btnCopiarTodo.Image = ((System.Drawing.Image)(resources.GetObject("btnCopiarTodo.Image")));
            this.btnCopiarTodo.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCopiarTodo.Location = new System.Drawing.Point(661, 22);
            this.btnCopiarTodo.Name = "btnCopiarTodo";
            this.btnCopiarTodo.Size = new System.Drawing.Size(34, 29);
            this.btnCopiarTodo.TabIndex = 35;
            this.btnCopiarTodo.ThemeName = "Windows8";
            this.btnCopiarTodo.Click += new System.EventHandler(this.btnCopiarTodo_Click);
            // 
            // gridControl
            // 
            this.gridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl.Location = new System.Drawing.Point(0, 99);
            // 
            // 
            // 
            this.gridControl.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(1171, 388);
            this.gridControl.TabIndex = 11;
            this.gridControl.Text = "radGridView1";
            // 
            // FrmRepSaldoMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 487);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.radPanel2);
            this.Name = "FrmRepSaldoMP";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reporte de saldo Materia Prima";
            this.Controls.SetChildIndex(this.radPanel2, 0);
            this.Controls.SetChildIndex(this.gridControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.toolBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox3)).EndInit();
            this.radGroupBox3.ResumeLayout(false);
            this.radGroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGroupBox1)).EndInit();
            this.radGroupBox1.ResumeLayout(false);
            this.radGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbPeriodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboperiodosini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCopiarTodo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGroupBox radGroupBox3;
        private Telerik.WinControls.UI.RadDropDownList cboLineas;
        private Telerik.WinControls.UI.RadGroupBox radGroupBox1;
        private Telerik.WinControls.UI.RadRadioButton rbPeriodo;
        private Telerik.WinControls.UI.RadDropDownList cboperiodosini;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadButton btnRefrescar;
        private Telerik.WinControls.UI.RadGridView gridControl;
        private Telerik.WinControls.UI.RadButton btnCopiarTodo;
    }
}
