// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.Auditing.AuditEntityState
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;

namespace EntityFramework.Toolkit.Auditing
{
  /// <summary>Describes the state of an audit entity.</summary>
  [Flags]
  public enum AuditEntityState
  {
    Added = 4,
    Deleted = 8,
    Modified = 16, // 0x00000010
  }
}
