int incremento = 0, contador =0;
Console.WriteLine("Ingresar Texto");
string texto = Console.ReadLine();
string[] info = new string[texto.Length];
string[] dic = new string[] { "A","E","I","O","U" };
while (incremento < texto.Length)
{
    texto[incremento].ToString();
    info[incremento] = texto[incremento].ToString();
    incremento++;
}
for (int j = 0; j < texto.Length; j++)
{
    for (int i = 0; i < dic.Length; i++)
    {
        if (info[j].ToUpper() == dic[i])
        {     
            contador++;
        }
    }
}
Console.WriteLine("Hay " + contador + " vocales :D");