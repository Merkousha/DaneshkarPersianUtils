# PersianUtilities

`PersianUtilities` is a simple and lightweight .NET library that provides essential utilities for Persian date formatting, number conversion, and other related functionalities. It is designed to make handling Persian (Farsi) dates and numbers easier for developers.

---

## Features

- Convert Gregorian dates to Persian (Shamsi) dates.
- Get the Persian name of weekdays.
- Convert English numbers to Persian numbers.
- Display full Persian dates (with day of the week).
- Calculate time differences in natural Persian expressions.
- Convert numbers to Persian words.
- Check if a Persian year is a leap year.
- Add days to a Persian date.
- Format times in Persian (e.g., `۱۴:۳۰`).

---

## Installation

To install the package, run the following command in the .NET CLI:

```bash
dotnet add package PersianUtilities
```

Or, install it via NuGet Package Manager in Visual Studio.

---

## Usage

### 1. Convert Gregorian Date to Persian Date
Convert a `DateTime` object to the Persian calendar date.

```csharp
using PersianUtilities;

var utilities = new PersianUtilities();
DateTime date = DateTime.Now;
string persianDate = utilities.ConvertToPersianDate(date);
Console.WriteLine(persianDate); // Output: 1402/11/01
```

### 2. Get Persian Day of the Week
Retrieve the Persian name of the day for a given `DateTime` object.

```csharp
string dayOfWeek = utilities.GetPersianDayOfWeek(date);
Console.WriteLine(dayOfWeek); // Output: شنبه
```

### 3. Convert Numbers to Persian
Convert English numbers in a string to Persian numbers.

```csharp
string persianNumbers = utilities.ConvertToPersianNumbers("123456");
Console.WriteLine(persianNumbers); // Output: ۱۲۳۴۵۶
```

### 4. Display Full Persian Date
Show the full Persian date, including the day of the week.

```csharp
string fullDate = utilities.GetFullPersianDate(date);
Console.WriteLine(fullDate); // Output: شنبه، 1402/11/01
```

### 5. Calculate Time Differences
Calculate the natural time difference between two dates in Persian.

```csharp
DateTime pastDate = DateTime.Now.AddHours(-3);
string timeDifference = utilities.GetTimeDifference(pastDate, DateTime.Now);
Console.WriteLine(timeDifference); // Output: ۳ ساعت پیش
```

### 6. Convert Numbers to Words
Convert an integer to its equivalent Persian words.

```csharp
string numberInWords = utilities.ConvertNumberToWords(123);
Console.WriteLine(numberInWords); // Output: صد و بیست و سه
```

### 7. Check Persian Leap Year
Check if a given Persian year is a leap year.

```csharp
bool isLeapYear = utilities.IsPersianLeapYear(1402);
Console.WriteLine(isLeapYear); // Output: false
```

### 8. Add Days to Persian Date
Add a specific number of days to a Persian date.

```csharp
string newDate = utilities.AddDaysToPersianDate("1402/11/01", 10);
Console.WriteLine(newDate); // Output: 1402/11/11
```

### 9. Format Time in Persian
Format a `TimeSpan` object in Persian style.

```csharp
TimeSpan time = new TimeSpan(14, 30, 0);
string formattedTime = utilities.FormatPersianTime(time);
Console.WriteLine(formattedTime); // Output: ۱۴:۳۰
```

---

## Contributing
We welcome contributions! If you have an idea for a new feature or find a bug, feel free to open an issue or submit a pull request.

1. Fork the repository.
2. Create a new branch for your feature/bugfix.
3. Commit your changes.
4. Submit a pull request.

---

## License
This project is licensed under the MIT License. See the `LICENSE` file for more details.

---

## Support
If you encounter any issues or have any questions, feel free to open an issue on [GitHub](https://github.com/Merkousha/PersianUtilities).

---

## Author
Developed by [Your Name](https://github.com/Merkousha).
