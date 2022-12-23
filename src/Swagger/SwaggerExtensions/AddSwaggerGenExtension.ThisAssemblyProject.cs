/*
 * AddSwaggerGenExtension.cs
 *
 *   Created: 2022-12-05-07:35:08
 *   Modified: 2022-12-05-07:35:08
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;


public record ThisAssemblyProject(Type TThisAssemblyProject)
{
    public string? AssemblyVersion => TThisAssemblyProject.GetRuntimeField("AssemblyVersion")?.GetValue(null) as string;
    public string? Authors => TThisAssemblyProject.GetRuntimeField("Authors")?.GetValue(null) as string;
    public string? Company => TThisAssemblyProject.GetRuntimeField("Company")?.GetValue(null) as string;
    public string? ContactEmail => TThisAssemblyProject.GetRuntimeField("ContactEmail")?.GetValue(null) as string;
    public string? Copyright => TThisAssemblyProject.GetRuntimeField("Copyright")?.GetValue(null) as string;
    public string? Description => TThisAssemblyProject.GetRuntimeField("Description")?.GetValue(null) as string;
    public string? FileVersion => TThisAssemblyProject.GetRuntimeField("FileVersion")?.GetValue(null) as string;
    public string? InformationalVersion => TThisAssemblyProject.GetRuntimeField("InformationalVersion")?.GetValue(null) as string;
    public string? LicenseExpression => TThisAssemblyProject.GetRuntimeField("LicenseExpression")?.GetValue(null) as string;
    public string? Owners => TThisAssemblyProject.GetRuntimeField("Owners")?.GetValue(null) as string;
    public string? PackageProjectUrl => TThisAssemblyProject.GetRuntimeField("PackageProjectUrl")?.GetValue(null) as string ?? "about:blank";
    public string? PackageTags => TThisAssemblyProject.GetRuntimeField("PackageTags")?.GetValue(null) as string;
    public string? PackageVersion => TThisAssemblyProject.GetRuntimeField("PackageVersion")?.GetValue(null) as string;
    public string? Product => TThisAssemblyProject.GetRuntimeField("Product")?.GetValue(null) as string;
    public string? RepositoryUrl => TThisAssemblyProject.GetRuntimeField("RepositoryUrl")?.GetValue(null) as string ?? "about:blank";
    public string? SwaggerTheme => TThisAssemblyProject.GetRuntimeField(nameof(SwaggerTheme))?.GetValue(null) as string;
    public string? TermsOfServiceUrl => TThisAssemblyProject.GetRuntimeField("TermsOfServiceUrl")?.GetValue(null) as string ?? "about:blank";
    public string? Title => TThisAssemblyProject.GetRuntimeField("Title")?.GetValue(null) as string;
    public string? Version => TThisAssemblyProject.GetRuntimeField("Version")?.GetValue(null) as string;
}
