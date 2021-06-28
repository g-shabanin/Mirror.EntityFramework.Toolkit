// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.IDataSeed
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Linq.Expressions;

namespace EntityFramework.Toolkit
{
  public interface IDataSeed
  {
    /// <summary>
    /// Gets the expression which checks if there are existing seed entries.
    /// Depending on the result, the seed entry is added or updated.
    /// </summary>
    Expression<Func<object, object>> GetAddOrUpdateExpression();

    /// <summary>The type of the entity for which this seed is used.</summary>
    Type EntityType { get; }

    /// <summary>The seed data as a list of objects.</summary>
    object[] GetAllObjects();
  }
}
