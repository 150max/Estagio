using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstagioV5.Model
{ 
        public class Product
        {
        public string Name { get; set; } 
        public Int64 Datetimestart { get; set; } 
        public Int64 Datetimeend { get; set; } 
        public string Listzones { get; set; } 
        public string Listaps { get; set; } 
        public string Listdevices { get; set; } 
        public string Listuserprops { get; set; } 
        public int Topreg { get; set; } 


        /*
          EXEC    [dbo].[GetMeasures2]
        @Name = 'UniqueVisits',
        @datetimestart = 202110010000,
        @datetimeend = 202110020000,
        @listzones = '1',
        @listaps = '18,20',
        @listdevices = NULL,
        @listuserprops = NULL,
        @topreg = NULL
         */
    }     

}
