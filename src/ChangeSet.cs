// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.ChangeSet
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace EntityFramework.Toolkit
{
  [DebuggerDisplay("ChangeSet: Context='{this.Context.Name}', Changes={this.Changes.Count()}", Type = "Change")]
  public class ChangeSet
  {
    public static readonly ChangeSet Empty = new ChangeSet((Type) null, (IList<IChange>) new List<IChange>());

    public ChangeSet(Type contextType, IList<IChange> changes)
    {
      this.Context = contextType;
      this.Changes = (IEnumerable<IChange>) changes ?? Enumerable.Empty<IChange>();
    }

    public Type Context { get; private set; }

    public IEnumerable<IChange> Changes { get; private set; }
  }
}
