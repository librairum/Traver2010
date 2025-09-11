using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;


namespace Inv.BusinessEntities
{
    [TableName("ccm04ctabancaria")]
    public class ProveedorCtaBco
    {
        [MapField("ccm04emp")]
        public string ccm04emp	{get;set;}

        [MapField("ccm04entidadcod")]
        public string ccm04entidadcod	{get;set;}

        [MapField("ccm04ctabcacod")]
        public string ccm04ctabcacod { get; set; }
        
        [MapField("ccm04tipana")]
        public string ccm04tipana { get; set; }

        [MapField("ccm04tipocuenta")]
        public string ccm04tipocuenta { get; set; }

        [MapField("ccm04bancocod")]
        public string ccm04bancocod { get; set; }

        [MapField("ccm04nrocuenta")]
        public string ccm04nrocuenta { get; set; }

        [MapField("ccm04nrocuentacci")]
        public string ccm04nrocuentacci { get; set; }

        [MapField("ccm04ctadefecto")]
        public string ccm04ctadefecto	{get;set;}

        [MapField("ccm04descripcion")]
        public string ccm04descripcion	{get;set;}

        [MapField("ccm04oficinacod")]
        public string ccm04oficinacod { get; set; }

        [MapField("ccm04moneda")]
        public string ccm04moneda { get; set; }

       

    }
}
