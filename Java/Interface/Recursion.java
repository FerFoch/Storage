package Interface;
import java.util.Arrays;
import java.util.InputMismatchException;
import java.util.Scanner;

public class Recursion {

    void inter()
    {
        System.out.println("Выберите действие:\n1.Вывести массив на экран \n2.Отсортировать массив \n3.Назад");
    }
    int input_number()
    {
        Scanner scan = new Scanner(System.in);
        int number = 0;
        try
        {
            number = scan.nextInt();
        }
        catch (InputMismatchException e)
        {
            System.out.println("Повторите ввод");
            input_number();
        }
        finally
        {
            return number;
        }
    }
    public int[] maasinit()
    {
        System.out.println("Введите количество символов в массиве:");
        int[] maas;
        maas = new  int[input_number()];
        for (int i = 0; i < maas.length;i++)
        {
            System.out.println("Введите " + i + " элемент массива:");
            maas[i] += input_number();
        }
        return maas;
    }
    void invisible_inter()
    {
        int[] maas = maasinit();
        for (;;) {
            inter();
            switch (input_number()) {
                case 1:
                    System.out.println(Arrays.toString(maas));
                    break;
                case 2:
                    maas = mergeSort(maas);
                    System.out.println("Массив отсортирован\n");
                    break;
                case 3:
                    Menu menu = new Menu();
                    menu.invis_inter();
                    break;
                default:
                    System.out.println("Повторите ввод");
            }
        }
    }
    public static int[] mergeSort(int[] maas) {
        if (maas.length <= 1) return maas;
        int[] left = Arrays.copyOfRange(maas, 0, maas.length / 2);
        int[] right = Arrays.copyOfRange(maas, left.length, maas.length);
        return merge(mergeSort(left), mergeSort(right));
    }

    private static int[] merge(int[] left, int[] right) {
        int resIn = 0, leftIn = 0, rightIn = 0;
        int[] result = new int[left.length + right.length];

        while (leftIn < left.length && rightIn < right.length)
            if (left[leftIn] < right[rightIn])
                result[resIn++] = left[leftIn++];
            else result[resIn++] = right[rightIn++];

        while (resIn < result.length)
            if (leftIn != left.length)
                result[resIn++] = left[leftIn++];
            else result[resIn++] = right[rightIn++];

        return result;
    }

}

