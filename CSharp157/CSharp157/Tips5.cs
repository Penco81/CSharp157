namespace CSharp157;

//使用int？来确保值类型也可以为null
public class Tips5
{
    //int？ 底层实现是一个结构体，一个为值本身，一个为表示是否已经初始化过了
    //T？ 是 NUllable<T>的语法糖
    
    //可空类型不可隐式转换为对应的基元类型
    //通常配合？？运算符在一起使用
}