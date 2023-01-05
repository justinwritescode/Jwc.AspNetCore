namespace JustinWritesCode.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;

public partial class Operations : OperationAuthorizationRequirement
{
    public virtual bool Equals(Operations? other) => other is OperationAuthorizationRequirement oar && oar.Name == other.Name;
    override public bool Equals(object? obj) => Equals(obj as OperationAuthorizationRequirement);
    override public int GetHashCode() => Name.GetHashCode();
}
