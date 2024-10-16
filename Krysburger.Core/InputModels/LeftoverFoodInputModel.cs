using System.ComponentModel.DataAnnotations;

namespace Krysburger.Core.InputModels
{
    public class LeftoverFoodInputModel
    {
        public string Name { get; set; }
        public string Measure { get; set; }
        public int Count { get; set;}
    }
}
