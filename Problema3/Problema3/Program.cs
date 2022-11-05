
Console.WriteLine("Ingrese el número del cual desea sacar el factorial");
int input = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(factorial(input));

int factorial(int num) {
    int result = 1;
    for (int i = num; i > 0; i--) {
        result *= i;
    }

    return result;
}