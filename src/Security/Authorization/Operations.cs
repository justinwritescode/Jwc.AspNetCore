namespace JustinWritesCode.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization.Infrastructure;

public partial class Operations : OperationAuthorizationRequirement
{
    public virtual bool Equals(Operations? other) => other is OperationAuthorizationRequirement oar && oar.Name == other.Name;
    override public bool Equals(object? obj) => Equals(obj as OperationAuthorizationRequirement);
    override public int GetHashCode() => Name.GetHashCode();

    public static bool operator ==(Operations left, Operations right)
    {
        if (ReferenceEquals(left, null))
        {
            return ReferenceEquals(right, null);
        }

        return left.Equals(right);
    }

    public static bool operator !=(Operations left, Operations right)
    {
        return !(left == right);
    }
}
