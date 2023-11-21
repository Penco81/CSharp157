namespace CSharp157
{
  /// <summary>
  /// 正确使用字符串
  /// </summary>
  class Tips1
  {
    private String str = "abc" + 9;
    
    //ToString用的是直接修改内存的方法，不会产生装箱。不保证底层不会产生装箱，但是尽量避免装箱就行。
    private string str2 = "abc" + 9.ToString(）;
    
    //装箱的步骤
    //1. 在托管堆中分配内存，也可能引起GC
    //2. 将值类型复制到堆中
    //3. 返回成为引用类型对象的地址
    
    //String是一个不变的引用对象，使用+或=都会产生新的对象
    //所以尽量使用String.Format（底层使用了String.Builder）
    
    
  }
}