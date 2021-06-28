// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.IUnitOfWork
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EntityFramework.Toolkit
{
  public interface IUnitOfWork : IDisposable
  {
    void RegisterContext<TContext>(TContext contextFactory) where TContext : IContext;

    /// <summary>Saves pending changes to all registered contexts.</summary>
    /// <returns>The total number of objects committed.</returns>
    ICollection<ChangeSet> Commit();

    /// <summary>Saves pending changes to all registered contexts.</summary>
    /// <returns>The total number of objects committed.</returns>
    Task<ICollection<ChangeSet>> CommitAsync();
  }
}
