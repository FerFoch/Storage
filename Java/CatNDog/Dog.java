//
// Source code recreated from a .class file by IntelliJ IDEA
// (powered by FernFlower decompiler)
//

package CatNDog;

public class Dog {

    public void sayHello() {
        System.out.println("Гав!");
    }

    public void catchCat(Cat cat) {
        System.out.println("Кошка поймана");
        this.sayHello();
        cat.sayHello();
    }
}
