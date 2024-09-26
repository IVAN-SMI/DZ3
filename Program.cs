double? par1 = null;
double? par2 = null;
double? par3 = null;
double? par4 = null;
double? par5 = null;
int[]? nums1;

Console.WriteLine("С целью расчета среднего арифметического значения введите 4 числа");

try
{
    Console.WriteLine("Введите первое число: ");
    par1 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка! Введены некорректные данные");
}

try
{
    Console.WriteLine("Введите второе число: ");
    par2 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка! Введены некорректные данные");
}

try
{
    Console.WriteLine("Введите третье число: ");
    par3 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка! Введены некорректные данные");
}

try
{
    Console.WriteLine("Введите четвертое число: ");
    par4 = Convert.ToDouble(Console.ReadLine());
}
catch
{
    Console.WriteLine("Ошибка! Введены некорректные данные");
}

try
{
    nums1 = [(int)par1, (int)par2, (int)par3, (int)par4];
    Console.WriteLine("Первое введенное значение : " + nums1[0]);
    Console.WriteLine("Второе введенное значение : " + nums1[1]);
    Console.WriteLine("Третье введенное значение : " + nums1[2]);
    Console.WriteLine("Четвертое введенное значение : " + nums1[3]);

    par5 = ((int)par1 + (int)par2 + (int)par3 + (int)par4) / 4.0;

    Console.WriteLine("Cреднее арифметическое значение всех введённых чисел : " + par5);
}
catch
{
    Console.WriteLine("Ошибка! Введены некорректные данные. Расчет не может быть выполнен.");
}

Console.ReadKey();