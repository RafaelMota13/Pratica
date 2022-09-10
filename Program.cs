Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
string nome = "Rafael"
                .ToUpper()
                .Replace("E", "xx")
                .Replace("RA","WZY");
string Sobrenome = "Mota";

string nomeCompleto =$"{nome}\n{Sobrenome.ToLower()}";

string citacao = $"A Etec é a melhor escola.";
Console.WriteLine(nomeCompleto);
Console.WriteLine(citacao);


#pragma warning disable CA1416

Console.Beep(1132,350);
Console.Beep(1485,350);
Console.Beep(1650,350);
Console.Beep(1759,550);
Console.Beep(1759,350);
Console.Beep(1759,350);
Console.ResetColor();