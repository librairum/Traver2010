﻿namespace Cos.UI.Win
{
    partial class frmBaseReg
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaseReg));
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cbbGuardar = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbCancelar = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarSeparator1 = new Telerik.WinControls.UI.CommandBarSeparator();
            this.cbbVistaPrevia = new Telerik.WinControls.UI.CommandBarButton();
            this.cbbImprimir = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarStripElement2 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdPrimero = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdAnterior = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdSiguiente = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdUltimo = new Telerik.WinControls.UI.CommandBarButton();
            this.windows8Theme1 = new Telerik.WinControls.Themes.Windows8Theme();
            this.telerikMetroTouchTheme1 = new Telerik.WinControls.Themes.TelerikMetroTouchTheme();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.office2013LightTheme1 = new Telerik.WinControls.Themes.Office2013LightTheme();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(471, 33);
            this.radCommandBar1.TabIndex = 3;
            this.radCommandBar1.Text = "radCommandBar1";
            this.radCommandBar1.ThemeName = "Office2013Light";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1,
            this.commandBarStripElement2});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cbbGuardar,
            this.cbbCancelar,
            this.commandBarSeparator1,
            this.cbbVistaPrevia,
            this.cbbImprimir});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // cbbGuardar
            // 
            this.cbbGuardar.AccessibleDescription = "Guardar";
            this.cbbGuardar.AccessibleName = "Guardar";
            this.cbbGuardar.DisplayName = "commandBarButton1";
            this.cbbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("cbbGuardar.Image")));
            this.cbbGuardar.Name = "cbbGuardar";
            this.cbbGuardar.Text = "Guardar";
            this.cbbGuardar.ToolTipText = "Guardar";
            this.cbbGuardar.Click += new System.EventHandler(this.cbbGuardar_Click);
            // 
            // cbbCancelar
            // 
            this.cbbCancelar.AccessibleDescription = "Cancelar";
            this.cbbCancelar.AccessibleName = "Cancelar";
            this.cbbCancelar.DisplayName = "commandBarButton2";
            this.cbbCancelar.Image = ((System.Drawing.Image)(resources.GetObject("cbbCancelar.Image")));
            this.cbbCancelar.Name = "cbbCancelar";
            this.cbbCancelar.Text = "Cancelar";
            this.cbbCancelar.ToolTipText = "Cancelar";
            this.cbbCancelar.Click += new System.EventHandler(this.cbbCancelar_Click);
            // 
            // commandBarSeparator1
            // 
            this.commandBarSeparator1.AccessibleDescription = "commandBarSeparator1";
            this.commandBarSeparator1.AccessibleName = "commandBarSeparator1";
            this.commandBarSeparator1.BorderBottomColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commandBarSeparator1.BorderInnerColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commandBarSeparator1.BorderLeftColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commandBarSeparator1.BorderRightColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commandBarSeparator1.BorderTopColor = System.Drawing.SystemColors.ControlDarkDark;
            this.commandBarSeparator1.BorderWidth = 2F;
            this.commandBarSeparator1.DisplayName = "commandBarSeparator1";
            this.commandBarSeparator1.Name = "commandBarSeparator1";
            this.commandBarSeparator1.VisibleInOverflowMenu = false;
            // 
            // cbbVistaPrevia
            // 
            this.cbbVistaPrevia.AccessibleDescription = "Vista previa";
            this.cbbVistaPrevia.AccessibleName = "VistaPrevia";
            this.cbbVistaPrevia.DisplayName = "commandBarButton1";
            this.cbbVistaPrevia.Image = ((System.Drawing.Image)(resources.GetObject("cbbVistaPrevia.Image")));
            this.cbbVistaPrevia.Name = "cbbVistaPrevia";
            this.cbbVistaPrevia.Text = "Vista previa";
            this.cbbVistaPrevia.ToolTipText = "Vista previa";
            this.cbbVistaPrevia.Click += new System.EventHandler(this.cbbVistaPrevia_Click);
            // 
            // cbbImprimir
            // 
            this.cbbImprimir.AccessibleDescription = "Imprimir";
            this.cbbImprimir.AccessibleName = "Imprimir";
            this.cbbImprimir.DisplayName = "commandBarButton1";
            this.cbbImprimir.Image = ((System.Drawing.Image)(resources.GetObject("cbbImprimir.Image")));
            this.cbbImprimir.Name = "cbbImprimir";
            this.cbbImprimir.Text = "Imprimir";
            this.cbbImprimir.ToolTipText = "Imprimir";
            this.cbbImprimir.Click += new System.EventHandler(this.cbbImprimir_Click);
            // 
            // commandBarStripElement2
            // 
            this.commandBarStripElement2.DisplayName = "commandBarStripElement2";
            this.commandBarStripElement2.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cmdPrimero,
            this.cmdAnterior,
            this.cmdSiguiente,
            this.cmdUltimo});
            this.commandBarStripElement2.Name = "commandBarStripElement2";
            this.commandBarStripElement2.Visibility = Telerik.WinControls.ElementVisibility.Visible;
            // 
            // cmdPrimero
            // 
            this.cmdPrimero.AccessibleDescription = "commandBarButton1";
            this.cmdPrimero.AccessibleName = "commandBarButton1";
            this.cmdPrimero.DisplayName = "commandBarButton1";
            this.cmdPrimero.Image = ((System.Drawing.Image)(resources.GetObject("cmdPrimero.Image")));
            this.cmdPrimero.Name = "cmdPrimero";
            this.cmdPrimero.Text = "<<";
            this.cmdPrimero.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.cmdPrimero.Click += new System.EventHandler(this.cmdPrimero_Click);
            // 
            // cmdAnterior
            // 
            this.cmdAnterior.AccessibleDescription = "commandBarButton2";
            this.cmdAnterior.AccessibleName = "commandBarButton2";
            this.cmdAnterior.DisplayName = "commandBarButton2";
            this.cmdAnterior.Image = ((System.Drawing.Image)(resources.GetObject("cmdAnterior.Image")));
            this.cmdAnterior.Name = "cmdAnterior";
            this.cmdAnterior.Text = "<";
            this.cmdAnterior.Click += new System.EventHandler(this.cmdAnterior_Click);
            // 
            // cmdSiguiente
            // 
            this.cmdSiguiente.AccessibleDescription = "commandBarButton3";
            this.cmdSiguiente.AccessibleName = "commandBarButton3";
            this.cmdSiguiente.DisplayName = "commandBarButton3";
            this.cmdSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("cmdSiguiente.Image")));
            this.cmdSiguiente.Name = "cmdSiguiente";
            this.cmdSiguiente.Text = ">";
            this.cmdSiguiente.Click += new System.EventHandler(this.cmdSiguiente_Click);
            // 
            // cmdUltimo
            // 
            this.cmdUltimo.AccessibleDescription = "commandBarButton4";
            this.cmdUltimo.AccessibleName = "commandBarButton4";
            this.cmdUltimo.DisplayName = "commandBarButton4";
            this.cmdUltimo.Image = ((System.Drawing.Image)(resources.GetObject("cmdUltimo.Image")));
            this.cmdUltimo.Name = "cmdUltimo";
            this.cmdUltimo.Text = ">>";
            this.cmdUltimo.Click += new System.EventHandler(this.cmdUltimo_Click);
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 500;
            this.toolTip.ReshowDelay = 100;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Ayuda";
            // 
            // frmBaseReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 423);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "frmBaseReg";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ThemeName = "Office2013Light";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmBaseReg_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cbbGuardar;
        private Telerik.WinControls.UI.CommandBarButton cbbCancelar;
        private Telerik.WinControls.Themes.Windows8Theme windows8Theme1;
        private Telerik.WinControls.Themes.TelerikMetroTouchTheme telerikMetroTouchTheme1;
        protected System.Windows.Forms.ToolTip toolTip;
        private Telerik.WinControls.Themes.Office2013LightTheme office2013LightTheme1;
        private Telerik.WinControls.UI.CommandBarSeparator commandBarSeparator1;
        private Telerik.WinControls.UI.CommandBarButton cbbVistaPrevia;
        private Telerik.WinControls.UI.CommandBarButton cbbImprimir;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement2;
        private Telerik.WinControls.UI.CommandBarButton cmdPrimero;
        private Telerik.WinControls.UI.CommandBarButton cmdAnterior;
        private Telerik.WinControls.UI.CommandBarButton cmdSiguiente;
        private Telerik.WinControls.UI.CommandBarButton cmdUltimo;
        protected Telerik.WinControls.UI.RadCommandBar radCommandBar1;
    }
}
