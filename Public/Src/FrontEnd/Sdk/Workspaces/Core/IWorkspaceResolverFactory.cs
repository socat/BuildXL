// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Diagnostics.ContractsLight;
using BuildXL.Utilities;
using JetBrains.Annotations;
using BuildXL.Utilities.Configuration;

namespace BuildXL.FrontEnd.Workspaces.Core
{
    /// <summary>
    /// Factory interface for creating resolvers based on their kind
    /// </summary>
    public interface IWorkspaceResolverFactory<T>
    {
        /// <summary>
        /// Returns a resolver using a specific resolverSettings.
        /// </summary>
        /// <remarks>
        /// The factory implementation may decide to create a module resolver or return an already created one.
        /// </remarks>
        [NotNull]
        Possible<T> TryGetResolver([NotNull]IResolverSettings resolverSettings);
    }
}
