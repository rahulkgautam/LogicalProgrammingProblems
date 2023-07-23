using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void GenerateCouponNumber()
        {
			char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789".ToCharArray();
			int max = 100000000;
			Random rnd = new Random();
			int random = rnd.Next(max);
			StringBuilder sb = new StringBuilder();
			while (random > 0)
			{
				sb.Append(chars[random % chars.Length]);
				random /= chars.Length;
			}

			String couponCode = sb.ToString();
			Console.WriteLine("Coupon Code: " + couponCode);
		}
    }
}
