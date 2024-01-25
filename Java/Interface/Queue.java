package Interface;
import java.util.PriorityQueue;
import java.util.Scanner;
public class Queue implements Input{
    PriorityQueue<String> queue = new PriorityQueue<String>();
//    @Override
    public int input_number()
    {
        Scanner scan = new Scanner(System.in);
        int number = scan.nextInt();
        return number;
    }
    public String input_word()
    {
        Scanner scan = new Scanner(System.in);
        String word = scan.nextLine();
        return word;
    }
    public void inter()
    {
            System.out.println("Введите слово для заполнения queue:");
            queue.add(input_word());
            System.out.println("Выберите дальнейшие действия \n 1. Вывести первый элемент очереди; \n 2. Вывести все элементы очереди; \n 3. Выход.");
    }
    void invis_inter()
    {
        inter();
        switch (input_number()) {
            case 1:
                System.out.println(queue.peek());
                break;
            case 2:
                while (queue.peek() != null) {
                    System.out.println(queue.peek());
                    queue.remove(queue.peek());
                }
                break;
            case 3:
                Menu menu = new Menu();
                menu.invis_inter();
                break;
            default:
                System.out.println("Повторите ввод");
        }
        invis_inter();
    }
}
