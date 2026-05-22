using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tagroba1
{
    public abstract class Order
    {
        public int Bantaloon { get; set; }
        public int Tshirt { get; set; }
        public int Dress { get; set; }

        public Order(int bantaloon, int tshirt, int dress)
        {
            Bantaloon = bantaloon;
            Tshirt = tshirt;
            Dress = dress;
        }
        public abstract int TotalPrice();
    }


    public class PressOrder : Order
    {
        public static List<PressOrder> presslist = new List<PressOrder>();
        static int Se3rBantaloon = 10;
        static int Se3rTshirt = 15;
        static int Se3rDress = 50;
        public int kemeyetBantalon;
        public int kemeyetTshirt;
        public int kemeyetDress;
        public PressOrder(int bantaloon, int tshirt, int dress) : base(bantaloon, tshirt, dress)
        {
            kemeyetBantalon = bantaloon;
            kemeyetTshirt= tshirt;
            kemeyetDress = dress;
        }
        public override int TotalPrice()
        {
            return Se3rBantaloon * Bantaloon + Se3rTshirt * Tshirt + Se3rDress * Dress;
        }
        public void AddPress(PressOrder order)
        {
            presslist.Add(order);
        }
        public void RemovePress(PressOrder order) { 
            presslist.Remove(order); 
        }


    }
    public class CleanOrder : Order
    {
        public static List<CleanOrder> cleanlist = new List<CleanOrder>();
        int Se3rBantaloon = 25;
        int Se3rTshirt = 20;
        int Se3rDress = 80;
        public int kemeyetBantalon2;
        public int kemeyetTshirt2;
        public int kemeyetDress2;
        public CleanOrder(int bantaloon, int tshirt, int dress) : base(bantaloon, tshirt, dress)
        {
            kemeyetBantalon2 = bantaloon;
            kemeyetTshirt2 = tshirt;
            kemeyetDress2 = dress;
        }
        public override int TotalPrice()
        {
            return Se3rBantaloon * Bantaloon + Se3rTshirt * Tshirt + Se3rDress * Dress;
        }
        public void AddClean(CleanOrder order)
        {
            cleanlist.Add(order);
        }
        public void RemoveClean(CleanOrder order)
        {
            cleanlist.Remove(order);
        }

    }

    public class WashOrder : Order
    {
        public static List<WashOrder> washlist = new List<WashOrder>();
        int Se3rBantaloon = 10;
        int Se3rTshirt = 5;
        int Se3rDress = 25;
        public int kemeyetBantalon3;
        public int kemeyetTshirt3;
        public int kemeyetDress3;
        public WashOrder(int bantaloon, int tshirt, int dress) : base(bantaloon, tshirt, dress)
        {
            kemeyetBantalon3 = bantaloon;
            kemeyetTshirt3 = tshirt;
            kemeyetDress3 = dress;

        }
        public override int TotalPrice()
        {
            return Se3rBantaloon * Bantaloon + Se3rTshirt * Tshirt + Se3rDress * Dress;
        }
        public void AddWash(WashOrder order)
        {
            washlist.Add(order);
        }
        public void RemoveWash(WashOrder order) {  washlist.Remove(order); }
    }
}
