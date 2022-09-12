namespace ECommerce.Api.Products.Profiles
{


  //To define mapping between Product model and Product Entity.
  public class ProductProfile : AutoMapper.Profile
  {
    public ProductProfile()
    {
      CreateMap<Db.Product, Models.Product>();
    }
  }
}