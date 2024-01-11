import java.util.Queue;
import java.util.Scanner;
import java.util.PriorityQueue;
import java.util.Stack;
public class queue_stack {

    public static void main(String[] args) {
        Stack();
        PriorityQueue<String> queue = new PriorityQueue<String>();
        boolean Exit = false;
        while (Exit != true)
        {
            System.out.println("Введите слово для заполнения queue:");
            Scanner scan = new Scanner(System.in);
            String word = scan.nextLine();
            queue.add(word);
            System.out.println("Выберите дальнейшие действия \n 1. Вывести первый элемент очереди; \n 2. Вывести все элементы очереди; \n 3. Выход.");
            int number = scan.nextInt();
            switch (number) {
                case 1:
                    System.out.println(queue.peek());
                    break;
                case 2:
                    while(queue.peek()!=null)
                    {
                        System.out.println(queue.peek());
                        queue.remove(queue.peek());
                    }
                    break;
                case 3:
                    Exit = true;
                    break;
            }
        }
    }
    public static void Stack()
    {
        Stack<String> stack = new Stack<String>();
        boolean Exit = false;
        while (Exit != true)
        {
            System.out.println("Введите слово для заполнения stack:");
            Scanner scan = new Scanner(System.in);
            String word = scan.nextLine();
            stack.push(word);
            System.out.println("Выберите дальнейшие действия \n 1. Вывести первый элемент очереди; \n 2. Вывести все элементы очереди; \n 3. Найти символ; \n 4. Выход.");
            int number = scan.nextInt();
            switch (number) {
                case 1:
                    System.out.println(stack.peek());
                    break;
                case 2:
                    while(stack.size() != 0)
                    {
                        String a = (String) stack.pop();
                        System.out.println(a);
                    }
                    break;
                case 3:
                    System.out.println("Введите номер искомого символа");
                    int search_number = scan.nextInt();
                    System.out.println(stack.search(search_number));
                    break;
                case 4:
                    Exit = true;
                    break;
            }
        }
    }
}
