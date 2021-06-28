// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Auditing.IAuditEntity
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;

namespace EntityFramework.Toolkit.Auditing
{
  public interface IAuditEntity
  {
    /// <summary>
    ///     Gets or sets the DateTime this audit entity was created.
    /// </summary>
    /// <remarks>
    ///     Will be automatically set by AuditDbContext on SaveChanges.
    /// </remarks>
    DateTime AuditDate { get; set; }

    /// <summary>Gets or sets the user who updated the entity</summary>
    /// <remarks>
    ///     Will be automatically set by AuditDbContext on SaveChanges.
    /// </remarks>
    string AuditUser { get; set; }

    /// <summary>Gets or sets the type of audit.</summary>
    /// <remarks>
    ///     Will be automatically set by AuditDbContext on SaveChanges.
    /// </remarks>
    AuditEntityState AuditType { get; set; }
  }
}
