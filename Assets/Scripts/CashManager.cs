using System.IO;
using UnityEngine;

public static class CashManager
{
    private static readonly string FolderPath = $"{Application.dataPath}/Videos/";
    
    public static string BuildPath(string day) => $"{FolderPath}{day}.mp4";
    
    public static bool IsFileExist(string day) => File.Exists(BuildPath(day));
}