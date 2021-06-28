// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Change
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EntityFramework.Toolkit
{
  [DebuggerDisplay("ChangedEntity='{ChangedEntity}', State={State}", Type = "Change")]
  public class Change : IChange
  {
    private Change(object changedEntity, ChangeState state)
      : this(changedEntity, state, (IEnumerable<PropertyChangeInfo>) null)
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="T:EntityFramework.Toolkit.Change" /> class.
    /// </summary>
    /// <param name="changedEntity">The changed object.</param>
    /// <param name="changedProperties">
    ///     The List of the properties that have been changed.
    /// </param>
    /// <exception cref="T:System.ArgumentNullException">
    ///     Thrown if the specified <paramref name="changedEntity" /> is null.
    /// </exception>
    /// 
    ///             .
    ///             <exception cref="T:System.ArgumentNullException">
    ///     Thrown if the specified <paramref name="changedProperties" /> is null.
    /// </exception>
    private Change(
      object changedEntity,
      ChangeState state,
      IEnumerable<PropertyChangeInfo> changedProperties)
    {
      if (changedEntity == null)
        throw new ArgumentNullException(nameof (changedEntity));
      if (state == ChangeState.Modified && changedProperties == null)
        throw new ArgumentNullException(string.Format("Parameter {0} must be defined if ChangeState is Modified.", (object) nameof (changedProperties)), nameof (changedProperties));
      this.ChangedEntity = changedEntity;
      this.ChangedProperties = changedProperties;
      this.State = state;
    }

    public object ChangedEntity { get; private set; }

    public IEnumerable<PropertyChangeInfo> ChangedProperties { get; private set; }

    public ChangeState State { get; private set; }

    public static IChange CreateUpdateChange(
      object changedEntity,
      IEnumerable<PropertyChangeInfo> changedProperties)
    {
      return (IChange) new Change(changedEntity, ChangeState.Modified, changedProperties);
    }

    public static IChange CreateDeleteChange(object changedEntity) => (IChange) new Change(changedEntity, ChangeState.Deleted);

    public static IChange CreateAddedChange(object changedEntity) => (IChange) new Change(changedEntity, ChangeState.Added);
  }
}
