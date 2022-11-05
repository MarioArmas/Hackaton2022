void menu() {
    string num1 = "";
    string num2 = "";
    Console.WriteLine("Presione (s) si desea sumar o (r) si desea restar");
    ConsoleKey inputOperation = Console.ReadKey().Key;
    Console.WriteLine();
    if (inputOperation != ConsoleKey.S && inputOperation != ConsoleKey.R) {
        Console.WriteLine("Las teclas ingresadas no son correctas");
        return;
    }
    
    Console.WriteLine("Presione (d) si desea ingresar los números en decimal, presione (b) si desea ingresarlos en binario o (h) si desea ingresarlos en hexadecimal");
    ConsoleKey numericSystem = Console.ReadKey().Key;
    Console.WriteLine();
    if (numericSystem != ConsoleKey.D && numericSystem != ConsoleKey.B && numericSystem != ConsoleKey.H) {
        Console.WriteLine("Las teclas ingresadas no son correctas");
        return;
    }
    
    Console.WriteLine("Ingrese los números que desea operar");
    num1 = Console.ReadLine();
    num2 = Console.ReadLine();
    int result = 0;

    // convert to decimal
    if (numericSystem == ConsoleKey.B) {
        num1 = binaryToDecimal(num1);
        num2 = binaryToDecimal(num2);
    }
    if (numericSystem == ConsoleKey.H)
    {
        num1 = hexadecimalToDecimal(num1);
        num2 = hexadecimalToDecimal(num2);
    }

    // operations
    if (inputOperation == ConsoleKey.S) {
        result = Convert.ToInt32(num1) + Convert.ToInt32(num2);
    }

    if (inputOperation == ConsoleKey.R) {
        result = Convert.ToInt32(num1) - Convert.ToInt32(num2);
    }

    Console.WriteLine("Resultado decimal: " + result);
    Console.WriteLine("Resultado binario: " + decimalToBinary(result));
    Console.WriteLine("Resuttado hexadecimal: " + decimalToHexadecimal(result));
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
        else if (hex[i] == 'B' || hex[i] == 'b') val = 11;
        else if (hex[i] == 'C' || hex[i] == 'c') val = 12;
        else if (hex[i] == 'D' || hex[i] == 'd') val = 13;
        else if (hex[i] == 'E' || hex[i] == 'e') val = 14;
        else if (hex[i] == 'F' || hex[i] == 'f') val = 15;
        else val = (int)Char.GetNumericValue(hex[i]);

        decimalNum += counter * val;
        counter *= 16;
    }

    return decimalNum.ToString();
}

string decimalToHexadecimal(int Num) {
    int count = 1, val = 0;
    char[] VecHexa = new char[100];
    char character;
    while (Num != 0)
    {
        val = Num % 16;
        if (val < 10)
            val = val + 48;
        else
            val = val + 55;
        character = Convert.ToChar(val);
        VecHexa[count++] = character;
        Num = Num / 16;
    }
    for (int j = val - 1; j > 0; j--)
        Console.Write(VecHexa[j]);
    Console.Read();

    return VecHexa.ToString();
}

menu();