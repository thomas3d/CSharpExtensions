

public class MyLinqExtensions
{

 public static bool In<T>(this T o, params T[] values) 
 {
    return values.Contains(o);
 }


}