// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.IDbConnection
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

namespace EntityFramework.Toolkit
{
  public interface IDbConnection
  {
    string Name { get; }

    string ConnectionString { get; }

    bool LazyLoadingEnabled { get; set; }

    bool ProxyCreationEnabled { get; set; }

    bool ForceInitialize { get; }
  }
}
