namespace CSharp157;

//区别readonly和const的使用方法
public class Tips6
{
    //要使用const 的理由 只有一个，那就是效率。但是，在大部分应用情况下，“ 效率〞并没有那么高的地位， 所以我更愿意采用readonly，因为readonly 赋 予代码更多的灵活性。
    
    //const 是一个编译期常量，readonly 是一个运行时常量。
    //const 只能修饰基元类型、枚举类型或字符串类型，readonly没有限制。
    
    //因为const 是编译期常量，所以它天然就是static的，不能手动再 为 c o n s t 增 加 一个 s t a t i c 修 饰 符
    //const在编译时会被实际的值替代
    
    //readonly在运行时第一次被赋值后将不可以改变，一般在构造函数中
    // 对 于 值 类 型 变 量 ， 值 本 身 不 可 改 变 (r e a d o n l y ， 只 读 )。
    //对 于引用类型变量，引用本身 (相 当于指针 )不可改变。
    //在构造函数中，readonly可以被多次赋值，readonly的初始化器可以理解为构造函数的一部分
}