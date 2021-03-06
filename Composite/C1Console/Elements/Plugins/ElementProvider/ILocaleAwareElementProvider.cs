﻿using System.Collections.Generic;
using Composite.C1Console.Elements.Plugins.ElementProvider;
using Composite.C1Console.Security;

// The namespace is wrong but is left for backwards compatibility
namespace Composite.C1Console.Elements
{
    /// <summary>    
    /// </summary>
    /// <exclude />
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)] 
    public interface ILocaleAwareElementProvider : IHooklessElementProvider
    {
        /// <exclude />
        bool ContainsLocalizedData { get; }

        /// <exclude />
        IEnumerable<Element> GetForeignRoots(SearchToken searchToken);

        /// <exclude />
        IEnumerable<Element> GetForeignChildren(EntityToken entityToken, SearchToken searchToken);
    }
}
