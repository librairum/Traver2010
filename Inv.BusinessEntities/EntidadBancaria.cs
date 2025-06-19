using System.Collections;
using System.Collections.Generic;
using BLToolkit.DataAccess;
using BLToolkit.Mapping;
using BLToolkit.Data;
using System;


namespace Inv.BusinessEntities
{

    [TableName("Ban01Banco")]
    public class EntidadBancaria
    {

        public string Ban01Empresa { get; set; }
        public string Ban01IdBanco	{get;set;}
        public string Ban01Descripcion	 {get;set;}
        public string Ban01Prefijo	 {get;set;}
        public string Ban01CodBancoPLE { get; set; }
    }
}
