try {
    Console.WriteLine("Ingrese el número del cual desea sacar el factorial");
    int input = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Resultado: " + factorial(input));
}
catch {
    Console.WriteLine("Debe ingresar un número entero");
}

int factorial(int num) {
    int result = 1;
    for (int i = num; i > 0; i--) {
        result *= i;
    }

    return result;
}