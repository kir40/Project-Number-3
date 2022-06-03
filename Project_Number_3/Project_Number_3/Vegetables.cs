using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Number_3
{
     class Vegetables
     {
        //private string Peppers;
        //private double PeppersQuantity;
        //private double PepperswHolesalePrice;
        //private double PeppersRetailPrice;

        //private string Cucumbers;
        //private double CucumbersQuantity;
        //private double CucumbersWholesalePrice;
        //private double CucumbersRetailPrice;

        //private string Cabbage;
        //private double CabbageQuantity;
        //private double CabbageWholesalePrice;
        //private double CabbageRetailPrice;

        //private string Tomato;
        //private double TomatoQuantity;
        //private double TomatoWholesalePrice;
        //private double TomatoRetailPrice;

        //string Potatoes;
        //double PotatoesQuantity;
        //double PotatoesWholesalePrice;
        //double PotatoesRetailPrice;

        //public Vegetables(string peppers, double peppersQuantity, double pepperswHolesalePrice, double peppersRetailPrice)
        //{
        //    this.Peppers = peppers;
        //    this.PeppersQuantity = peppersQuantity;
        //    this.PepperswHolesalePrice = pepperswHolesalePrice;
        //    this.PeppersRetailPrice = peppersRetailPrice;
        //}
        private string vName;
        private double vQuantity;
        private double vWholesalePrice;
        private double vRetailPrice;

        public void vValue() 
        {
           vName= Console.ReadLine();
           vQuantity= double.Parse(Console.ReadLine());
           vWholesalePrice= double.Parse(Console.ReadLine());  
           vRetailPrice= double.Parse(Console.ReadLine());

        }
        public Vegetables(string vName, double vQuantity, double vWholesalePrice, double vRetailPrice)
        {
            this.vName = vName;
            this.vQuantity = vQuantity;
            this.vWholesalePrice = vWholesalePrice;
            this.vRetailPrice = vRetailPrice;
        }
        
     }
}
