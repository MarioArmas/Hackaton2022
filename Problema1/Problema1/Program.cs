void menu() {
    string num1 = "";
    string num2 = "";
    Console.WriteLine("Presione (s) si desea sumar o (r) si desea restar");
    ConsoleKey inputOperation = Console.ReadKey().Key;
    if (inputOperation != ConsoleKey.S && inputOperation != ConsoleKey.R) {
        Console.WriteLine("Las teclas ingresadas no son correctas");
        return;
    }
    
    Console.WriteLine("Presione (d) si decea ingresar los números en decimal, presione (b) si desea ingresarlos en binario o (h) si desea ingresarlos en hexadecimal");
    ConsoleKey numericSystem = Console.ReadKey().Key;
    if (numericSystem != ConsoleKey.D && numericSystem != ConsoleKey.B && numericSystem != ConsoleKey.H) {
        Console.WriteLine("Las teclas ingresadas no son correctas");
        return;
    }
    
    Console.WriteLine("Ingrese los números que desea operar");
    num1 = Console.ReadLine();
    num2 = Console.ReadLine();

    if (numericSystem == ConsoleKey.B)
    {
        num1 = binaryToDecimal(num1);
        num2 = binaryToDecimal(num2);
    }

    if (inputOperation == ConsoleKey.S)
    {
        int result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
    }

    if (inputOperation == ConsoleKey.R)
    {
        int result = Convert.ToInt32(num1) - Convert.ToInt32(num2);

    }
}


string binaryToDecimal(string binary) {
    int decimalNum = 0;
    int counter = 1;

    for (int i = binary.Length - 1; i >= 0; i--) {
        int val = (int)Char.GetNumericValue(binary[i]);
        decimalNum += counter * val;
        counter *= 2;
    }

    return decimalNum.ToString();
}

string decimalToBinary(int decimalNum) {
    string binary = "";

    while (decimalNum != 0) {
        int digit = decimalNum % 2;
        decimalNum -= digit;
        binary += digit;
        decimalNum /= 2;
    }

    char[] myArr = binary.ToCharArray();
    Array.Reverse(myArr);
    return new string(myArr);
}

string hexadecimalToDecimal(string hex) {
    int decimalNum = 0;
    int counter = 1;

    for (int i = hex.Length - 1; i >= 0; i--)
    {
        int val;
        if (hex[i] == 'A' || hex[i] == 'a') val = 10;
        if (hex[i] == 'B' || hex[i] == 'b') val = 11;
        if (hex[i] == 'C' || hex[i] == 'c') val = 12;
        if (hex[i] == 'D' || hex[i] == 'd') val = 13;
        if (hex[i] == 'E' || hex[i] == 'e') val = 14;
        if (hex[i] == 'F' || hex[i] == 'f') val = 15;
        else val = (int)Char.GetNumericValue(hex[i]);

        decimalNum += counter * val;
        counter *= 16;
    }

    return decimalNum.ToString();
}