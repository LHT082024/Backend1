using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Xml.XPath;

namespace Backend1;

class Program
{
    static void Main(string[] args)
    {
        //åpningslinje
        string openingTxt = "pluss or minus";
        Console.WriteLine(openingTxt);
        
        //henter kalkulatoren
         Calcualtor calcualtor = new Calcualtor();

        //leser user input
         string? mathSymbols = Console.ReadLine();

         //henter switchyWitchy metoden
         switchyWitchy(mathSymbols, calcualtor); 
    }


    //user input methode console.write lets you add a number for every 
    public static double UserInput(){
        Console.Write("Write your equation here: "); //5 + 4 // result
        string? input = Console.ReadLine();
        return Convert.ToDouble(input); 
    }


   //metode hvor eg utfører en switch statment 
    public static void switchyWitchy(string mathSymbols,Calcualtor mathWizard){
        //resultat vil være en double men double blir sur hvis den ikke har en verdi
        //så double er like null for nå.
        double? result = null;

        //sier hvis user skriver + så bruker du add fra calculator og hvis user skriver minus så 
        //skal den bruke subtract fra calculator.
        switch (mathSymbols) 
        {
            case "+":
            result = mathWizard.Add(UserInput(), UserInput()); 
            break; 

            case "-":
            result = mathWizard.Subtract(UserInput(), UserInput());
            break; 
        } 
        Console.WriteLine (result);

    }
}


