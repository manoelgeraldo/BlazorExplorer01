using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorExplorer.Entities
{
    public class Table01
    {
        public int Id { get; set; }
        public string CampoTable01 { get; set; }
        public Table02 Table02 { get; set; }
    }
}
