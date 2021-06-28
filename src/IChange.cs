// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.IChange
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System.Collections.Generic;

namespace EntityFramework.Toolkit
{
  /// <summary>
  ///     Interface for changed objects and object properties.
  /// </summary>
  public interface IChange
  {
    /// <summary>Gets the changed object.</summary>
    /// <value>
    ///     See <see cref="T:System.Object" />.
    /// </value>
    object ChangedEntity { get; }

    /// <summary>
    ///     Gets the names of the properties that have been changed.
    /// </summary>
    /// <value>The names of the properties that have been changed.</value>
    IEnumerable<PropertyChangeInfo> ChangedProperties { get; }

    /// <summary>Gets the state of the changed object.</summary>
    /// <value>
    ///     See <see cref="!:EntityState" />.
    /// </value>
    ChangeState State { get; }
  }
}
