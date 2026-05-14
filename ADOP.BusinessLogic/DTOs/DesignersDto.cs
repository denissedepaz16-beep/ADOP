namespace ADOP.BusinessLogic.DTOs
{
    public class CreateBrandRequest
    {
        public string FullName { get; set; } = null!;
    }

    public class UpdateBrandRequest
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

    }

    public class BrandResponse
    {
        public int Id { get; set; }

        public string FullName { get; set; } = null!;

    }


}
