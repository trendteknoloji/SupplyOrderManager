using Microsoft.Win32;
using Supply.Orders.Manager.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Supply.Orders.Manager.Entity.Main
{
    public static class Cry
    {

        private const int Keysize = 256;
        private const int DerivationIterations = 1000;
        public static string Encrypt(this string plainText, string passPhrase)
        {
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        public static string Decrypt(this string cipherText, string passPhrase)
        {
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }
        public static DateTime GetNistTime()
        {
            DateTime dateTime = DateTime.MinValue;
            return DateTime.Now;
            //try
            //{
            //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://nist.time.gov/actualtime.cgi?lzbc=siqm9b");
            //    request.Method = "GET";
            //    request.Accept = "text/html, application/xhtml+xml, */*";
            //    request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.1; Trident/6.0)";
            //    request.ContentType = "application/x-www-form-urlencoded";
            //    request.CachePolicy = new RequestCachePolicy(RequestCacheLevel.NoCacheNoStore);
            //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //    if (response.StatusCode == HttpStatusCode.OK)
            //    {
            //        StreamReader stream = new StreamReader(response.GetResponseStream());
            //        string html = stream.ReadToEnd();
            //        string time = Regex.Match(html, @"(?<=\btime="")[^""]*").Value;
            //        double milliseconds = Convert.ToInt64(time) / 1000.0;
            //        dateTime = new DateTime(1970, 1, 1).AddMilliseconds(milliseconds).ToLocalTime();
            //    }
            //    return dateTime;
            //}
            //catch (Exception)
            //{
            //    return DateTime.Now;
            //}
        }

        //public static String CPUSeri()   //FARKLI PC LERDE AYNI CIKTIĞI İÇİN KAPATILDI
        //{
        //    String processorID = "";
        //    ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
        //    ManagementObjectCollection mObject = searcher.Get();

        //    foreach (ManagementObject obj in mObject)
        //    {
        //        processorID = obj["ProcessorId"].ToString();
        //    }
        //    return processorID;
        //}


        public static string GetBiosInformation()
        {
            string result = "";
            string baseBoard = "";
            string bios = "";
            string systemGuid = "";
            String processorID = "";
            string name = Dns.GetHostName();
            try
            {
                ManagementObjectSearcher mSearcher = new ManagementObjectSearcher("SELECT SerialNumber, SMBIOSBIOSVersion, ReleaseDate FROM Win32_BIOS");
                ManagementObjectCollection collection = mSearcher.Get();
                foreach (ManagementObject obj in collection)
                {
                    string serialNumber = (string)obj["SerialNumber"];
                    string biosVersion = (string)obj["SMBIOSBIOSVersion"];
                    string relDt = (string)obj["ReleaseDate"];
                    DateTime dt = ManagementDateTimeConverter.ToDateTime(relDt);
                    string releaseDate = dt.ToString("dd-MMM-yyyy");//date format
                    bios = serialNumber + biosVersion + releaseDate;
                }
            }
            catch (Exception ex)
            {
                ExceptionHelpers.ErrorRegister(ex);
            }
            try
            {
                ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
                foreach (var o in managementObjectSearcher.Get())
                {
                    var managementObject = (ManagementObject)o;
                    foreach (PropertyData properties in managementObject.Properties)
                    {
                        if (properties.Name == "SerialNumber")
                        {
                            baseBoard = properties.Value.ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHelpers.ErrorRegister(ex);
            }
            try
            {

                ManagementObjectSearcher searcher = new ManagementObjectSearcher("Select * FROM WIN32_Processor");
                ManagementObjectCollection mObject = searcher.Get();
                foreach (ManagementObject obj in mObject)
                {
                    processorID = obj["ProcessorId"].ToString();
                }
            }
            catch (Exception ex)
            {
                ExceptionHelpers.ErrorRegister(ex);
            }
            try
            {
                string x64Result = string.Empty;
                string x86Result = string.Empty;
                RegistryKey keyBaseX64 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
                RegistryKey keyBaseX86 = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32);
                RegistryKey keyX64 = keyBaseX64.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", RegistryKeyPermissionCheck.ReadSubTree);
                RegistryKey keyX86 = keyBaseX86.OpenSubKey(@"SOFTWARE\Microsoft\Cryptography", RegistryKeyPermissionCheck.ReadSubTree);
                object resultObjX64 = keyX64.GetValue("MachineGuid", (object)"default");
                object resultObjX86 = keyX86.GetValue("MachineGuid", (object)"default");
                keyX64.Close();
                keyX86.Close();
                keyBaseX64.Close();
                keyBaseX86.Close();
                keyX64.Dispose();
                keyX86.Dispose();
                keyBaseX64.Dispose();
                keyBaseX86.Dispose();
                keyX64 = null;
                keyX86 = null;
                keyBaseX64 = null;
                keyBaseX86 = null;
                if (resultObjX64 != null && resultObjX64.ToString() != "default")
                {
                    systemGuid = resultObjX64.ToString();
                }
                if (resultObjX86 != null && resultObjX86.ToString() != "default")
                {
                    systemGuid = resultObjX86.ToString();
                }
            }
            catch (Exception ex)
            {
                ExceptionHelpers.ErrorRegister(ex);
            }
            result += name + baseBoard + bios + processorID + systemGuid;
            return result;
        }

    }
}
