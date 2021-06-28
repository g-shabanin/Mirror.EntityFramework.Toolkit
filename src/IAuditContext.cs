// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.IAuditContext
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Threading.Tasks;

namespace EntityFramework.Toolkit
{
  public interface IAuditContext : IContext, IDisposable
  {
    /// <summary>Specifies if the auditing feature is enabled.</summary>
    bool AuditEnabled { get; }

    /// <summary>
    ///     Saves all changes made in this context to the underlying database.
    /// </summary>
    /// <returns>The number of objects written to the underlying database.</returns>
    /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
    ChangeSet SaveChanges(string username);

    /// <summary>
    ///     Saves all changes made in this context to the underlying database.
    /// </summary>
    /// <returns>The number of objects written to the underlying database.</returns>
    /// <exception cref="T:System.InvalidOperationException">Thrown if the context has been disposed.</exception>
    Task<ChangeSet> SaveChangesAsync(string username);
  }
}
