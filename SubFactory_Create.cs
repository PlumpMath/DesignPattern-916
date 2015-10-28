/*
 * 1.单一职责
 * 系统中的每一个对象应该只有一个单独的职责，所有对象关注的应该是自身职责的完成
 * 基本思想：高内聚，低耦合
 * 2.开闭严则
 * 一个对象对扩展开放，对修改关闭。
 * 基本思想：对类的改动是通过增加代码进行的，而不是修改现有的代码
 * 3.里氏替换原则
 * 在任意父类出现的地方，都可以使用子类代替。
 * 4.依赖注入原则
 * 要依赖于抽象，不要依赖于具体的实现。
 * 基本思想：在开发中尽量的面向接口编程。
 * 5.接口分离原则
 * 不要去使用一些不需要的功能。
 * 基本思想：一个接口不要提供太多的行为。
 * 6.迪米特原则
 * 一个对象对其他的对象应该尽可能少的了解
 * 基本思想：降低耦合
 * 7.优先使用组合而不是继承原则。
 * 基本思想：在复用对象的时候，要优先考虑组合，而不是继承。
 * 因为父类的任何改变都可能直接影响子类的
*/

public abstract class Animal {

    public abstract void sleep();
}

public interface AnimalFactory {
    public Animal createAnimal();
}


public class Dog : Animal {

    public void sleep() {
        Console.WriteLine("dog sleep");
    }
}

public class DogFactory : AnimalFactory{

    public Animal createAnimal() {
        return new Dog();
    }
}