namespace ADOP.BusinessLogic.DTOs;


public class UserResponse
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string Handle { get; set; } = null!;

    public string? SecretHash { get; set; }
}

public class CreateUserRequest
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string Handle { get; set; } = null!;

    public string? SecretHash { get; set; }
}


public class UpdateUserRequest
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string Handle { get; set; } = null!;

    public string? SecretHash { get; set; }
}

public class RoleResponse
{
    public int Id { get; set; }

    public string? PositionName { get; set; }

}


public class UserByIdResponse
{
    public int Id { get; set; }

    public int RoleId { get; set; }

    public string Handle { get; set; } = null!;

    public string? SecretHash { get; set; }
}
