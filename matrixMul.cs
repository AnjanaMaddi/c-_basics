// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Matrix multiplication square 
        Console.WriteLine("enter the dimensions");
        int n = Convert.ToInt32(Console.ReadLine());
        int [,] A = new int[n,n];
        int [,] B = new int[n,n];
        int [,] res = new int[n,n];
        Console.WriteLine("enter values of A");
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                Console.Write("\nenter values of A[{0}][{1}]: ",i,j);
                A[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.WriteLine("enter values of B");
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                Console.Write("\nenter values of B[{0}][{1}]: ",i,j);
                B[i,j] = Convert.ToInt32(Console.ReadLine());
            }
        }
         for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                int sum = 0;
                for(int k=0;k<n;k++){
                    sum = sum + A[i,k]*B[k,j];
                }
                res[i,j] = sum;
            }
        }
        for(int i=0;i<n;i++){
            for(int j=0;j<n;j++){
                Console.Write(res[i,j] + " ");
            }
            Console.WriteLine("");
        }
    }
}
