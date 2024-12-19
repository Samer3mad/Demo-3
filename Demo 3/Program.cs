namespace Demo_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type Casting
            #region Implicict Casting - Safe Casting
            //int x = 4; //4 Bytes
            //long y = /*(long)*/x;
            #endregion

            #region Explict Casting
            //long x = 101010101010; //8 Bytes

            //int y;
            //checked
            //{
            //    y = (int)x;

            //}
            //Console.WriteLine(y);
            //int x = 8;
            //double y = (double)x;
            #endregion

            #region Parse
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Data User");
            //Console.Write("Enter Name: ");
            //string Name=Console.ReadLine();
            //Console.Write("Enter Age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Salary: ");
            //double Salary = double.Parse(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Name: " + Name + "Age: " + age + "Salary: " + Salary);
            #endregion

            #region Convert
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Data User");
            //Console.Write("Enter Name: ");
            //string Name = Console.ReadLine();
            //Console.Write("Enter Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Salary: ");
            //double Salary = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine("Name: " + Name + "Age: " + age + "Salary: " + Salary);
            #endregion
            #endregion

            #region Operators

            #region Unary Operators [++, --]
            //int x = 5;
            //x++;
            //++x;
            //Console.WriteLine(x++);
            //Console.WriteLine(x);

            //Console.WriteLine(--x);
            //Console.WriteLine(x--);
            //Console.WriteLine(x);
            #endregion

            #region Binary Operators
            //int sum, mul, sub, div, mod;

            //int a = 10;
            //int b = 5;

            //sum = a + b;
            //sub = a - b;
            //div = a / b;
            //mul = a * b;
            //mod = a % b;
            #endregion

            #region Assigment Operators
            //int x = 10;
            //x += 10;
            //x -= 10;
            //x /= 10;
            //x *= 10;
            //x %= 10;
            #endregion

            #region Relational Operators
            //int a = 5;
            //int b = 10;

            //Console.WriteLine(a < b);
            #endregion

            #region Logical Operators [Short Circut]
            //Console.WriteLine(!true);

            Console.WriteLine(true && false);
            //true&&treu=>true
            //true&&false=>false
            //false&&true=>false
            //false&&true=>false

            Console.WriteLine(true || false);
            //true||treu=>true
            //true||false=>true
            //false||true=>true
            //false||true=>false
            #endregion

            #region Bitwise Operators [Long Circut]
            Console.WriteLine(true & false);
            //true&treu=>true
            //true&false=>false
            //false&true=>false
            //false&true=>false

            Console.WriteLine(true | false);
            //true|treu=>true
            //true|false=>true
            //false|true=>true
            //false|true=>false
            #endregion

            #region Ternary Operators
            //int x = 4;
            //string message = x > 4 ? "X>4" : "X<=4";
            //Console.WriteLine(message);
            #endregion
            #endregion

            #region Operator Periorety
            /*
             1. Unary 
             2. ()
             3. * / %
             4. + -
             */

            //int a = 20;
            //int b = 15;
            //int c = 10;
            //int d = 5;
            //int result;
            //result = (a + b) * c / d;
            //result = ++a * c;
            ////result = a * c;
            //Console.WriteLine(result);
            #endregion

            #region String Formating
            // Eq = x + y = result;
            // Eq = 10 + 5 = 15
            //int x = 5;
            //int y = 10;
            //int result = x + y;
            //Console.WriteLine("Eq: " + x + "+" + y + "=" + result);
            //String=>immutable datatype
            //string name = "Samer";
            //name = "emad";

            #region Composite Format
            //string message = String.Format("Eq= {0} + {1} = {2}", x, y, result);
            //Console.WriteLine(message);
            #endregion

            #region String Manipolition
            //Console.WriteLine($"Eq= {x}+{y}={result}");
            #endregion

            #endregion
        }
    }
}
