using Ex28_template;
using System;

namespace Inheritance
{

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("222e014", DateTime.Today, "山下", 50, 165, 25, 50);
            Console.WriteLine($"名前{student.Name} ID{student.ID} 体重{student.Weight}kg");
            Worker worker = new Worker("サラリーマン", DateTime.Today, "田中", 50, 180, 20, 60);
            Console.WriteLine($"名前{worker.Name} 職業{worker.Occupation} 体重{worker.Weight}kg");
            Fish fish = new Fish("大味", DateTime.Today, "ナポレオンフィッシュ", 30, 30, 200, 180);
            Console.WriteLine($"名前{fish.Name} 味{fish.Taste} 重さ{fish.Weight}kg");
            Refrigerator refrigerator = new Refrigerator(18, "プラズマクラスター", 65, 183, 70, 114);
            Console.WriteLine($"名前{refrigerator.Name} 値段{refrigerator.Prince}万円 重さ{refrigerator.Weight}");
            Insect insect = new Insect("夏", DateTime.Today, "カブトムシ", 5, 10, 5, 0.1f);
            Console.WriteLine($"名前{insect.Name} 季節{insect.Season}");
            Cat cat = new Cat("マンチカン", DateTime.Today, "neko", 30, 40, 70, 15);
            Console.WriteLine($"名前{cat.Name} 種類{cat.catBreed} 重さ{cat.Weight}kg");
            Car car = new Car(200, "インプレッサ22b", 177, 139, 436, 1270);
            Console.WriteLine($"名前{car.Name} 最高速{car.Speed} 重さ{car.Weight}kg");
            Pc pc = new Pc("東芝", "dynabook", 40, 5, 25, 5);
            Console.WriteLine($"名前{pc.Name} メーカー{pc.production} 重さ{pc.Weight}kg");
        }
    }
}
