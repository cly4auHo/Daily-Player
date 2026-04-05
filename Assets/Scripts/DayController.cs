using System;

public static class DayController 
{
    private static DateTime date;
    
    public static bool IsCurrentDay => date == DateTime.UtcNow;
    public static string CurrentDay => FormatDate(date);
    
    public static void Init() => date = DateTime.UtcNow;
    
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
    
    private static string FormatDate(DateTime dateTime) => dateTime.ToString("ddMMyyyy");
}