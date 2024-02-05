package Interface;
import java.util.Scanner;
public class Stackk implements Input, Inter {

        java.util.Stack<String> stack = new java.util.Stack<String>();
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
            System.out.println("Введите слово для заполнения stack:");
            stack.push(input_word());
            System.out.println("Выберите дальнейшие действия \n 1. Вывести первый элемент очереди; \n 2. Вывести все элементы очереди; \n 3. Найти символ; \n 4. Назад.");
        }
        void invis_inter() {
            inter();
            switch (input_number()) {
                case 1:
                    System.out.println(stack.peek());
                    break;
                case 2:
                    while (!stack.isEmpty()) {
                        String a = (String) stack.pop();
                        System.out.println(a);
                    }
                    break;
                case 3:
                    System.out.println("Введите номер искомого символа");
                    System.out.println(stack.search(input_number()));
                    break;
                case 4:
                    Menu menu = new Menu();
                    menu.invis_inter();
                    break;
                default:
                    System.out.println("Повторите ввод");
            }
            invis_inter();
        }
}


