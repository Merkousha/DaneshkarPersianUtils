using System.Globalization;

namespace DaneshkarPersianUtils
{
    public class Core
    {
        // تبدیل تاریخ میلادی به تاریخ شمسی
        public string ConvertToPersianDate(DateTime date)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return $"{persianCalendar.GetYear(date)}/{persianCalendar.GetMonth(date):D2}/{persianCalendar.GetDayOfMonth(date):D2}";
        }

        // دریافت نام روز هفته به فارسی
        public string GetPersianDayOfWeek(DateTime date)
        {
            string[] daysOfWeek = { "یکشنبه", "دوشنبه", "سه‌شنبه", "چهارشنبه", "پنجشنبه", "جمعه", "شنبه" };
            return daysOfWeek[(int)date.DayOfWeek];
        }

        // تبدیل اعداد انگلیسی به فارسی
        public string ConvertToPersianNumbers(string input)
        {
            string[] persianDigits = { "۰", "۱", "۲", "۳", "۴", "۵", "۶", "۷", "۸", "۹" };
            for (int i = 0; i < 10; i++)
            {
                input = input.Replace(i.ToString(), persianDigits[i]);
            }
            return input;
        }

        // تبدیل تاریخ میلادی به رشته فارسی کامل (تاریخ + روز هفته)
        public string GetFullPersianDate(DateTime date)
        {
            string persianDate = ConvertToPersianDate(date);
            string dayOfWeek = GetPersianDayOfWeek(date);
            return $"{dayOfWeek}، {persianDate}";
        }

        // محاسبه فاصله زمانی بین دو تاریخ به زبان فارسی
        public string GetTimeDifference(DateTime date1, DateTime date2)
        {
            TimeSpan difference = date2 - date1;
            if (difference.TotalSeconds < 60)
                return $"{ConvertToPersianNumbers(difference.Seconds.ToString())} ثانیه پیش";
            if (difference.TotalMinutes < 60)
                return $"{ConvertToPersianNumbers(difference.Minutes.ToString())} دقیقه پیش";
            if (difference.TotalHours < 24)
                return $"{ConvertToPersianNumbers(difference.Hours.ToString())} ساعت پیش";
            return $"{ConvertToPersianNumbers((difference.Days).ToString())} روز پیش";
        }

        // تبدیل عدد به حروف فارسی
        public string ConvertNumberToWords(int number)
        {
            if (number == 0) return "صفر";

            string[] ones = { "", "یک", "دو", "سه", "چهار", "پنج", "شش", "هفت", "هشت", "نه" };
            string[] tens = { "", "ده", "بیست", "سی", "چهل", "پنجاه", "شصت", "هفتاد", "هشتاد", "نود" };
            string[] hundreds = { "", "صد", "دویست", "سیصد", "چهارصد", "پانصد", "ششصد", "هفتصد", "هشتصد", "نهصد" };

            string result = "";

            if (number >= 100)
            {
                int hundredPart = number / 100;
                result += hundreds[hundredPart] + " ";
                number %= 100;
            }

            if (number >= 20)
            {
                int tenPart = number / 10;
                result += tens[tenPart] + " ";
                number %= 10;
            }

            if (number > 0)
            {
                result += ones[number] + " ";
            }

            return result.Trim();
        }

        // بررسی سال کبیسه در تقویم شمسی
        public bool IsPersianLeapYear(int year)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            DateTime endOfYear = new DateTime(year, 12, 29, persianCalendar);
            return persianCalendar.GetDayOfMonth(endOfYear) == 30;
        }

        // افزودن روز به تاریخ شمسی
        public string AddDaysToPersianDate(string persianDate, int daysToAdd)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            string[] parts = persianDate.Split('/');
            int year = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int day = int.Parse(parts[2]);

            DateTime date = persianCalendar.ToDateTime(year, month, day, 0, 0, 0, 0);
            DateTime newDate = date.AddDays(daysToAdd);

            return ConvertToPersianDate(newDate);
        }

        // فرمت ساعت به فارسی (مثال: ۱۴:۳۰)
        public string FormatPersianTime(TimeSpan time)
        {
            return $"{ConvertToPersianNumbers(time.Hours.ToString("D2"))}:{ConvertToPersianNumbers(time.Minutes.ToString("D2"))}";
        }
    }
}
