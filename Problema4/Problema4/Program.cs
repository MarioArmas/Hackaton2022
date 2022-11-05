Console.WriteLine("Ingrese el total de amigos");
int portions = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la cantidad de porciones que quiere c/u");
int friends = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Mínimo de pasteles necesarios: " + distribute(portions, friends));

int distribute(int _portions, int _friends) {
    double totalPortions = _portions * _friends;
    const double PORTIONS_PER_CAKE = 4;
    double totalCakes = totalPortions / PORTIONS_PER_CAKE;
    return Convert.ToInt32(Math.Ceiling(totalCakes));
}