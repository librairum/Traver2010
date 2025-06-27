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

        [MapField("ccm04ctacod")]
        public string ccm04ctacod	{get;set;}
        
        [MapField("ccm04tipana")]
        public string ccm04tipana { get; set; }

        [MapField("ccm04idbanco")]
        public string ccm04idbanco	 {get;set;}

        [MapField("ccm04idcuenta")]
        public string ccm04idcuenta	 {get;set;}

        [MapField("ccm04cci")]
        public string ccm04cci	{get;set;}

        [MapField("ccm04ctadefecto")]
        public string ccm04ctadefecto	{get;set;}

        [MapField("ccm04descripcion")]
        public string ccm04descripcion	{get;set;}

        [MapField("ccm04codigooficina")]
        public string ccm04codigooficina	 {get;set;}

        [MapField("ccm04moneda")]
        public string ccm04moneda { get; set; }

        [MapField("ccm04tipocuenta")]
        public string ccm04tipocuenta { get; set; }

    }
}
