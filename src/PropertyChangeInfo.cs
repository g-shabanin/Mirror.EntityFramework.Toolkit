// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.PropertyChangeInfo
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

namespace EntityFramework.Toolkit
{
  public class PropertyChangeInfo
  {
    public PropertyChangeInfo(string propertyName, object currentValue)
    {
      this.PropertyName = propertyName;
      this.CurrentValue = currentValue;
    }

    public object CurrentValue { get; internal set; }

    public string PropertyName { get; internal set; }
  }
}
