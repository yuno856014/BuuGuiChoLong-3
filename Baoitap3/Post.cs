using System;
using System.Collections.Generic;
using System.Text;

namespace Baoitap3
{
    class Post : IPost
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        private float AverageRate => CalculatorRate();
        public int[] Rates = new int[4];
        public int this[int index]
        {
            get => Rates[index];
            set => Rates[index] = value;
        }
        public float CalculatorRate()
        {
            return (float)(Rates[0] + Rates[1] + Rates[2] + Rates[3])/4;
        }
        public string Display()
        {
            return $"ID : {ID} Title : {Title} Content : {Content} Author : {Author} AverageRate : {AverageRate} ";
        }
    }
}
