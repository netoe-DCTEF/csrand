<h1>Liberty, Freedom. Just open source does it. From NEWCORP.ltda </h1>

<h2>A random number generator in C# without repetitions, in development!</h2>

<h3> PS:To use this library correctly, you have to create an object!</h3>

~~~c#
  RandForCs.Rand rand = new RandForCs.Rand();
~~~~

<br>
<p>
  This library works with <strong> C# Lists. <strong> To use, I </strong>strongly</strong> recommend to create in the main function or in a global scope, 
  the List only works for that class instantiation.
</p>

~~~c#
namespace Gooteemmm
{
    class YeahBoy
    {
      static void Main(string[] args)
      {
          RandForCs.Rand rand = new RandForCs.Rand();
          Console.WriteLine("Random Years:" + rand.generateRand(2022));       
      }
    }
}
~~~~
<br>

<p>
    The generateRandom(int limit) function generates a non-repeating random number if the list is empty.
    You have to put a limit as a parameter when calling the function. The number that will be generated will be between 0 and the limit you set.
</p>

<h2> Good usage, see ya!</h2>
