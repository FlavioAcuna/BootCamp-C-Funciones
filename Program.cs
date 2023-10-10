/*
Funcion en Js
function nombre(param1, param2)
{
    return valor;
}
*/
static int SumaDosNumeros(int num1, int num2)
{
    int total = num1 + num2;
    return total;
};
//Para no tener un valor de retorno 
static void ImprimiendoHola(string nombre)
{
    Console.WriteLine($"Hola, Como estas {nombre}!");
}

int resultado = SumaDosNumeros(30, 20);
Console.WriteLine(resultado);
ImprimiendoHola("Alex");