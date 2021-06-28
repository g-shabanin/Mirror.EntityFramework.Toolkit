// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Auditing.AuditEntity
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;

namespace EntityFramework.Toolkit.Auditing
{
  /// <summary>Base class for audit entities.</summary>
  public abstract class AuditEntity : IAuditEntity<int>, IAuditEntity
  {
    public int AuditId { get; set; }

    /// <summary>
    ///     Gets or sets the DateTime this audit entity was created.
    ///     Will be automatically set by AuditDbContext on SaveChanges.
    /// </summary>
    public virtual DateTime AuditDate { get; set; }

    /// <summary>
    ///     Gets or sets the user who updated the entity
    ///     Will be automatically set by AuditDbContext on SaveChanges.
    /// </summary>
    public virtual string AuditUser { get; set; }

    /// <summary>
    ///     Gets or sets the type of audit. 0 for update, 1 for deletion.
    ///     Will be automatically set by AuditDbContext on SaveChanges.
    /// </summary>
    public virtual AuditEntityState AuditType { get; set; }
  }
}
