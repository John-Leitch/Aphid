using System;

namespace Components
{
    public static class DateTimeExtension
    {
        private static readonly TimeZoneInfo
            _pstTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time"),
            _estTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time");

        public static DateTime ToPacificStandardTime(this DateTime dt) =>
            TimeZoneInfo.ConvertTime(dt, _pstTimeZone);

        public static DateTime ToEasternStandardTime(this DateTime dt) =>
            TimeZoneInfo.ConvertTime(dt, _estTimeZone);
    }
}
