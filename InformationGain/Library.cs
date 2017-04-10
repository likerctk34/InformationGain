using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InformationGain
{
    class Library
    {
        public static List<string> propertykeys;
        public static string KeyDicision;
        List<TapHuanLuyen> AllTapHuanluye;
        public Library()
        {
            AllTapHuanluye = new List<TapHuanLuyen>(); 
            propertykeys = new List<string>();
        }
        public static double I(params int[] S)
        {
            double kq = 0f;
            int sum = S.Sum(x => x);
            foreach (var si in S)
            {
                kq += ((double)si / (double)sum) * Math.Log((double)si / (double)sum, 2);
            }
            return -Math.Round(kq, 4);
 
        }
       
    }
}
