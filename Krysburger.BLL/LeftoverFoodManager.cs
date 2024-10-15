using Krysburger.Core.OutputModels;
namespace Krysburger.BLL
{
    public class LeftoverFoodManager
    {
        public List<LeftoverFoodOutputModel> GetAllLeftoverFood()
        {
            return new List<LeftoverFoodOutputModel>
            {
                new LeftoverFoodOutputModel ()
                {
                    Id=1,
                    Name="Egs",
                    Count=150
                },

                new LeftoverFoodOutputModel ()
                {
                    Id=2,
                    Name="Meat",
                    Count=300
                },

                new LeftoverFoodOutputModel()
                {
                    Id=3,
                    Name="Chicken",
                    Count=200
                },
            };
        }
    }
}

