//// stop when number > 100
//using System.Diagnostics;
////Trace Watcher
//string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);         //Puts file on your desktop
//var streamWriter = File.CreateText(Path.Combine(folderPath, "appTrace.log"));                      //This is the file name and what file it is writing to
//var traceWriter = new System.Diagnostics.TextWriterTraceListener(streamWriter);                    //This object called stramWriter is a listener for trace messages
//System.Diagnostics.Trace.Listeners.Add(traceWriter);                                               //These messages will be stored to the file on the desktop
//System.Diagnostics.Trace.AutoFlush = true;
////This will constantly add to the file until the file is deleted, if this is ran again it will make a new folder


int nbr1 = 1;
int nbr2 = 1;

void Fibonacci()            //My OG fib method (Controls the range, always starts at 1,1)
{
    int userin = 100;
    Console.WriteLine("What would you like the largest value of your Fibonacci list to be? : ");
    userin = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < userin;)       //i is the total or the result of the previous 2 numbers being added
    {
        i = nbr1 + nbr2;
        nbr1 = nbr2;
        nbr2 = i;
        Console.Write($"{i},");
    }
}

//Fibonacci();
                            //Improved fib method, controls where the numbers start but does not exceed 100
void Fib(int a, int b)
{
    int c = 0;
    c = a + b;
    if (c > 100) return;
    Console.Write($" {c} ,");
    Fib(c, b);
}

Fib(2,9);


////how greg did it
//int a = 1;
//int b = 1;
//int c = 0;
//while (c < 100)
//{
//    c = Add(a,b);
//    Debug.WriteLine($"a = {a} b = {b} c = {c}");
//    Trace.WriteLine($"a = {a} b = {b} c = {c}");
//    Console.Write($"{c}, ");
//    a = b;
//    b = c;

//}

//int Add(int a, int b)
//{
//    return a + b;
//}
////Debugging Lesson Using Previous Code
