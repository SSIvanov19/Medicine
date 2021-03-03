using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManager
{
    public static string Username;
    public static int ID;
    

    public static bool LoggedIn
    {
        get { return Username != null; }
    }

    public static void LogOut()
    {
        Username = null;
    }
}