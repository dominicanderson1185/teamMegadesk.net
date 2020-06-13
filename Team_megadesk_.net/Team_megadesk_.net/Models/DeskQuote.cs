using System;
using System.ComponentModel.DataAnnotations;

namespace Team_megadesk_.net.Models
{
    public class DeskQuote
    {

        public static double basePrice = 200;
        public static double costPerInchSquare = 1;
        public static double baseSizeIncl = 1000;
        public static double drawerPrice = 50;

        public static double widthMin = 24;
        public static double widthMax = 96;
        public static double depthMin = 12;
        public static double depthMax = 48;
        public static int drawersMin = 0;
        public static int drawersMax = 7;

        public int ID { get; set; }
        public string customerName { get; set; }

        [DataType(DataType.Date)]
        public DateTime dateCreated { get; set; }
        public int productionTime { get; set; }

        public double deskWidth { get; set; }
        public double deskDepth { get; set; }
        public int deskMaterial { get; set; }
        public int deskDrawers { get; set; }


    }
}
