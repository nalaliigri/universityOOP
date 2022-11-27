/* Завдання 1.
   В даному коді використаний антипатерн Божественний об'єкт(God object) та порушено принцип єдиного обов’язку (The Single Responsibility Principle).
   Цей принцип говорить про те, що кожен клас повинен вирішувати лише одну задачу.
   Ось як можна це виправити: 
*/
 class Item
{

}
class Order
{
    private List<Item> itemList;
    internal List<Item> ItemList
    {
        get
        {
            return itemList;
        }
        set
        {
            itemList = value;
        }
 }
    public void CalculateTotalSum() {/*...*/}
    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void Update() {/*...*/}
 }

class OrderRepository
{
    public void Load() {/*...*/}
    public void Save() {/*...*/} 
}

class OrderDelete
{
    public void Delete() {/*...*/}
    public void DeleteItem(Item item) {/*...*/}
}
class PrintManager
{
    public void PrintOrder() {/*...*/}
    public void ShowOrder() {/*...*/}
}
 
 

 /* Завдання 2.
    В даному коді також порушено принцип єдиного обов’язку (The Single Responsibility Principle).
    Виправимо це:)
 */
 
 class Email
 {
    public String Theme { get; set; }
    public String From { get; set; }
    public String To { get; set; }
 }
 class EmailSendTo
 {
    public void SendTo(Email email)
    {
      // ... sending...
      Console.WriteLine(email.To);
    }
 }
 
 class EmailSendFrom
 {
    public void SendFrom(Email email)
    {
      // ... sending...
      Console.WriteLine(email.From);
    }
 }

class EmailSendTheme
 {
    public void SendTheme(Email email)
    {
      // ... sending...
      Console.WriteLine(email.Theme);
    }
 }
 class Program
 {
    static void Main(string[] args)
    {
       Email e1 = new Email() { From = "Nata", To = "Ludmula",Theme = "You are wonderful!" };
       Email e2 = new Email() { From = "Vasya", To = "Me",Theme = "vacuum cleaners!" };
       Email e3 = new Email() { From = "Kolya", To ="Vasya", Theme = "No! Thanks!" };
       Email e4 = new Email() { From = "Vasya", To = "Me",Theme = "washing machines!" };
       Email e5 = new Email() { From = "Me", To = "Vasya",Theme = "Yes" };
       Email e6 = new Email() { From = "Vasya", To ="Petya", Theme = "+2" };
       
       EmailSendTo to = new EmailSendTo();
       EmailSendFrom from = new EmailSendFrom();
       EmailSendTheme theme = new EmailSendTheme();
       to.SendTo(e1);
       from.SendFrom(e1);
       theme.SendTheme(e1);
       Console.ReadKey();
   }
 }
 
 
 
 /* Завдання 3.
    Тут порушено принцип підстановки Лісков (The Liskov Substitution Principle).
    Ось варіант вирішення цієї проблеми.
    Відповідь 50? :)
 */
using System;
class Program
{
   static void Main(string[] args)
   {
     Shape rect = new Rectangle{Width = 5,Height = 10};
     Console.WriteLine(rect.GetArea());
     Console.ReadKey();
   }
}
 
public abstract class Shape
{
    public abstract int GetArea();
}
 
public class Rectangle:Shape
{
    public int Width { get; set; }
    public int Height { get; set; }
    public override int GetArea()
    {
     return Width * Height;
    }
}
 
 
public class Square:Shape
{
   public int Length { get; set; }
   public override int GetArea()
    {
     return Length*Length;
    }
}



// Завдання 4.
using System;

class Program{
   static void Main(String[] args){
        Book book = new Book();  
        Console.WriteLine("The book \"Clean code\"");
        book.ApplyDiscount("50%");
        book.SetPrice(35);
        Overdress jacket = new Overdress();
        Console.WriteLine();
        Console.WriteLine("Versace Jacket");
        jacket.SetColor(16);
        jacket.SetSize(36);
        jacket.ApplyDiscount("10%");
        jacket.SetPrice(1500);
   }
}

public class Book: IPrice, IDiscount
{  
    public void ApplyDiscount(string discount)  
    {  
        Console.WriteLine($"Discount is {discount}");  
    } 
    public void SetPrice(double price)
    {  
        Console.WriteLine($"Price is {price}$");  
    } 
}  


public class Overdress: IColor, ISize, IPrice, IDiscount
{
    public void SetSize(byte size)  
    {  
        Console.WriteLine($"Size - {size}");  
    } 
    public void SetColor(byte color)
    {  
        Console.WriteLine($"Color - {color}");  
    } 
    public void ApplyDiscount(string discount)  
    {  
        Console.WriteLine($"Discount - {discount}");  
    } 
    public void SetPrice(double price)
    {  
        Console.WriteLine($"Price - {price}$");  
    } 
}
interface IPromocode
{
    void ApplyPromocode(string promocode);
}
interface IDiscount
{
    void ApplyDiscount(string discount);
}
interface IColor
{
    void SetColor(byte color);
}
interface ISize
{
    void SetSize(byte size);
}
interface IPrice
{
    void SetPrice(double price);
}

 
