using System;

try
{
    Console.WriteLine("Informe o primeiro valor:");
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Informe o segundo valor:");
    int b = int.Parse(Console.ReadLine());
    int resultado = a / b;
    Console.WriteLine($"O resultado é:  { resultado}");
}
catch(DivideByZeroException ex)//posso fazer mais de um catch ---- Esse catch é especifico
{
    Console.WriteLine($"Não é permitido divisão por zero! {ex.Message}");
}
catch (InvalidCastException ex)//posso fazer mais de um catch
{
    Console.WriteLine($"Conversão de string para letra não é permitida! {ex.Message}");
}
catch (Exception ex)//posso fazer mais de um catch -------- Esse é generico
{
    Console.WriteLine($"Ocorreu um erro! {ex.Message}");
}