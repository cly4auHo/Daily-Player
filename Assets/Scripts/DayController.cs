using System;

public static class DayController 
{
    private static DateTime date = DateTime.UtcNow;
    
    public static bool IsCurrentDay => CurrentDay == FormatDate(DateTime.UtcNow);
    
    public static string CurrentDay => FormatDate(date);

    public static string PreviousDay
    {
        get
        {
            date = date.AddDays(-1);   
            return CurrentDay;
        }
    }

    public static string NextDay
    {
        get
        {
            date = date.AddDays(1);
            
            return CurrentDay;
        }
    }
    
    private static string FormatDate(DateTime date) => date.ToString("ddMMyyyy");
}
