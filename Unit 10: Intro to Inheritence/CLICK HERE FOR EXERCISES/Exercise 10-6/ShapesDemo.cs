using static System.Console;
class ShapesDemo
{
   static void Main()
   {
       Rectangle shape1 = new Rectangle(12,5);
       Square shape2 = new Square(10,10);
       Triangle shape3 = new Triangle(9,5);
       
 
       Display(shape1);
       Display(shape2);
       Display(shape3);
 
 
       
   }
   public static void Display(GeometricFigure a){
     WriteLine("Width: {0}\nHeight: {1}\nArea: {2}",a.width,a.height,a.Area);
   }
}
 
abstract class GeometricFigure{
  public double height{get; set;}
  public double width{get; set;}
  public double Area;
 
  abstract public double ComputeArea();
}
 
class Rectangle : GeometricFigure{
  public Rectangle(double w, double h){
    height = h;
    width = w;
    Area = ComputeArea();
  }
  public Rectangle(double w){}
  
  public override double ComputeArea(){
    double a = height*width;
    return a;
  }
}
 
class Square :  Rectangle{
  public Square(double w, double h): base(w,h){
    width = w;
    height = w;
    Area = ComputeArea();
  }
  public Square(double w):base(w){
    width = w;
    height = w;
    Area = ComputeArea();
  }
}
 
class Triangle : GeometricFigure{
  public Triangle(double w, double h){
    width = w;
    height = h;
    Area = ComputeArea();
  }
  public override double ComputeArea(){
    double a = width * (height/2);
    return a;
  }
 
}
 
