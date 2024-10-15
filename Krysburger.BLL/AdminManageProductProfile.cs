using Krysburger.Core.OutputModels;

namespace Krysburger.BLL
{
    public class AdminManageProductProfile
    {
        //TODO!!!
        public List<ProductProfileOutputModel> GetAllProfileProducts()
        {
            return new List<ProductProfileOutputModel>
            {
                new ProductProfileOutputModel ()
                {
                    Id=1,
                    Name="Kartoshka",
                    Description="Base product",
                    Category="Vegetable",
                    Cost=150
                },

                new ProductProfileOutputModel ()
                {
                    Id=2,
                    Name="Bulochka",
                    Description="Base product",
                    Category="Bread",
                    Cost=180
                },

                new ProductProfileOutputModel ()
                {
                    Id=3,
                    Name="Kurochka",
                    Description="Base product",
                    Category="Meat",
                    Cost=380
                },

                new ProductProfileOutputModel ()
                {
                    Id=4,
                    Name="Coke",
                    Description="Base product",
                    Category="Drinks",
                    Cost=380
                },

                new ProductProfileOutputModel ()
                {
                    Id=5,
                    Name="Water",
                    Description="Base product",
                    Category="Drinks",
                    Cost=80
                },

                new ProductProfileOutputModel ()
                {   
                    Id=6,
                    Name="Cheese",
                    Description="Base product",
                    Category="Dairy products",
                    Cost=350
                },
            };
        }
    }
}
