using System.Net.NetworkInformation;
using System.Text;

namespace FastFoodDemo.Classes
{
    public class Helpers
    {
        // Hardcoded AES key and IV (for demonstration purposes only)
        private static readonly byte[] Key = Encoding.UTF8.GetBytes("ThisIsASecretKey");
        private static readonly byte[] IV = Encoding.UTF8.GetBytes("ThisIsAnIV12345");

        public static string GetMacAddress()
        {
            string macAddress = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                // Only consider physical network interfaces
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet ||
                    nic.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    macAddress = nic.GetPhysicalAddress().ToString();
                    break;
                }
            }

            return macAddress;
        }

        public static string EncryptPassword(string password)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(password);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public static string DecryptPassword(string encryptedPassword)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(encryptedPassword);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
    }
}
