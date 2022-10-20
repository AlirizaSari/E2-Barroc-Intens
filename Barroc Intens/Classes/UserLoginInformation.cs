using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barroc_Intens.Classes
{
    static class UserLoginInformation
    {
        /// <summary>
        /// Converts the roleID to a string with the role
        /// </summary>
        /// <param name="rolId">The rolId of a logged in user</param>
        /// <returns>A string with the role corresponding to the user</returns>
        public static string ConvertRoleId(int rolId)
        {
            string myRole = "Not found";

            switch (rolId)
            {
                case 1:
                    myRole = "Admin";
                    break;
                case 2:
                    myRole = "Finance Head";
                    break;
                case 3:
                    myRole = "Finance";
                    break;
                case 4:
                    myRole = "Sales Head";
                    break;
                case 5:
                    myRole = "Sales";
                    break;
                case 6:
                    myRole = "Inkoop Head";
                    break;
                case 7:
                    myRole = "Inkoop";
                    break;
                case 8:
                    myRole = "Maintenance Head";
                    break;
                case 9:
                    myRole = "Maintenance";
                    break;
                default:
                    break;
            }

            return myRole;
        }


        private static int loginUserId;
        public static int LoginUserId {
            get { return loginUserId; }
            set { loginUserId = value; }
        }

        private static string loginUserName;
        public static string LoginUserName
        {
            get { return loginUserName; }
            set { loginUserName = value; }
        }

        private static string loginName;
        public static string LoginName
        {
            get { return loginName; }
            set { loginName = value; }
        }

        private static int rolId;
        public static int RolId
        {
            get { return rolId; }
            set { rolId = value; }
        }

        
    }
}
