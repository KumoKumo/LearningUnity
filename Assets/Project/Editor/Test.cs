using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test
{
    /* 
     * C# 8.0 not yet supported by Unity 2019
     * Might come out in the 2020 release cycle at the earliest
     * https://www.youtube.com/watch?v=aUbXGs7YTGo
     */

    //public bool Isweekday(DateTime time) => time.DayOfWeek switch
    //{
    //    //Saturday and Sunday are not weekdays
    //    DayOfWeek.Saturday => false, 
    //    DayOfWeek.Sunday => false,
    //    //Every other days are weekdays
    //    _ => true 
    //};

    public void Swapping(int a, int b) => (a, b) = (b, a);
    string newString = $"This is the Pi number: {Math.PI,20:F3}";
}
