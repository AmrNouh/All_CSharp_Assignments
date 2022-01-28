internal struct HiringDate : IComparable
{
    public int day { get; set; }
    public int month { get; set; }
    public int year { get; set; }

    public HiringDate()
    {
        day = 1;
        month = 1;
        year = 1;
    }

    public HiringDate(int days)
    {
        this.year = days / 365;
        this.month = (days % 365) / 30;
        this.day = (days % 365) % 30;
    }

    public HiringDate(int day, int month, int year)
    {
        this.day = day;
        this.month = month;
        this.year = year;
    }
    /// <summary>
    /// Converts the span of chars representation of the HiringDate
    /// </summary>
    /// <param name="s">String that Represent HiringDate</param>
    /// <param name="result">
    /// HiringDate instance
    /// </param>
    /// <returns>
    /// The HiringDate After Conversion or Defualt Values of HiringDate
    /// </returns>
    public static bool TryParse(string? s, out HiringDate result)
    {
        int day = 1;
        int month = 1;
        int year = 1;
        if (!string.IsNullOrWhiteSpace(s) && (s.Trim().Count(f => (f == '/')) == 2) && !(s.Length <= 2))
        {
            string[] date = s.Split('/');
            int.TryParse(date[0].Trim(), out day);
            int.TryParse(date[1].Trim(), out month);
            int.TryParse(date[2].Trim(), out year);
            if (day == 0 || month == 0 || year == 0)
            {
                result = new HiringDate();
                return false;
            }
            else
            {
                result = new HiringDate(day, month, year);
                return true;
            }
        }
        else
        {
            result = new HiringDate();
            return false;
        }
    }
    public override string ToString()
    {
        return $"{day:D2}/{month:D2}/{year:D4}";
    }

    /// <summary>
    /// Compares the current instance of HiringDate with another object of the same type
    /// </summary>
    /// <param name="obj">represent HiringDate object</param>
    /// <returns>
    /// an integer that indicates whether the current instance precedes, follows, or
    ///     occurs in the same position in the sort order as the other object.
    /// </returns>
    /// <exception cref="Exception">
    /// T:System.ArgumentException:
    ///     obj is not the same type as this instance.
    /// </exception>
    public int CompareTo(object? obj)
    {
        if (obj is HiringDate)
        {
            HiringDate hiringDate = (HiringDate)obj; // unboxing
            if (day.CompareTo(hiringDate.day) == 0 && month.CompareTo(hiringDate.month) == 0 && year.CompareTo(hiringDate.year) == 0)
            {
                return 0;
            }
            else if (year.CompareTo(hiringDate.year) > 0)
            {
                return -1;
            }
            else if (year.CompareTo(hiringDate.year) < 0)
            {
                return 1;
            }
            else
            {
                if (month.CompareTo(hiringDate.month) == 0)
                {
                    if (day == hiringDate.day)
                    {
                        return 0;
                    }
                    else if (day > hiringDate.day)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
                else
                {
                    if (month > hiringDate.month)
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
        else
        {
            throw new Exception("Compare only Hiring Date Values");
        }
    }

    public static implicit operator string(HiringDate hiringDate)
    {
        return hiringDate.ToString();
    }
}