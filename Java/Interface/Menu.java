package Interface;
import java.util.Scanner;

public class Menu {
    void inter()
    {
        System.out.println("Выберите действие: \n1.stack \n2.queue \n3.Выход");
    }
    int input_number()
    {
        Scanner scan = new Scanner(System.in);
        int number = scan.nextInt();
        return number;
    }
    void invis_inter()
    {
        inter();
        switch(input_number())
        {
            case 1:
                Stackk stack = new Stackk();
                stack.invis_inter();
            case 2:
                Queue queue = new Queue();
                queue.invis_inter();
            case 3:
                System.exit(0);
            default:
                System.out.println("Повторите ввод");
        }
        invis_inter();
    }
}
