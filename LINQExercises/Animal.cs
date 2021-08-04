using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExercises
{
  class Animal
  {
    public string Type { get; set; }
    public int WeightInPounds { get; set; }
    public int HeightInInches { get; set; }
    public string Name { get; set; }

    public Animal(string type, 
                  int weightInPounds, 
                  int heightInInches, 
                  string name)
    {
      Type = type;
      WeightInPounds = weightInPounds;
      HeightInInches = heightInInches;
      Name = name;
    }





  }
}
