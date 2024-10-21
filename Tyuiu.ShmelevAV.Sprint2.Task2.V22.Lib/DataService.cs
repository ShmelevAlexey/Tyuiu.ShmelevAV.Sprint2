﻿using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShmelevAV.Sprint2.Task2.V22.Lib
{
    public class DataService : ISprint2Task2V22
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if ((x >= 3) && (x <= 7) && (y >= 3) && (y <= 5))
            {
                res = true;
            }
            else if ((x >= 5) && (x <= 7) && (y >= 6) && (y <= 8))
            {
                res = true;
            }
            else if ((x >= 3) && (x <= 7) && (y >= 9) && (y <= 12))
            {
                res = true;
            }
            else if ((x >= 8) && (x <= 9) && (y >= 9) && (y <= 10))
            {
                res = true;
            }
            else if ((x >= 6) && (x <= 8) && (y >= 13) && (y <= 13))
            {
                res = true;
            }
            else if ((x >= 8) && (x <= 11) && (y >= 12) && (y <= 12))
            {
                res = true;
            }
            else if ((x >= 8) && (x <= 11) && (y >= 4) && (y <= 6))
            {
                res = true;
            }
            else if ((x >= 11) && (x <= 11) && (y >= 3) && (y <= 3))
            {
                res = true;
            }
            else if ((x >= 12) && (x <= 13) && (y >= 5) && (y <= 5))
            {
                res = true;
            }
            else if ((x >= 14) && (x <= 14) && (y >= 4) && (y <= 10))
            {
                res = true;
            }
            else
            {
                res = false;
            }

            return res;
        }
    }
}
