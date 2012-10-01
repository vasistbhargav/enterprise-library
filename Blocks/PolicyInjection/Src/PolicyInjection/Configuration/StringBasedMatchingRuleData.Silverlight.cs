﻿//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Policy Injection Application Block
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================


namespace Microsoft.Practices.EnterpriseLibrary.PolicyInjection.Configuration
{
    /// <summary>
    /// Base class for matching rule configuration data for those rules that take
    /// a single match instance consisting of a string to match and an
    /// ignore case flag.
    /// </summary>
    public abstract partial class StringBasedMatchingRuleData 
    {
        /// <summary>
        /// The string to match.
        /// </summary>
        public virtual string Match
        {
            get;
            set;
        }

        /// <summary>
        /// Should comparisons be case sensitive?
        /// </summary>
        /// <value>If false, comparison is case sensitive. If true, comparison is case insensitive.</value>
        public bool IgnoreCase
        {
            get;
            set;
        }
    }
}