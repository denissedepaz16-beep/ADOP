using ADOP.Entities;

namespace ADOP.BusinessLogic.DTOs;

public class CreateProductRequest
{
    public int DesignerId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? MarketPrice { get; set; }

    public int? Quantity { get; set; }
}

public class UpdateProductRequest
{
    public long Id { get; set; }

    public int DesignerId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? MarketPrice { get; set; }

    public int? Quantity { get; set; }
}

public class ProductoResponse
{
    public long Id { get; set; }

    public int DesignerId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? MarketPrice { get; set; }

    public int? Quantity { get; set; }
}


public class ProductByIdResponse
{
    public long Id { get; set; }

    public int DesignerId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? MarketPrice { get; set; }

    public int? Quantity { get; set; }
}