using System.Globalization;

namespace Shared.Helpers;

public static class DateTimeHelper
{
    public static DateTime GetStandardDate() =>
        new DateTime().ToUniversalTime();

    public static DateTime GetStandardDate(int year, int month, int day) =>
        new DateTime(year, month, day).ToUniversalTime();

    public static DateTime GetStandardDate(DateTime dateTime) =>
        dateTime.ToUniversalTime();

    public static string ToStandardString(this DateTime dateTime) =>
        dateTime.ToString(DateTimeFormatInfo.InvariantInfo);

    public static string? ToStandardString(this DateTime? dateTime) =>
        dateTime.HasValue ? dateTime.Value.ToStandardString() : null;

    public static string ToStandardString(this DateOnly date) =>
        date.ToString(DateTimeFormatInfo.InvariantInfo);

    public static string? ToStandardString(this DateOnly? date) =>
        date.HasValue ? date.Value.ToStandardString() : null;

    public static DateTime FromStandardString(this string dateTime) =>
        DateTime.Parse(dateTime, DateTimeFormatInfo.InvariantInfo, DateTimeStyles.AssumeUniversal);
}