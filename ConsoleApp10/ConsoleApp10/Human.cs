using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
   public class Human
    {
      string _name;
      public string GetName()
        {
            return _name;
        }
      public void SetName(string name)
        {
          
            _name = name;
        }
        int _age;
        public int Getage()
        {
            return _age;
        }
        public void Setage(int age)
        {
          

            _age = age;
        }
        int _weight;
        public int GetWeight()
        {
            return _weight;
        }
        public void SetWeight(int weight)
        {
            _weight = weight;
        }
    }
}
