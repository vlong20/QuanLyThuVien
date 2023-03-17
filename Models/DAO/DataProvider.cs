using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ThuVien.Models.DAO
{
    public class DataProvider
    {
        public DataProvider() { }
        private static DataProvider instance;
        public static DataProvider Instance { 
            get { if (instance == null) instance = new DataProvider(); return instance; }
            set => instance = value; 
        }


    }
}