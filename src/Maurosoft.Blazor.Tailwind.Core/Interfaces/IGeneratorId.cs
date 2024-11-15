using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maurosoft.Blazor.Tailwind.Core.Interfaces;

/// <summary>
/// An interface that generates unique IDs.
/// </summary>
public interface IGeneratorId
{
    #region Methods

    /// <summary>
    /// Gets the next unique ID.
    /// </summary>
    string GetNextId(string prefiss = "");

    #endregion
}
