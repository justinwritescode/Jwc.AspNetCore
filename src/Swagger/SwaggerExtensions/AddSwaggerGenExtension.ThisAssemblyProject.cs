/*
 * AddSwaggerGenExtension.cs
 *
 *   Created: 2022-12-05-07:35:08
 *   Modified: 2022-12-05-07:35:08
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using static System.String;

public record ThisAssemblyProject(type TThisAssemblyProject)
{
    public string? AssemblyVersion =>
        TThisAssemblyProject.GetRuntimeField(nameof(AssemblyVersion))?.GetValue(null) as string;
    public string? Authors =>
        TThisAssemblyProject.GetRuntimeField(nameof(Authors))?.GetValue(null) as string;
    public string? Company =>
        TThisAssemblyProject.GetRuntimeField(nameof(Company))?.GetValue(null) as string;
    public string? ContactEmail =>
        TThisAssemblyProject.GetRuntimeField(nameof(ContactEmail))?.GetValue(null) as string;
    public string? Copyright =>
        TThisAssemblyProject.GetRuntimeField(nameof(Copyright))?.GetValue(null) as string;
    public string? Description =>
        TThisAssemblyProject.GetRuntimeField(nameof(Description))?.GetValue(null) as string;
    public string? FileVersion =>
        TThisAssemblyProject.GetRuntimeField(nameof(FileVersion))?.GetValue(null) as string;
    public string? InformationalVersion =>
        TThisAssemblyProject.GetRuntimeField(nameof(InformationalVersion))?.GetValue(null)
        as string;
    public string? LicenseExpression =>
        TThisAssemblyProject.GetRuntimeField(nameof(LicenseExpression))?.GetValue(null) as string
        ?? this.PackageLicenseExpression;
    public string? Owners =>
        TThisAssemblyProject.GetRuntimeField(nameof(Owners))?.GetValue(null) as string;
    public string? PackageLicenseExpression =>
        TThisAssemblyProject.GetRuntimeField(nameof(PackageLicenseExpression))?.GetValue(null)
        as string;
    public string? PackageTags =>
        TThisAssemblyProject.GetRuntimeField(nameof(PackageTags))?.GetValue(null) as string;
    public string? PackageVersion =>
        TThisAssemblyProject.GetRuntimeField(nameof(PackageVersion))?.GetValue(null) as string;
    public string? Product =>
        TThisAssemblyProject.GetRuntimeField(nameof(Product))?.GetValue(null) as string;
    public string? SwaggerTheme =>
        TThisAssemblyProject.GetRuntimeField(nameof(SwaggerTheme))?.GetValue(null) as string;
    public string? Title =>
        TThisAssemblyProject.GetRuntimeField(nameof(Title))?.GetValue(null) as string;
    public string? Version =>
        TThisAssemblyProject.GetRuntimeField(nameof(Version))?.GetValue(null) as string;
    public uri? LicenseUrl => $"https://opensource.org/licenses/{LicenseExpression}";
    public uri? PackageProjectUrl =>
        TThisAssemblyProject.GetRuntimeField(nameof(PackageProjectUrl))?.GetValue(null) as string
        ?? "https://example.com/contact";
    public uri? RepositoryUrl =>
        TThisAssemblyProject.GetRuntimeField(nameof(RepositoryUrl))?.GetValue(null) as string
        ?? "about:blank";
    public uri? TermsOfServiceUrl =>
        TThisAssemblyProject.GetRuntimeField(nameof(TermsOfServiceUrl))?.GetValue(null) as string
        ?? "https://example.com/terms";
    public string? ApiVersion =>
        "v"
        + (
            IsNullOrEmpty(PackageVersion)
                ? IsNullOrEmpty(FileVersion)
                    ? IsNullOrEmpty(Version)
                        ? IsNullOrEmpty(AssemblyVersion)
                            ? "0.0.1-Preview"
                            : AssemblyVersion
                        : Version
                    : FileVersion
                : PackageVersion
        );
}
