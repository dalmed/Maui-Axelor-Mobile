using SmartWMS.DTO.Models;
using System.Net;

namespace SmartWMS
{
    internal static class Constants
    {
        public static string RestBaseUrl { get; set; }
        public static string Login { get; set; }
        public static string Password { get; set; }
        public static string MobileDeviceCode { get; set; }
        public static string PrefixsList { get; set; }
        public static CookieCollection Cookies { get; set; }
        public static bool IsServerConnected { get; set; }
        public static User ConnectedUser { get; set; }
        public struct Models
        {
            public struct PoultryFarming
            {
                public const string Hatchery = "com.axelor.apps.poultryfarming.db.Hatchery";
                public const string Incubator = "com.axelor.apps.poultryfarming.db.Incubator";
               
            }
            public struct Base
            {
                public const string Partner = "com.axelor.apps.base.db.Partner";

            }

            public struct Auth
            {
                public const string User = "com.axelor.auth.db.User";

            }
        }
    }
}
