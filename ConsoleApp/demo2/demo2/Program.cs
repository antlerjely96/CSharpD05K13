// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

/* Nhập mảng số nguyên có n phần tử. Tính tổng các phần tử */

//Khai báo n
int n, tong = 0;
//Nhập n
Console.Write("n = ");
n = int.Parse(Console.ReadLine());
//Khai báo mảng
int[] arr = new int[n];
//Nhập mảng
for (int i = 0; i < n; i++)
{
    Console.Write("arr[" + i + "] = ");
    arr[i] = int.Parse(Console.ReadLine());
}
//Tính tổng các phần tử
for (int i = 0; i < n; i++)
{
    tong += arr[i];
}
//In ra tổng
Console.WriteLine("Tong cac phan tu cua mang: " + tong);