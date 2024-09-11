// See https://aka.ms/new-console-template for more information

/*int räknare;
for(räknare=0;räknare<=20;räknare++)
{
    Console.WriteLine(räknare+" ");
}*/


{
int antaltal;
double summa = 0, input;
double smallest = 0;
double biggest = 0;
Console.WriteLine("antal tal som matas in?");
antaltal = Convert.ToInt32(Console.ReadLine());
int tal = int.Parse(Console.ReadLine());
for(int i=1 ;i<=antaltal; i++)
{
    
    
    
    if(i == 1)
        biggest = input;
        smallest = input;
    if(smallest <= input)
        smallest=input;
    

        else if(biggest >= input)
            biggest=input;

            Console.WriteLine("skriv värde " + i + ": ");
    input = Convert.ToDouble(Console.ReadLine());
    summa = summa + input;
    

    Console.WriteLine("medelvärdet är: " + (summa/antaltal));
    Console.WriteLine("mista värdet är: " + (smallest=input));
    Console.WriteLine("ditt högsta värde är: " + (smallest=input));
}
}


