﻿using System.Runtime.CompilerServices;

/*
 * IsExternalInit.cs
 *
 *   Created: 2022-12-24-05:42:32
 *   Modified: 2022-12-24-05:42:32
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace System.Runtime.CompilerServices
{
    internal class IsExternalInit { }

    internal class RequiredMemberAttribute : Attribute { }

    internal class CompilerFeatureRequiredAttribute : Attribute
    {
        public CompilerFeatureRequiredAttribute(string feature) { }
    }
}

namespace System.Diagnostics.CodeAnalysis
{
    internal class SetsRequiredMembersAttribute : Attribute
    {
        public SetsRequiredMembersAttribute() { }

        public SetsRequiredMembersAttribute(string members) { }

        public SetsRequiredMembersAttribute(params string[] members) { }
    }
}
