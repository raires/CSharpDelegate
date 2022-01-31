// See https://aka.ms/new-console-template for more information
using CSharpDelegate;
using System.Reflection;

//Console.WriteLine("Hello, World!");
//Delegates allow you to store a functions inside a field

/* CLASS 1 Delegates Examples*/
MyDelegate delegate0 = ClassDelegates.MethodA;
delegate0();

Console.WriteLine();

//reassign method to the same delegate with same schema
delegate0 = ClassDelegates.MethodAA;
delegate0();

Console.WriteLine("\nMult cast delegate\n");

//multicast delegate
delegate0 = ClassDelegates.MethodA;
delegate0 += ClassDelegates.MethodAA;
delegate0();

Console.WriteLine("-------");
Console.WriteLine(delegate0.GetInvocationList().Length);

// Invoke each delegate in the invocation list in reverse order.
for (int ctr = delegate0.GetInvocationList().Length - 1; ctr >= 0; ctr--)
{
    var outputMsg = delegate0.GetInvocationList()[ctr];
    Console.WriteLine(outputMsg.GetMethodInfo().Name);
    outputMsg.DynamicInvoke();
}

Console.WriteLine("-------");

// Invoke each delegate in the invocation list in reverse order.
for (int ctr = delegate0.GetInvocationList().Length - 1; ctr >= 0; ctr--)
{
    var outputMsg = delegate0.GetInvocationList()[ctr];
    if (!outputMsg.GetMethodInfo().Name.Contains("MethodAA"))
    {
        delegate0 -= ClassDelegates.MethodAA;
    }
}

delegate0();

Console.WriteLine(delegate0.Method); //Return last assigned delegate

Console.WriteLine();

MyDelegate1 delegate1 = ClassDelegates.MethodB;
delegate1("Hello World B");

MyDelegate2 delegate2 = ClassDelegates.MethodC;
delegate2("Hello World C", 123);

Console.WriteLine("\n");

//Lambda calls
Console.WriteLine("Lambda delegate examples\n");
delegate0 = () => Console.WriteLine("Lambda");
delegate0();

Console.WriteLine("-------");

delegate1 = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
delegate1("Hello World Lambda");

//
MyDelegate3 delegate3 = ClassDelegates.AddOne;
Console.WriteLine(delegate3(3));
//
MyDelegate3 delegate3_1 = (int num) => { return num + 2; };
Console.WriteLine(delegate3_1(5));


Console.WriteLine("\n\n\n\n-------\nAction\n");



Action actionDel1 = ClassActions.Action1;
actionDel1();
Action<int> actionDel2 = ClassActions.Action2;
actionDel2(10);

//Lambda
Action actionLambda1 = () => Console.WriteLine("Action Lambda");
actionLambda1();
Action<int> actionLambda2 = (i) => Console.WriteLine("Action Lambda with param: " + i.ToString());
actionLambda2(12);


Console.WriteLine("\n\n\n\n-------\nFunc\n");

Func<int> funcDel1 = ClassFuncs.Func1;
Console.WriteLine(funcDel1());
Func<int,int> funcDel2 = ClassFuncs.Func2;
Console.WriteLine(funcDel2(21));

//Lambda
Func<int> randomNumber = () => new Random().Next(1, 100);
Console.WriteLine(randomNumber().ToString());



Console.WriteLine("--------------------------------------");
Func<int> func1Lambda = () => 11;
Console.WriteLine(func1Lambda().ToString());
Func<int, int> func2Lambda = (i) => i;
Console.WriteLine(func2Lambda(7).ToString());



Console.WriteLine("\n\n\n\n-------\nPredicate\n");

//Perdicate
Predicate<string> isUpper = delegate (string s) { return s.Equals(s.ToUpper()); };
bool result = isUpper("hello world!!");
Console.WriteLine("is this 'hello' Upper case? " + result.ToString());
result = isUpper("HHH");
Console.WriteLine("is this 'HHH' Upper case? " + result.ToString());

Predicate<int> isOdd = delegate (int i) { return i % 2 == 0 ? false : true; };
Action<int> returnIsOdd = (val) => Console.WriteLine("is '" + val.ToString() + "' an Odd number? " + isOdd(val).ToString());
returnIsOdd(1);
returnIsOdd(2);
returnIsOdd(3);
returnIsOdd(4);
returnIsOdd(5);
returnIsOdd(6);





