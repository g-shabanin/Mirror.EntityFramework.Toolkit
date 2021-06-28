// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.IQueryableIncluding`1
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFramework.Toolkit
{
  public interface IQueryableIncluding<T> : IQueryable<T>, IEnumerable<T>, IEnumerable, IQueryable
  {
    IQueryableIncluding<T> Include(string includePath);

    IQueryableIncluding<T> Include(Expression<Func<T, object>> includExpression);

    IQueryableIncluding<T> IncludeAllRelated();

    IQueryableIncluding<T> IncludeAllRelatedDerived();
  }
}
