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

<?php
 class DB{
 
	private $link;
	private static $instance;

	private function __construct(){
		$this->link = mysql_connect('localhost','root','');
		mysql_select_db('base',$this->link);
	}

	static function getInstance(){
		if(is_null(self::$instance)){
			self::$instance = new self;
		}
		return self::$instance;
	}

	function select(){
			$sql = "select * from factory";
			#result = mysql_query($sql);
			if($result && mysql_num_rows($result)){
				while($arr = mysql_fetch_assoc($result)){
				$data[] = $arr;
				}
				return $data;
			}
			else{
				return false;
			}
			
	}
 }
