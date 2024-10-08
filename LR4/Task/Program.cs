using System;
using System.Collections.Generic;

class Program {
   struct Import {
      public string n; // назва товару
      public string c; // країна імпортер
      public int q; // кількість товару

      public string D() {
         return $"Товар: {n}, Країна: {c}, Кількість: {q}";  // форматированный вывод полей структуры
      }
   }

   static void Main(string[] args) {
      List<Import> x = new List<Import>();  // список для хранения данных о товарах
      Import z;

      Console.WriteLine("Введіть кількість записів:");  // запрос количества записей
      int k = Convert.ToInt32(Console.ReadLine());

      // введення даних з клавіатури
      for (int i = 0; i < k; i++) {
         Console.WriteLine($"Введіть дані для товару {i + 1}:");  // запрос данных для каждого товара
         Console.Write("Назва товару: ");
         z.n = Console.ReadLine();  // ввод названия товара
         Console.Write("Країна імпортер: ");
         z.c = Console.ReadLine();  // ввод страны импортера
         Console.Write("Кількість товару: ");
         z.q = Convert.ToInt32(Console.ReadLine());  // ввод количества товара

         x.Add(z);  // добавление товара в список
      }

      // виведення списку товарів
      Console.WriteLine("\nСписок імпортованих товарів:");
      foreach (var y in x) {
         Console.WriteLine(y.D());  // вывод каждого товара через метод D
      }

      // пошук загального обсягу імпорту за товаром
      Console.Write("\nВведіть назву товару для пошуку загального обсягу: ");
      string a = Console.ReadLine();  // ввод товара для поиска
      int b = 0;  // переменная для хранения общего объема товара

      foreach (var y in x) {
         if (y.n == a) {  // проверка, совпадает ли название товара
            b += y.q;  // добавляем количество товара к общему объему
         }
      }

      Console.WriteLine($"Загальний обсяг імпорту для товару {a}: {b}");  // вывод общего объема

      // пошук загального обсягу імпорту за країною
      Console.Write("\nВведіть назву країни для пошуку загального обсягу: ");
      string r = Console.ReadLine();  // ввод страны для поиска
      int t = 0;  // переменная для хранения общего объема по стране

      foreach (var y in x) {
         if (y.c == r) {  // проверка, совпадает ли страна
            t += y.q;  // добавляем количество товара к общему объему по стране
         }
      }

      Console.WriteLine($"Загальний обсяг імпорту для країни {r}: {t}");  // вывод общего объема по стране

      Console.ReadKey();  // ожидание нажатия клавиши для завершения программы
   }
}