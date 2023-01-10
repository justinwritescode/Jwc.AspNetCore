/*
 * OKAttributes.cs
 *
 *   Created: 2023-01-05-04:48:16
 *   Modified: 2023-01-05-04:48:16
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.AspNetCore.Mvc;

using Swashbuckle.AspNetCore.Annotations;
using static Microsoft.AspNetCore.Http.StatusCodes;

public class ProducesOKResponseAttribute : SwaggerResponseAttribute
{
    public ProducesOKResponseAttribute(
        type modelType,
        string description = "The request was successful"
    )
        : base(
            Status200OK,
            description ?? "The request was successful",
            modelType,
            ApplicationMediaTypeNames.Json,
            ApplicationMediaTypeNames.Xml,
            ApplicationMediaTypeNames.MessagePack,
            ApplicationMediaTypeNames.Bson,
            TextMediaTypeNames.Plain
        ) { }
}

public class ProducesNoContentResponseAttribute : SwaggerResponseAttribute
{
    public ProducesNoContentResponseAttribute(
        string description = "The request was successful and produced no content."
    )
        : base(
            Status204NoContent,
            description ?? "The request was successful and produced no content.",
            null,
            ApplicationMediaTypeNames.Json,
            ApplicationMediaTypeNames.Xml,
            ApplicationMediaTypeNames.MessagePack,
            ApplicationMediaTypeNames.Bson,
            TextMediaTypeNames.Plain
        ) { }
}

public class ProducesCreatedResponseAttribute : SwaggerResponseAttribute
{
    public ProducesCreatedResponseAttribute(
        type modelType,
        string description = "The resource was created successfully."
    )
        : base(
            Status201Created,
            description ?? "The resource was created successfully.",
            modelType,
            ApplicationMediaTypeNames.Json,
            ApplicationMediaTypeNames.Xml,
            ApplicationMediaTypeNames.MessagePack,
            ApplicationMediaTypeNames.Bson,
            TextMediaTypeNames.Plain
        ) { }
}

public class ProducesPartialContentResponseAttribute : SwaggerResponseAttribute
{
    public ProducesPartialContentResponseAttribute(
        type modelType,
        string description = "The resource was created successfully."
    )
        : base(
            Status206PartialContent,
            description ?? "The resource was created successfully.",
            modelType,
            ApplicationMediaTypeNames.Json,
            ApplicationMediaTypeNames.Xml,
            ApplicationMediaTypeNames.MessagePack,
            ApplicationMediaTypeNames.Bson,
            TextMediaTypeNames.Plain
        ) { }
}

public class CreateOperationAttribute : JwcOperationAttribute
{
    public CreateOperationAttribute(
        string? operationId = null,
        string? summary = "Create a new resource",
        string? description = "Create a new resource",
        string[]? tags = null
    )
    {
        OperationId = operationId;
        Summary = summary ?? operationId;
        Description = description ?? summary;
        Tags = tags ?? new[] { operationId, "Create/Insert" };
    }
}

public class UpdateOperationAttribute : JwcOperationAttribute
{
    public UpdateOperationAttribute(
        string? operationId = null,
        string? summary = "Update an existing resource from a complete model object",
        string? description = "Update an existing resource from a complete model object",
        string[]? tags = null
    )
    {
        OperationId = operationId;
        Summary = summary ?? operationId;
        Description = description ?? summary;
        Tags = tags ?? new[] { operationId, "Update" };
    }
}

public class DeleteOperationAttribute : JwcOperationAttribute
{
    public DeleteOperationAttribute(
        string? operationId = null,
        string? summary = "Delete an existing resource",
        string? description = "Delete an existing resource",
        string[]? tags = null
    )
    {
        OperationId = operationId;
        Summary = summary ?? operationId;
        Description = description ?? summary;
        Tags = tags ?? new[] { operationId, "Delete" };
    }
}

public class PatchOperationAttribute : JwcOperationAttribute
{
    public PatchOperationAttribute(
        string? operationId = null,
        string? summary = "Update an existing resource from a partial model object",
        string? description = "Update an existing resource from a partial model object",
        string[]? tags = null
    )
    {
        OperationId = operationId;
        Summary = summary ?? operationId;
        Description = description ?? summary;
        Tags = tags ?? new[] { operationId, "Update" };
    }
}

public class JwcOperationAttribute : SwaggerOperationAttribute
{
    public JwcOperationAttribute(
        string? operationId = null,
        string? summary = null,
        string? description = null,
        string[]? tags = null
    )
    {
        OperationId = operationId;
        Summary = summary ?? operationId;
        Description = description ?? summary;
        Tags = tags ?? new[] { operationId };
    }
}
