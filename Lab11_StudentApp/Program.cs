namespace Lab11_StudentApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Лабораторна робота №11 (Композиція та Агрегація) ---\n");

            // TODO: Завдання 6. Локальна перевірка у Main

            // Крок 1. Створіть автомобіль (конструктор з назвою моделі) і виведіть модель.
            Car car = new Car("Toyota Camry");
            Console.WriteLine("Модель: " + car.Model);

            // Крок 2. Виведіть потужність двигуна та результат IsReadyToDrive().
            Console.WriteLine("Потужність двигуна: " + car.CarEngine.Power + " к.с.");
            Console.WriteLine("Готове до поїздки: " + car.IsReadyToDrive());

            // Крок 3. Водія ще не призначено: напишіть if / else, що виведе
            //         або ім'я водія, або повідомлення "Водія немає".
            if (car.CarDriver != null)
            {
                Console.WriteLine("Водій: " + car.CarDriver.Name);
            }
            else
            {
                Console.WriteLine("Водія немає");
            }

            // Крок 4. Створіть водія (окремий об'єкт), призначте його у CarDriver
            //         і повторіть перевірку з Кроку 3 (тепер має спрацювати гілка з водієм).
            Driver driver = new Driver("Олег", 5);
            car.CarDriver = driver;
            if (car.CarDriver != null)
            {
                Console.WriteLine("Водій: " + car.CarDriver.Name);
            }
            else
            {
                Console.WriteLine("Водія немає");
            }

            // Крок 5. Водій виходить з авто: викличте RemoveDriver() і збережіть результат.
            //         Виведіть ім'я водія, який вийшов (об'єкт водія існує!), і що авто знову без водія.
            Driver? left = car.RemoveDriver();
            if (left != null)
            {
                Console.WriteLine("З авто вийшов водій: " + left.Name);
            }
            if (car.CarDriver == null)
            {
                Console.WriteLine("Авто знову без водія");
            }

            // Крок 6. Передбачте й спостерігайте (див. методичку, Завдання 6):
            //   а) створіть масив Wheel[] і одразу виведіть Radius його першого елемента (без try / catch);
            //      запишіть прогноз, запустіть, зафіксуйте виняток;
            //   б) потім обгорніть цей код у try / catch (NullReferenceException) і виведіть
            //      ex.GetType().Name, щоб Main завершувався без помилок.
            try
            {
                Wheel[] wheels = new Wheel[4];
                Console.WriteLine("Радіус першого колеса: " + wheels[0].Radius);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Виняток: " + ex.GetType().Name);
            }


            Console.WriteLine("\nЯкщо все працює без помилок — завантажуйте файли на GitHub!");
            Console.ReadLine();
        }
    }
}
