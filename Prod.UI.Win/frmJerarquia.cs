using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Prod.UI.Win
{
    public partial class frmJerarquia : Form
    {
        public frmJerarquia()
        {
            InitializeComponent();
        }
        private void cargarDatos()
        {
            this.gridCanastilla.AutoGenerateColumns = false;
            this.gridCanastilla.Columns.Add("codigoProducto");
            this.gridCanastilla.Columns.Add("descripcion");
            this.gridCanastilla.Columns.Add("categoria");
            
            //agregar datos a primera tabla
            GridViewRowInfo fila =  this.gridCanastilla.Rows.AddNew();

            fila.Cells[0].Value = "F001";
            fila.Cells[1].Value = "table de pin pong";
            fila.Cells[2].Value = "Madera";
            gridCanastilla.AllowAddNewRow = false;
            gridCanastilla.AllowEditRow = false;
            //fila hijo

            GridViewTemplate nivel2 = new GridViewTemplate();
            nivel2.AutoGenerateColumns = false;
            nivel2.Columns.Add(new GridViewTextBoxColumn("codigoProducto"));
            nivel2.Columns.Add(new GridViewTextBoxColumn("proveedor"));
            nivel2.Columns.Add(new GridViewTextBoxColumn("direccion"));
            
            gridCanastilla.Templates.Add(nivel2);
            nivel2.AllowAddNewRow = true;
            nivel2.AllowEditRow = false;
            GridViewRelation relation = new GridViewRelation(gridCanastilla.MasterTemplate);
            relation.ChildTemplate = nivel2;
            relation.RelationName = "Nivel1_Nivel2";
            relation.ParentColumnNames.Add("codigoProducto");
            relation.ChildColumnNames.Add("codigoProducto");
            gridCanastilla.Relations.Add(relation);
        }

        private void gridCanastilla_ChildViewExpanding(object sender, Telerik.WinControls.UI.ChildViewExpandingEventArgs e)
        {
            string codigoPadre = "";
            if(e.ParentRow.Cells["codigoProducto"].Value != null){
                codigoPadre = e.ParentRow.Cells["codigoProducto"].Value.ToString();
            }
            //string codigoPadre = e.ParentRow.Cells["codigoProducto"].Value?.ToString();
    
    GridViewTemplate nivel2 = gridCanastilla.Templates[0]; // tu template hijo

    // Evitar duplicar si ya se agregaron antes
        //    if(r.Cells["codigoProducto"].Value != null){
            
        //    }
        //bool yaExisten = nivel2.Rows.Any(r => r.Cells["codigoProducto"].Value?.ToString() == codigoPadre);
        //if (yaExisten) return;

        GridViewRowInfo hijo1 = nivel2.Rows.AddNew();
        hijo1.Cells["codigoProducto"].Value = codigoPadre;
        hijo1.Cells["proveedor"].Value = "Konecta";
        hijo1.Cells["direccion"].Value = "av.brasil 863";
            //DataRow nueva2 = childTable.NewRow();
            //nueva2["IdProduccion"] = parentRow["IdProduccion"];
            //nueva2["codigoProducto"] = "F002";
            //nueva2["proveedor"] = "movistar";
            //nueva2["direccion"] = "av.brasil 863";
            //childTable.Rows.Add(nueva2);
            
        }

        private void frmJerarquia_LocationChanged(object sender, EventArgs e)
        {

        }

        private void frmJerarquia_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }
    }
}
