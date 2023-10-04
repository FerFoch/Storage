using System.Text;
void div_by_3(int number)
{
    if (number % 3 == 0)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
void div_by_57(int number)
{
    if (number % 5 == 2 && number % 7 == 1)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
void div_by_4(int number)
{
    if (number % 4 == 0 && number > 10)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
void dia(int number)
{
    if (number >= 5 && number <= 10)
    {
        Console.WriteLine("True");
    }
    else
    {
        Console.WriteLine("False");
    }
}
void thousand(int number)
{
    string str_number = Convert.ToString(number);
    Console.WriteLine(str_number[str_number.Length - 4]);
}
void right_2_in_8(int number)
{
    string eight_number = Convert.ToString(number, 8);
    Console.WriteLine(eight_number[eight_number.Length - 2]);
}
void right_3_in_2(int number)
{
    string number_in_2 = Convert.ToString(number, 2);
    int shift_number = (number >> 2);
    string str_shift_number = Convert.ToString(shift_number, 2);
    Console.WriteLine(str_shift_number[str_shift_number.Length - 1]);
}
void third_in_2(int number)
{
    string number_in_2 = Convert.ToString(number);
    char replacement = '1';
    StringBuilder new_str_number_in_2 = new StringBuilder(number_in_2);
    new_str_number_in_2[3] = replacement;
    number_in_2 = new_str_number_in_2.ToString();
    Console.WriteLine(number_in_2);
}
void fourth_in_2(int number)
{
    string number_in_2 = Convert.ToString(number);
    char replacement = '0';
    StringBuilder new_str_number_in_2 = new StringBuilder(number_in_2);
    new_str_number_in_2[4] = replacement;
    number_in_2 = new_str_number_in_2.ToString();
    Console.WriteLine(number_in_2);
}
void change_second_in_2(int number)
{
    string number_in_2 = Convert.ToString(number);
    char replacement_0 = '0';
    char replacement_1 = '1';
    StringBuilder new_str_number_in_2 = new StringBuilder(number_in_2);
        if (new_str_number_in_2[2] == '1')
        {
            new_str_number_in_2[2] = replacement_0;
        }
        else 
        {
            new_str_number_in_2[2] = replacement_1;
        }
    number_in_2 = new_str_number_in_2.ToString();
    Console.WriteLine(number_in_2);
}
int def()
{
    int num;
    while (true)
    {
        Console.WriteLine("Введите число:");
        try
        {
            num = int.Parse(Console.ReadLine());
            break;
        }
        catch (Exception)
        {
            Console.WriteLine("Неправильный ввод");
            continue;
        }

    }
    return num;
}
void main()
  {
    Console.WriteLine("Выберите номер задания:");
    string Task = Console.ReadLine(); 
    switch (Task)
    {
        case "1":
            div_by_3(def());
            break;
        case "2":
            div_by_57(def());
            break;
        case "3":
            div_by_4(def());
            break;
        case "4":
            dia(def());
            break;
        case "5":
            thousand(def());
            break;
        case "6":
            right_2_in_8(def());
            break;
        case "7":
            right_3_in_2(def());
            break;
        case "8":
            third_in_2(def());
            break;
        case "9":
            fourth_in_2(def());
            break;
        case "10":
            change_second_in_2(def());
            break;
    }
  }
main();
