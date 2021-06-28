// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Auditing.IAuditEntity`1
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

namespace EntityFramework.Toolkit.Auditing
{
  /// <summary>
  ///     Any class used for auditing an entity must implement this inteface.
  /// </summary>
  public interface IAuditEntity<TKey> : IAuditEntity
  {
    /// <summary>The primary key of an audit entry.</summary>
    TKey AuditId { get; set; }
  }
}
