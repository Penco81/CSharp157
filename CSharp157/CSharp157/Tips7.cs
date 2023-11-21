namespace CSharp157;

/// <summary>
/// 将0值作为枚举的默认值
/// </summary>
public class Tips7
{
    //枚举的默认值为0，所以应该从0开始，不然会找不到
    //可以将显式为元素赋值去掉， 编译器会自动从又值开始计数，然后逐个为元素的值 +1。
}