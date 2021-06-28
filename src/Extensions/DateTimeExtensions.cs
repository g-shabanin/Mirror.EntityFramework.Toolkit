// Decompiled with JetBrains decompiler
// Type: EntityFramework.Toolkit.DateTimeExtensions
// Assembly: EntityFramework.Toolkit.Core, Version=1.0.6.0, Culture=neutral, PublicKeyToken=null
// MVID: 83363AEA-5F39-4A80-AB2C-46D90A9D56DD
// Assembly location: C:\13\EntityFramework.Toolkit.Core.dll

using System;

namespace EntityFramework.Toolkit
{
  public static class DateTimeExtensions
  {
    public static DateTime ToKind(this DateTime value, DateTimeKind kind)
    {
      switch (kind)
      {
        case DateTimeKind.Unspecified:
          return value.SpecifyKind(kind);
        case DateTimeKind.Utc:
          return value.ToKindUtc();
        case DateTimeKind.Local:
          return value.ToKindLocal();
        default:
          throw new InvalidOperationException(string.Format("Cannot convert to DateTimeKind.{0}", (object) kind));
      }
    }

    public static DateTime ToKindUtc(this DateTime value) => DateTimeExtensions.KindUtc(value);

    public static DateTime? ToKindUtc(this DateTime? value) => DateTimeExtensions.KindUtc(value);

    public static DateTime ToKindLocal(this DateTime value) => DateTimeExtensions.KindLocal(value);

    public static DateTime? ToKindLocal(this DateTime? value) => DateTimeExtensions.KindLocal(value);

    public static DateTime SpecifyKind(this DateTime value, DateTimeKind kind) => value.Kind != kind ? DateTime.SpecifyKind(value, kind) : value;

    public static DateTime? SpecifyKind(this DateTime? value, DateTimeKind kind) => value.HasValue ? new DateTime?(DateTime.SpecifyKind(value.Value, kind)) : new DateTime?();

    public static DateTime KindUtc(DateTime value)
    {
      if (value.Kind == DateTimeKind.Unspecified)
        return DateTime.SpecifyKind(value, DateTimeKind.Utc);
      return value.Kind == DateTimeKind.Local ? value.ToUniversalTime() : value;
    }

    public static DateTime? KindUtc(DateTime? value) => value.HasValue ? new DateTime?(DateTimeExtensions.KindUtc(value.Value)) : new DateTime?();

    public static DateTime KindLocal(DateTime value)
    {
      if (value.Kind == DateTimeKind.Unspecified)
        return DateTime.SpecifyKind(value, DateTimeKind.Local);
      return value.Kind == DateTimeKind.Utc ? value.ToLocalTime() : value;
    }

    public static DateTime? KindLocal(DateTime? value) => value.HasValue ? new DateTime?(DateTimeExtensions.KindLocal(value.Value)) : new DateTime?();
  }
}
