String Usuario;
String traducao;

Console.Clear();


Console.WriteLine("traduzindo para baleiês");
Console.WriteLine("Escreva seu nome.");

Usuario = Console.ReadLine()!;


traducao = Usuario.Replace("a", "aaa")
                .Replace("A", "AAA")
                .Replace("E", "EEE")
                .Replace("e", "eee")
                .Replace("I", "III")
                .Replace("i", "iii")
                .Replace("O", "OOO")
                .Replace("o", "ooo")
                .Replace("u", "uuu")
                .Replace("U", "UUU");
                

Console.WriteLine($"Seu nome em baleiês fica assim {traducao}.");
