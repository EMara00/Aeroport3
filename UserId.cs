using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroport
{
    class UserId
    {
        public static int GlobalUserId { get; private set; }

        public static void setGlobalUserId(int userId)
        {
            GlobalUserId = userId;
        }
    }
}
