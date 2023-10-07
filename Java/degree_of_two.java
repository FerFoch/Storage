import java.util.Scanner;

public class degree_of_two {
    public static void main(String[] args) {
            Scanner scan = new Scanner(System.in);
            int numb = scan.nextInt();
            int count = 0;
            String byte_numb = Integer.toString(numb, 2);
            Scanner scan1 = new Scanner(System.in);
            System.out.println("Введите сдвиг");
            int numb_4_shift = scan1.nextInt();
            System.out.println(byte_numb);
            char[] charArray = byte_numb.toCharArray();
            char[] charArray_shift = charArray;
            for(int i = 0; i < byte_numb.length(); i++) {
                if (charArray[i] == '1') {
                    count++;
                }
                if (charArray_shift[numb_4_shift] == '1')
                {
                    charArray_shift[numb_4_shift] = '0';
                }
                if (charArray_shift[numb_4_shift] == '0')
                {
                    charArray_shift[numb_4_shift] = '1';
                }
            }
            if (count == 1) {
                System.out.println("Число в степени двойки");
            } else {
                System.out.println("Число не в степени двойки");
            }
        slash();
        }
        public static void slash() {
            Scanner scan = new Scanner(System.in);
            int numb = scan.nextInt();
            // int \U+002F;
            char slash = 0x5c;
            System.out.println((char)((int)slash + numb));
        }
    }