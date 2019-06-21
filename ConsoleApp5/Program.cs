using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;  

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
             string GetUniqueKey1(int maxSize)  // tutaj losujemy sobie duze literki
            {
                char[] chars = new char[26];
                chars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                crypto.GetBytes(data);
                data = new byte[maxSize];
                crypto.GetBytes(data);
                StringBuilder result = new StringBuilder(maxSize);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                return result.ToString();
            }

            string GetUniqueKey2(int maxSize) // tutaj małe literki 
            {
                char[] chars = new char[26];
                chars =
                "abcdefghijklmnopqrstuvwxyz".ToCharArray();
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                crypto.GetBytes(data);
                data = new byte[maxSize];
                crypto.GetBytes(data);
                StringBuilder result = new StringBuilder(maxSize);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                return result.ToString();
            }

            string GetUniqueKey3(int maxSize) //cyfry
            {
                char[] chars = new char[10];
                chars =
                "1234567890".ToCharArray();
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                crypto.GetBytes(data);
                data = new byte[maxSize];
                crypto.GetBytes(data);
                StringBuilder result = new StringBuilder(maxSize);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                return result.ToString();
            }

            string GetUniqueKey4(int maxSize)   // tutaj bedziemy losować znaki
            {
                char[] chars = new char[34];
                chars =
                ",./';\\[]=-~`!@#$%^&*()_+{}|:\"<>?".ToCharArray();
                byte[] data = new byte[1];
                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
                crypto.GetBytes(data);
                data = new byte[maxSize];
                crypto.GetBytes(data);
                StringBuilder result = new StringBuilder(maxSize);
                foreach (byte b in data)
                {
                    result.Append(chars[b % (chars.Length)]);
                }
                return result.ToString();
            }



            // sprawdzamy działanie programu

            int Dlitery = 5;
            int mlitery = 2;
            int cyfry = 3;
            int znaki = 2;
            
            string A = GetUniqueKey1(Dlitery);
            string B = GetUniqueKey2(mlitery);
            string C= GetUniqueKey3(cyfry);
            string D= GetUniqueKey4(znaki);
            string haslo = A + B + C + D;  // haslo 

            string rand = new string(haslo.ToCharArray().OrderBy(x => Guid.NewGuid()).ToArray()); // tutaj sobie tasujemy i mamy random haslo
            Console.WriteLine("twoje hasło to   " + rand+ "    ");
            Console.ReadKey();

        }
    }
}
