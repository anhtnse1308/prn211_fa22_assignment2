using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class OrderDetailsDAO
    {
        private static OrderDetailsDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailsDAO() { }
        public static OrderDetailsDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailsDAO();
                    }
                    return instance;
                }
            }
        }
    }
}
