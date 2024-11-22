using System;
using System.Dynamic;

//задание 1
// namespace practica
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             Func<string, string, bool> Words = (text, word) => text.Contains(word);
//             string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla nec aliquam dui, ac porta magna. Cras mattis pretium condimentum. Morbi lacinia nec enim vel porttitor. Maecenas purus lacus, hendrerit eu ultricies id, malesuada et massa. Cras luctus malesuada elit vitae sodales. ";
//             string word = "Lorem";
//             Console.WriteLine($"Текст: \"{text}\"");
//             Console.WriteLine($"Содержит слово \"{word}\"? {Words(text, word)}");
//         }
//     }
//  
// }







//задание 2
// class Backpack
// {
//     public string Color { get; set; }
//     public string Firma { get; set; }
//     public string Material { get; set; }
//     public double Weight { get; set; }
//     public double Capacity { get; set; } 
//     public double Volume { get; set; } = 0; 
//     public List<(string Name, double Value)> Items { get; set; } = new List<(string Name, double Value)>(); 
//     public event EventHandler<string> OnChange;
//     public void Add(string name, double value)
//     {
//         if (Volume + value > Capacity)
//         {
//             throw new InvalidOperationException($"Рюкзак заполнен, вещь '{name}' не может быть добавлена");
//         }
//         Items.Add((name, value));
//         Volume += value;
//         OnChange?.Invoke(this, name);
//     }
// }
//
// class Program
// {
//     static void Main(string[] args)
//     {
//         var backpack = new Backpack
//         {
//             Color = "Черный",
//             Firma = "Staff",
//             Material = "Нейлон",
//             Weight = 0.8,
//             Capacity = 20
//         };
//         backpack.OnChange += (backpackObject, predmet) =>
//         {
//             Console.WriteLine($"{predmet} добавлен в рюкзак");
//         };
//         try
//         {
//             backpack.Add("Книжка", 2);
//             backpack.Add("Ноутбук", 5);
//             backpack.Add("Вода", 3);
//             backpack.Add("Тетради", 4);
//             backpack.Add("Книжка", 4);
//             backpack.Add("Пенал", 2);
//             backpack.Add("Термос", 13);
//
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine($"Ошибка: {ex.Message}");
//         }
//
//     }
// }











//задание 3
// namespace practica
// {
//     internal class Program
//     {
//         static void Main(string[] args)
//         {
//             int[] arr = { -1,-2,-3,-4,1,2,3,4 };
//             int bolshe0 = Count(arr, x => x > 0);
//             Console.WriteLine("больше 0: " + bolshe0);
//         }
//         private static int Count(int[] numbers, Predicate<int> func)
//         {
//             int count = 0;
//             foreach (int i in numbers)
//             {
//                 if (func(i))
//                     count++;
//             }
//             return count;
//         }
//     }
// }