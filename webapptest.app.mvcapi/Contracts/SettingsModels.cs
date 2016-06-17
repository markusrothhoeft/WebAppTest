using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace webapptest.app.mvcapi.Models
{
    // Von SettingsController-Aktionen zurückgegebene Modelle.
    public class HelpClass
    {
        public string Hostname { get; set; }
        public int Port { get; set; }
        [Required]
        public JObject Obj { get; set; }
    }

    public class Adress
    {
        public string Adresse { get; set; } = "Mendener Str. 171";
        public int PLZ { get; set; } = 58675;
        public string Stadt { get; set; } = "Hemer";
    }


    public class ModuleSettingsViewModel
    {
        [Required]
        [StringLength(10)]
        public string Hostname { get; set; } = "MSE-DEV99";
        [Range(0, 65000, ErrorMessage = "Die Portnummer muss im Bereich von {1} bis {2} liegen.")]
        public int Port { get; set; } = 49500;

        public Adress Obj { get; set; }

        public ModuleSettingsViewModel()
        {
            Obj = new Adress();
        }
    }
}