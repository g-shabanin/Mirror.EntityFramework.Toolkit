﻿// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Extensions.GenericRepositoryExtensions
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFramework.Toolkit.Extensions
{
  public static class GenericRepositoryExtensions
  {
    /// <summary>
    ///     Marks the the entity with the given primary key as Deleted such that it will be deleted from the database when
    ///     SaveChanges is called. Note that the entity must exist in the context in some other state before this method
    ///     is called.
    /// </summary>
    /// <returns> The entity that has been removed.</returns>
    /// <remarks>
    ///     Note that if the entity exists in the context in the Added state, then this method
    ///     will cause it to be detached from the context.  This is because an Added entity is assumed not to
    ///     exist in the database such that trying to delete it does not make sense.
    /// </remarks>
    public static T RemoveById<T>(this IGenericRepository<T> repository, params object[] ids)
    {
      T byId = repository.FindById(ids);
      return (object) byId != null ? repository.Remove(byId) : throw new ArgumentOutOfRangeException(nameof (ids));
    }

    /// <summary>
    ///     Removes the given collection of entities from the context underlying the set with each entity being put into
    ///     the Deleted state such that it will be deleted from the database when SaveChanges is called.
    /// </summary>
    /// <param name="entities">The collection of entities to delete.</param>
    /// <returns>The collection of entities.</returns>
    /// <remarks>
    ///     Note that if <see cref="P:System.Data.Entity.Infrastructure.DbContextConfiguration.AutoDetectChangesEnabled" /> is
    ///     set to true (which is the default), then DetectChanges will be called once before delete any entities and will not be called
    ///     again. This means that in some situations RemoveRange may perform significantly better than calling
    ///     Remove multiple times would do.
    ///     Note that if any entity exists in the context in the Added state, then this method
    ///     will cause it to be detached from the context.  This is because an Added entity is assumed not to
    ///     exist in the database such that trying to delete it does not make sense.
    /// </remarks>
    public static IEnumerable<T> RemoveRange<T>(
      this IGenericRepository<T> repository,
      IEnumerable<T> entities)
    {
      return (IEnumerable<T>) entities.Select<T, T>(new Func<T, T>(repository.Remove)).ToList<T>();
    }

    /// <summary>Removes all entities that match the conditions defined by the given predicate.</summary>
    /// <returns>The removed entities.</returns>
    /// <param name="predicate">The expression that defines the conditions of the elements to remove.</param>
    /// <exception cref="T:System.ArgumentNullException">
    ///     <paramref name="predicate" /> is null.
    /// </exception>
    public static IEnumerable<T> RemoveAll<T>(
      this IGenericRepository<T> repository,
      Expression<Func<T, bool>> predicate = null)
    {
      IQueryable<T> source = repository.Get();
      if (predicate != null)
        source = source.Where<T>(predicate);
      return repository.RemoveRange<T>((IEnumerable<T>) source);
    }
  }
}
