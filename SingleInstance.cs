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

/*
 * http://www.cnblogs.com/yydcdut/p/3842713.html
 * 
 */
public class Single1 {

    private Single1(){}

    private static Single1 instance = new Single1();
    public static Single1 getInstance()
    {
        return instance;
    }
}

public class Single2 {

    private Single2() { }

    private static Single2 instance = null;

    public static Single2 getInstance() {
        if (instance == null)
        {
            return instance = new Single2();
        }
        return instance;
    }

}
