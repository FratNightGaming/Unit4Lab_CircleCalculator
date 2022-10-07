using CircleObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
namespace CircleObjects
{
    public class Circle//what does internal do compared to public???
    {
        //fields
        public double Radius { get; set; } //why private? What does it do?

        /*public double GetRadius()
        { return Radius; }*/

        /*public void SetRadius(double radius)
        {
            Radius = radius;
        }*/

        //constructor
        public Circle(double r)
        {
            this.Radius = r;
        }
        //methods
        public double CalculateCircumference()
        {
            double Circumference = Math.Round(2 * Math.PI * Radius, 2);//hopefully rounds to 3 decimal places

            return Circumference;
        }
        
        public string CalculateFormattedCircumference()
        {
            return CalculateCircumference().ToString();
        }
        public double CalculateArea()
        {
            double Area = Math.Round(Math.PI * Math.Pow(Radius, 2), 2);

            return Area;
        }
        public string CalculateFormattedArea()
        {
            return CalculateArea().ToString();
        }
    }
}

/*Create a class named Circle to store the data about this circle. This class should contain these constructors and methods:
public Circle(double radius)
public double CalculateCircumference()
public string CalculateFormattedCircumference()
public double CalculateArea()
public string CalculateFormattedArea()
private string FormatNumber(double x)// what does this do???
Define a member called radius. This member should be private. 
Define a property to get access to the class member : Radius //???
For the value of pi, use the PI constant of the System.Math class.
Get the user input, create a Circle object, and display the circumference and area.*/