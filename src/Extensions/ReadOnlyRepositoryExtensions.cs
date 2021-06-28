﻿// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Extensions.ReadOnlyRepositoryExtensions
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFramework.Toolkit.Extensions
{
  public static class ReadOnlyRepositoryExtensions
  {
    /// <summary>
    ///     Indicates whether an entity with the given primary key value exists.
    /// </summary>
    /// <param name="ids">The primary keys of the entity to be found.</param>
    /// <returns>true, if an entity with given primary key exists; otherwise, false.</returns>
    public static bool Any<T>(this IReadOnlyRepository<T> repository, params object[] ids) => (object) repository.FindById(ids) != null;

    /// <summary>
    ///     Indicates whether an entity which matches the given predicate exists.
    /// </summary>
    /// <param name="predicate">The predicate to filter the entity.</param>
    /// <returns>true, if an entity exists for given predicate; otherwise, false.</returns>
    public static bool Any<T>(
      this IReadOnlyRepository<T> repository,
      Expression<Func<T, bool>> predicate)
    {
      return repository.Get().Any<T>(predicate);
    }
  }
}
