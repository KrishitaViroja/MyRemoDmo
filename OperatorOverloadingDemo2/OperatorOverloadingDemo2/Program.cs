// See https://aka.ms/new-console-template for more information
using OperatorOverloadingDemo2;
//Demo obj1 = new Demo();
//obj1.GetDetails();   //10

//Demo obj2 = new Demo();
//obj2.GetDetails();  //20

//Demo obj3 = new Demo();

//obj3.num = obj1.num + obj2.num;
//obj3.Display();



//obj3 = obj1.Add(obj2);
//obj3.Display();

//obj3 = obj1 + obj2;
//obj3.Display();

//Demo2 obj1 = new Demo2();
//obj1.GetDetails();
//Demo2 obj2 = new Demo2();
//obj2 = obj1++;
//obj2.Display();

//Demo3 obj1 = new Demo3();
//obj1.GetDetails();

//Demo3 obj2 = new Demo3();
//obj2.GetDetails();

//if (obj1 > obj2)
//    Console.WriteLine("obj1 {0} is greatest", obj1.num);
//else
//    Console.WriteLine("obj2 {0} is greatest", obj2.num);

//Calculator c1 = new Calculator();

////Step2: Create an instance of delegate
//MyDelegate obj = new MyDelegate(c1.Add);
//int result = obj.Invoke(10, 20);
//int result2 = obj(10, 30);


//obj += new MyDelegate(c1.Substract);

////Step3: Invoke 
//int result3 = obj.Invoke(10, 20);
//int result4 = obj(10, 30);

//Console.WriteLine("Result is {0}", result);
//Console.WriteLine("Result2 is {0}", result2);
//Console.WriteLine("Result3 is {0}", result3);
//Console.WriteLine("Result4 is {0}", result4);

int option, result = 0;
Calculator obj = new Calculator();

MyDelegate1 delegate1;

Console.WriteLine("1.Add \n 2.Substract \n 3.Multiply \n 4.Divide");
Console.WriteLine("Select an option");
option = Convert.ToInt32(Console.ReadLine());

//switch (option)
//{
//    case 1:

//        delegate1 = new MyDelegate1(obj.Add);
//        //delegate1 += new MyDelegate1(obj.Multiply);
//        result = delegate1(10, 20);
//        break;
//    case 2:

//        delegate1 = new MyDelegate1(obj.Substract);
//        result = delegate1.Invoke(100, 20);
//        break;

//    case 3:

//        delegate1 = new MyDelegate1(obj.Multiply);
//        result = delegate1(10, 20);
//        break;

//    case 4:

//        delegate1 = new MyDelegate1(obj.Divide);
//        result = delegate1(100, 20);
//        break;

//    default:
//        Console.WriteLine("Invalid choice");
//        break;
//}

//Console.WriteLine($"Result = {result}");

switch (option)
{
    case 1:

        //A function without a name is anonymous
        delegate1 = delegate (int a, int b)
        {
            return a + b;
        };

        //delegate1 += new MyDelegate1(obj.Multiply);
        result = delegate1(10, 20);
        break;
    case 2:

        //lamdba expression
        delegate1 = (int a, int b) => a - b;

        result = delegate1.Invoke(100, 20);
        break;

    case 3:

        delegate1 = new MyDelegate1(obj.Multiply);
        result = delegate1(10, 20);
        break;

    case 4:

        delegate1 = new MyDelegate1(obj.Divide);
        result = delegate1(100, 20);
        break;

    default:
        Console.WriteLine("Invalid choice");
        break;
}

Console.WriteLine($"Result = {result}");

