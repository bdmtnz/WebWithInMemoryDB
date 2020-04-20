using InMemory.Models;
using Newtonsoft.Json;
using System.IO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InMemory.Models
{
    public class Modell
    {
        [JsonProperty("nit")]
        [Key]
        public int Nit { get; set; }

        [JsonProperty("nombre")]
        public string Nombre { get; set; }
    }
}