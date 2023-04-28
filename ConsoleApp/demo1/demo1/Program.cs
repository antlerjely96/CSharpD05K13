// See https://aka.ms/new-console-template for more information

//Nhập số nguyên a. Kiểm tra a là số âm hay số dương

//Khai báo a
int a;
//Nhập a
a = int.Parse(Console.ReadLine());
//Kiểm tra a
if (a > 0)
{
    Console.WriteLine(a + " la so duong");
}
else if (a < 0)
{
    Console.WriteLine(a + " la so am");
}
else
{
    Console.WriteLine(a + " la so khong am khong duong");
}