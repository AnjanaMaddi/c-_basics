// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
public interface OS {
    public void spec();
}
public class Android : OS {
    public void spec() {
        Console.WriteLine("Most powerfull OS");
    }
}
public class IOS: OS {
    public void spec() {
        Console.WriteLine("I am the best");
    }
}
public class Windows : OS {
    public void spec() {
        Console.WriteLine("I am about to die");
    }
}
public class OperatingSystemFactory {
    OS andriodObj;
    OS iosObj;
    OS windowsObj;
    public OperatingSystemFactory(){
        andriodObj = new Android();
        iosObj = new IOS();
        windowsObj = new Windows();
    }
    public OS getInstance(int i=0){
        switch(i){
            case 0: return andriodObj;
            case 1: return iosObj;
            case 2: return windowsObj;
            default: return andriodObj;
        }
    }
}
public class HelloWorld
{
    public static void Main(string[] args)
    {
        OperatingSystemFactory osf = new OperatingSystemFactory();
        OS obj = osf.getInstance(2);
        obj.spec();
    }
}
