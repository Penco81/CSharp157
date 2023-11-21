namespace CSharp157;

/// <summary>
/// 使用默认的转型方法
/// </summary>
public class Tips2
{
    //1 使用类型的转换运算符
    private int i = 0;
    private float j = 0;

    //存在隐式转换
    j = i;

    //显式转换
    i = (int) j
    //基元类型指的是编译器直接支持的数据类型，如：
    //sbyte、byte、short、ushort、int、uint. longs ulong、char、float、double、
    //bool, decimal, object, string.

    //用户自定义的类型也可以通过重载转换运算符来提供
    class Ip
    {
        IPAddress value;
        public Ip(string ip)
        {
            value = IPAddress.Parse(ip);
        }

        public static implicit operator Ip(string ip)
        {
            Ip iptemp = new Ip(ip);
            return iptemp;
        }

        public override string ToString()
        {
            return value.ToString();
        }
    }
    
    //使用类型内置的API
    //Parse、TryParse，或者如ToString、ToDouble、ToDateTime 等方法
    //好处
    //1 错误处理
    //2 避免异常
    //3 性能优化
    //4 更好的可读性
    
    //使用帮助类提供的方法
    //如
    //可以使用如System.Convert 类、System.BitConverter 类来进行类型的转换。
    //自定义的需要实现IConverible接口
}