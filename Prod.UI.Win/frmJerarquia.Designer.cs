namespace Prod.UI.Win
{
    partial class frmJerarquia
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.gridCanastilla = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCanastilla
            // 
            this.gridCanastilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCanastilla.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.gridCanastilla.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.gridCanastilla.Name = "gridCanastilla";
            this.gridCanastilla.Size = new System.Drawing.Size(678, 288);
            this.gridCanastilla.TabIndex = 9;
            this.gridCanastilla.TabStop = false;
            this.gridCanastilla.Text = "radGridView1";
            this.gridCanastilla.ChildViewExpanding += new Telerik.WinControls.UI.ChildViewExpandingEventHandler(this.gridCanastilla_ChildViewExpanding);
            // 
            // frmJerarquia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 288);
            this.Controls.Add(this.gridCanastilla);
            this.Name = "frmJerarquia";
            this.Text = "frmJerarquia";
            this.Load += new System.EventHandler(this.frmJerarquia_Load);
            this.LocationChanged += new System.EventHandler(this.frmJerarquia_LocationChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCanastilla)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView gridCanastilla;
    }
}