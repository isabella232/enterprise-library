﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Logging Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace Microsoft.Practices.EnterpriseLibrary.Logging.Configuration
{
    /// <summary>
    /// A class that handles the entries for the &lt;categories&gt; element
    /// for the Log Call handler.
    /// </summary>
    public partial class LogCallHandlerCategoryEntry : NamedConfigurationElement
    {
        /// <summary>
        /// Construct an empty <see cref="LogCallHandlerCategoryEntry"/>.
        /// </summary>
        public LogCallHandlerCategoryEntry()
        {
        }

        /// <summary>
        /// Construct a <see cref="LogCallHandlerCategoryEntry"/> with the given
        /// category string.
        /// </summary>
        /// <param name="name">Category string.</param>
        public LogCallHandlerCategoryEntry(string name) : base(name)
        {
        }
    }
}