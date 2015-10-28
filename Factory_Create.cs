/*
 * 1.��һְ��
 * ϵͳ�е�ÿһ������Ӧ��ֻ��һ��������ְ�����ж����ע��Ӧ��������ְ������
 * ����˼�룺���ھۣ������
 * 2.��������
 * һ���������չ���ţ����޸Ĺرա�
 * ����˼�룺����ĸĶ���ͨ�����Ӵ�����еģ��������޸����еĴ���
 * 3.�����滻ԭ��
 * �����⸸����ֵĵط���������ʹ��������档
 * 4.����ע��ԭ��
 * Ҫ�����ڳ��󣬲�Ҫ�����ھ����ʵ�֡�
 * ����˼�룺�ڿ����о���������ӿڱ�̡�
 * 5.�ӿڷ���ԭ��
 * ��Ҫȥʹ��һЩ����Ҫ�Ĺ��ܡ�
 * ����˼�룺һ���ӿڲ�Ҫ�ṩ̫�����Ϊ��
 * 6.������ԭ��
 * һ������������Ķ���Ӧ�þ������ٵ��˽�
 * ����˼�룺�������
 * 7.����ʹ����϶����Ǽ̳�ԭ��
 * ����˼�룺�ڸ��ö����ʱ��Ҫ���ȿ�����ϣ������Ǽ̳С�
 * ��Ϊ������κθı䶼����ֱ��Ӱ�������
*/

public abstract class Animal {
    public abstract void eat();
}

public class Dog : Animal {
    public void eat() {
        Console.WriteLine("dog eat");
    }
}

public class Pig : Animal {
    public void eat() {
        Console.WriteLine("pig eat");
    }
}

public class AnimalFactory {

    private AnimalFactory() { 
    
    }

    public static Animal animalFactory(String str)
    {
        if (string.Equals(""))
        {
            return new Dog();
        }
        else if (string.Equals(""))
        {
            return new Pig();
        }
        else
            return null;

    }
}