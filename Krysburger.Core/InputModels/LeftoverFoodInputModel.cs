using System.ComponentModel.DataAnnotations;

namespace Krysburger.Core.InputModels
{
    public class LeftoverFoodInputModel
    {
        [Required(ErrorMessage = "Пожалуйста,укажите название продукта")]   /*правило заполнение формы и сообщение об ошибке*/
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Быстрее)))")]
        public string Name { get; set; }
        public string Measure { get; set; }

        [Required(ErrorMessage = "Пожалуйста,укажите кол-во продукта")]
        [Range(1, int.MaxValue)]
        public int? Count { get; set;}
    }
}
