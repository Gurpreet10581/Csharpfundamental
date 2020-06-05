using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _00_Challange2
{



    public enum WBType { Plastic, Aluminum, Steel, Wood, Paper }
    public class WB
    {
        public string Length { get; set; }
        public string Width { get; set; }
        public int Radius { get; set; }

        public WBType TypeofMaterial { get; set; }

        public WB(string bottleLenght, string bottlewidth, int bottleradius, WBType matType
            )
        {
            Length = bottleLenght;
            Width = bottlewidth;
            Radius = bottleradius;
        }
       
    }



}    
 