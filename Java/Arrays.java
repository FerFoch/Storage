import java.util.Arrays;
import java.util.Scanner;
import java.util.ArrayList;

public class Array {

    public static void main(String[] args) {
        int lower_limit, upper_limit;
        int amount = (int)(Math.random()*(10-3)) + 3;
        ArrayList<Integer> numbers = new ArrayList<>(amount);
        ArrayList<Integer> result = new ArrayList<>();
        System.out.println("Первое задание");
        upper_limit = input_1_to_100();
        lower_limit = input_1_to_100();
        for (int i = 0; i < amount;i++)
        {
            numbers.add((int) (Math.random() * (100 - 1)) + 1);
            if (lower_limit < upper_limit)
            {
                if (numbers.get(i) > lower_limit && numbers.get(i) < upper_limit)
                {
                    result.add(numbers.get(i));
                }
            }
            else
            {
                if (numbers.get(i) > upper_limit && numbers.get(i) < lower_limit)
                {
                    result.add(numbers.get(i));
                }
            }
        }
        System.out.println(numbers);
        System.out.println(result);
        array_mid();
        reshuffle();
        union_sort();
    }
    public static void array_mid() {
        System.out.println("Второе задание");
        int amount = input_1_to_100();
        ArrayList<Integer> result = new ArrayList<>();
        ArrayList<Integer> numbers = new ArrayList<>(amount);
        for (int i = 0; i < amount;i++) {
            numbers.add((int) (Math.random() * (100 - 1)) + 1);
        }
        System.out.println(numbers);
        if (amount % 2 == 0)
        {
            result.add(numbers.get(amount/2-1));
            result.add(numbers.get(amount/2));
            System.out.println(result);
        }
        else {
            result.add(numbers.get(amount/2));
            System.out.println(result);
        }
    }
    public static int input_1_to_100()
    {
        char number;
        int number_int;
        Scanner scan = new Scanner(System.in);
        for (;;)
        {
            System.out.println("Введите значение");
            number = scan.next().charAt(0);;
            if (Character.isDigit(number) == true && number != ' ')
            {
                number_int = Character.getNumericValue(number);
                if (number_int >= 1 && number_int <= 100)
                {
                    break;
                }
            }
        }
        return number_int;
    }
    public static void reshuffle() {
        System.out.println("Третье задание");
        int amount = input_1_to_100();
        ArrayList<Integer> number = new ArrayList<>(amount);
        ArrayList<Integer> shuffle = new ArrayList<>();
        for (int i = 0; i < amount;i++)
        {
            number.add((int) (Math.random() * (100 - 1)) + 1);
        }
        for (int i = 0; i < amount;i++)
        {
            shuffle.add(number.get((amount-1) - i));
        }
        System.out.println(number);
        System.out.println(shuffle);
    }
    public static void union_sort() {
        System.out.println("Четвертое задание");
        int amount = input_1_to_100();
        int amount1 = input_1_to_100();
        int temp = 0;
        int[] array1 = new int[amount];
        int[] array2  = new int[amount1];
        int[] result = new int[amount+amount1];
        for (int i = 0; i < amount;i++)
        {
            array1[i] = ((int) (Math.random() * (100 - 1)) + 1);
            result[i] = array1[i];
            System.out.print("[");
            System.out.print(array1[i]);
            System.out.print("]");
        }
        System.out.println();
        for (int i = 0; i < amount1;i++)
        {
            array2[i] = ((int) (Math.random() * (100 - 1)) + 1);
            result[i+amount] = array2[i];
            System.out.print("[");
            System.out.print(array2[i]);
            System.out.print("]");
        }
        System.out.println();
        Arrays.sort(result);
        for (int i = 0; i < result.length - 1; i++)
        {
            System.out.print("[");
            System.out.print(result[i]);
            System.out.print("]");
        }
    }
}