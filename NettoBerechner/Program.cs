// Netto Rechner :) made by Joel

Console.BackgroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("   Guten Tag geben sie ihren Namen an");
string name = Console.ReadLine();
Console.WriteLine("");
Console.WriteLine("Gebe deinen Monatslohn an");
float Monatslohn = Int32.Parse(Console.ReadLine());
Console.WriteLine("");
Console.WriteLine("Gebe deinen Jahreslohn an");
float JahresLohn = Int32.Parse(Console.ReadLine());


Monatslohn = (Monatslohn / 1.2f);
JahresLohn = (JahresLohn / 1.2f);

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("   Guten Tag" + "." + name);
Console.WriteLine("");
Console.WriteLine("   Dein MonatsLohn Netto:" + Monatslohn);
Console.WriteLine("");
Console.WriteLine("   Dein JahresLohn Netto:" + JahresLohn);
Console.ReadKey();
