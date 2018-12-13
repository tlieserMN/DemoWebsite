namespace DemoWebsite
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Name
    {
        public int ID { get; set; }

        public string F_NAME { get; set; }

        public string L_NAME { get; set; }
    }
}
