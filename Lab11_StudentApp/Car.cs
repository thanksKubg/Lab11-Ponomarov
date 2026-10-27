namespace Lab11_StudentApp
{
    public class Car
    {
        public string Model { get; set; }

        // Композиція: двигун створюється всередині конструктора Car.
        public Engine CarEngine { get; set; }

        // Агрегація: водій створюється окремо; "Driver?" означає "може бути null".
        public Driver? CarDriver { get; set; }

        // Масив об'єктів: колеса створюються всередині конструктора Car.
        public Wheel[] Wheels { get; set; }

        // Примітка: сеттери публічні навмисно. У Завданнях 5 і 6 ми "ламаємо" авто
        // (прибираємо двигун чи колесо), щоб перевірити метод IsReadyToDrive().
        // Конструктора без параметрів немає: автомобіль не існує без двигуна й коліс.

        public Car(string model)
        {
            // TODO: Завдання 2.
            // 1. Збережіть назву моделі у властивість Model.
            // 2. Створіть для цього авто власний двигун і збережіть його у CarEngine.
            //    (Значення оберіть самі, вимоги до них: у тексті завдання.)
            Model = model;
            CarEngine = new Engine(150, "Бензин");

            // TODO: Завдання 4.
            // 1. Створіть масив Wheels на 4 елементи.
            // 2. Заповніть його: кожна комірка має містити власний, окремо створений об'єкт Wheel.
            Wheels = new Wheel[4];
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel(16);
            }
        }

        // TODO: Завдання 3.
        // Водій виходить з авто. Метод повертає водія, який щойно вийшов
        // (або null, якщо водія не було). Після виклику в авто водія немає,
        // а сам об'єкт водія нікуди не зникає.
        public Driver? RemoveDriver()
        {
            Driver? d = CarDriver;
            CarDriver = null;
            return d;
        }

        // TODO: Завдання 5.
        // Поверніть true, лише якщо автомобіль повністю укомплектований
        // (умови дивіться в тексті завдання). Інакше поверніть false.
        public bool IsReadyToDrive()
        {
            if (CarEngine == null)
            {
                return false;
            }
            if (Wheels == null)
            {
                return false;
            }
            if (Wheels.Length != 4)
            {
                return false;
            }
            for (int i = 0; i < Wheels.Length; i++)
            {
                if (Wheels[i] == null)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
