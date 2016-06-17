using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapptest.app.mvcapi.Models
{
    // Von MeController-Aktionen zurückgegebene Modelle.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}