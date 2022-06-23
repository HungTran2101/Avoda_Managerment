using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avoda_Managerment.Utils
{
    public class Global
    {
        public static Color mainColor = Color.BurlyWood;
        public static Color productDetailColor = Color.LightBlue;
        public static Color deactiveColor = Color.DimGray;
        public static Color buyActiveColor = Color.SeaGreen;
        public static Color customerActiveColor = Color.SteelBlue;
        public static Color stockActiveColor = Color.DarkGoldenrod;
        public static Color transactionColor = Color.DarkKhaki;
        public static Color titleWaitingColor = Color.FromArgb(75, 127, 117);

        public static long priceToScore = 20000;
        public static int scoreToPrice = 1000;

        public static string[] sizes = { "S", "M", "L", "XL", "XXL" };
        public static string sizeS = "'S'";
        public static string sizeM = "'M'";
        public static string sizeL = "'L'";
        public static string sizeXL = "'XL'";
        public static string sizeXXL = "'XXL'";
        public static string sizeAll = "'S', 'M', 'L', 'XL', 'XXL'";

        public static string currencyToText(long input)
        {
            return string.Format("{0:n0}", input) + " VND";
        }

        public static long textToCurrency(string input)
        {
            string result = input.Replace(" VND", "");
            result = result.Replace(",", "");
            return long.Parse(result);
        }
    }
}