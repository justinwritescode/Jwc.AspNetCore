/*
 * AddXmlCommentsToSwaggerExtensions.cs
 *
 *   Created: 2022-12-14-03:59:45
 *   Modified: 2022-12-14-03:59:45
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

using System.Reflection;
using System.Xml.Linq;
using Microsoft.AspNetCore.Builder;
using Unchase.Swashbuckle.AspNetCore.Extensions.Extensions;
using Unchase.Swashbuckle.AspNetCore.Extensions.Filters;

namespace Microsoft.Extensions.DependencyInjection;

public static class AddXmlCommentsToSwaggerExtensions
{
    public static WebApplicationBuilder AddXmlCommentsToSwagger(this WebApplicationBuilder builder)
    {
        var binRoot = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        var xmlDocs = Directory.GetFiles(binRoot, "*.xml");
        builder.Services.ConfigureSwaggerGen(options =>
        {
            Array.ForEach(xmlDocs, xmlDoc =>
            {
                try
                {
                    var xDoc = XDocument.Load(xmlDoc);
                    options.IncludeXmlCommentsWithRemarks(xmlDoc);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error in file {xmlDoc}: {ex.Message}");
                }
            });
            options.IncludeXmlCommentsFromInheritDocs(true);

            // or configured:
            _ = options.AddEnumsWithValuesFixFilters(o =>
            {
                // add schema filter to fix enums (add 'x-enumNames' for NSwag or its alias from XEnumNamesAlias) in schema
                o.ApplySchemaFilter = true;

                // alias for replacing 'x-enumNames' in swagger document
                o.XEnumNamesAlias = "x-enum-varnames";

                // alias for replacing 'x-enumDescriptions' in swagger document
                o.XEnumDescriptionsAlias = "x-enum-descriptions";

                // add parameter filter to fix enums (add 'x-enumNames' for NSwag or its alias from XEnumNamesAlias) in schema parameters
                o.ApplyParameterFilter = true;

                // add document filter to fix enums displaying in swagger document
                o.ApplyDocumentFilter = true;

                // add descriptions from DescriptionAttribute or xml-comments to fix enums (add 'x-enumDescriptions' or its alias from XEnumDescriptionsAlias for schema extensions) for applied filters
                o.IncludeDescriptions = true;

                // add remarks for descriptions from xml-comments
                o.IncludeXEnumRemarks = true;

                // get descriptions from DescriptionAttribute then from xml-comments
                o.DescriptionSource = DescriptionSources.DescriptionAttributesThenXmlComments;

                // new line for enum values descriptions
                // o.NewLine = Environment.NewLine;
                o.NewLine = "\n";

                // get descriptions from xml-file comments on the specified path
                // should use "options.IncludeXmlComments(xmlFilePath);" before
                Array.ForEach(xmlDocs, xmlDoc => o.IncludedXmlCommentsPaths.Add(xmlDoc));
                // the same for another xml-files...
            });

            // enable openApi Annotations
            options.EnableAnnotations();

            // add action count (with message template) into the SwaggerTag's descriptions
            // you can use it after "HidePathsAndDefinitionsByRolesDocumentFilter"
            options.DocumentFilter<AppendActionCountToTagSummaryDocumentFilter>("(count: {0})");

            // enable openApi Annotations
            options.EnableAnnotations();

            // add action count (with message template) into the SwaggerTag's descriptions
            // you can use it after "HidePathsAndDefinitionsByRolesDocumentFilter"
            options.DocumentFilter<AppendActionCountToTagSummaryDocumentFilter>("(count: {0})");

            // order tags by name
            options.DocumentFilter<TagOrderByNameDocumentFilter>();
        });

        return builder;
    }
}
