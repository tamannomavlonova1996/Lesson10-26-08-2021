using System;
using System.Data;

namespace lesson10
{
    class Program
    {
        static void Main(string[] args)
        {
            var transport = new Transport(10, 3, "black");
            transport.WriteInfo();
            var auto = new Auto(1, 4, 2021, 280, "white");
            auto.WriteInfo();
            var samolyot = new Samolyot(2, 4, 8, 1960, 500, "seriy");
            samolyot.WriteInfo();
            var poezd = new Poezd(15, 1900, 500, "zeleniy");
            var legkovoy = new LegkovoyAuto(false, 1, 4, 2021, 280, "white");
            legkovoy.WriteInfo();
            var gruzovoy = new GruzovoyAuto(true, 1, 4, 2021, 280, "white");
            gruzovoy.WriteInfo();
            var gruzovoySam = new GruzovoySamolyot(false, false, 2, 2, 8, 1960, 500, "seriy");
            gruzovoySam.WriteInfo();
            var legkovoySam = new LegkovoySamolyot(true, true, 2, 2, 8, 1960, 500, "seriy");
            legkovoySam.WriteInfo();
        }
    }

    class Transport
    {
        private int _age;


        public int Age
        {
            get { return _age; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Неправильный возраст");
                }
                else
                {
                    _age = value;
                }
            }
        }

        private int _obyomDvigatelya;

        public int ObyomDvigatelya
        {
            get { return _obyomDvigatelya; }
            set
            {
                if (value <= 0)
                    throw new Exception("Неправильный Объем");

                else
                {
                    _obyomDvigatelya = value;
                }
            }
        }


        public string Svet { get; set; }

        public Transport(int age, int obyomDvigatelya, string svet)
        {
            Age = age;
            ObyomDvigatelya = obyomDvigatelya;
            Svet = svet;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Транспорт : Возраст {Age}, Объем двигателя {ObyomDvigatelya}, Цвет {Svet}");
        }
    }

    class Auto : Transport
    {
        public int Rul { get; set; }
        public int Sidenya { get; set; }

        public Auto(int rul, int sidenya, int age, int obyomDvigatelya, string svet) : base(age, obyomDvigatelya, svet)
        {
            Rul = rul;
            Sidenya = sidenya;
        }

        public void WriteInfo()
        {
            Console.WriteLine(
                $"Авто : Возраст  {Age}, Объем двигателя {ObyomDvigatelya}, Цвет {Svet}, Руль {Rul}, Сиденья {Sidenya}");
        }
    }

    class Samolyot : Transport
    {
        public int Krilya { get; set; }
        public int _rule;

        public int Rule
        {
            get
            {
                return _rule;
            }
            set
            {
                if (value >2)
                {
                    Console.WriteLine("Руль для транспорта не может быть больше 2");
                }
                else
                {
                    value = _rule;
                }
            }
        }
        public int Balon { get; set; }

        public Samolyot(int krilya, int rule, int balon, int age, int obyomDvigatelya, string svet) : base(age,
            obyomDvigatelya, svet)
        {
            Krilya = krilya;
            Rule = rule;
            Balon = balon;
        }

        public void WriteInfo()
        {
            Console.WriteLine(
                $"Самолёт : Возраст {Age}, Объем двигателя {ObyomDvigatelya}, Цвет  {Svet}, Крылья {Krilya}, Руль {Rule}, Балон {Balon}");
        }
    }

    class Poezd : Transport
    {
        public int Vagon { get; set; }

        public Poezd(int vagon, int age, int obyomDvigatelya, string svet) : base(age,
            obyomDvigatelya, svet)
        {
            Vagon = vagon;
        }

        public void WriteInfo()
        {
            Console.WriteLine($"Поезд : Возраст {Age}, Объем двигателя {ObyomDvigatelya}, Цвет {Svet}, Вагон {Vagon}");
        }
    }

    class LegkovoyAuto : Auto
    {
        public bool Kuzov { get; set; }

        public LegkovoyAuto(bool kuzov, int rul, int sidenya, int age, int obyomDvigatelya, string svet) : base(rul,
            sidenya, age, obyomDvigatelya, svet)
        {
            Kuzov = kuzov;
        }

        public void WriteInfo()
        {
            Console.WriteLine(
                $"Легковой Авто : Кузов :{Kuzov}, Возраст :{Age},  Объем двигателя:{ObyomDvigatelya}, Цвет:{Svet}, " +
                $"Руль {Rul}, Сиденья {Sidenya} ");
        }
    }

    class GruzovoyAuto : Auto
    {
        public bool Kuzov { get; set; }

        public GruzovoyAuto(bool kuzov, int rul, int sidenya, int age, int obyomDvigatelya, string svet) : base(rul,
            sidenya, age, obyomDvigatelya, svet)
        {
            Kuzov = kuzov;
        }

        public void WriteInfo()
        {
            Console.WriteLine(
                $"Грузовой Авто : Кузов :{Kuzov}, Возраст :{Age},  Объем двигателя:{ObyomDvigatelya}, Цвет:{Svet}, " +
                $"Руль {Rul}, Сиденья {Sidenya} ");
        }
    }

    class GruzovoySamolyot : Samolyot
    {
        public bool Sidenya { get; set; }
        public bool Okno { get; set; }

        public GruzovoySamolyot(bool sidenya, bool okno, int krilya, int rule, int balon, int age, int obyomDvigatelya,
            string svet) : base(krilya, rule, balon, age,
            obyomDvigatelya, svet)
        {
            Sidenya = sidenya;
            Okno = okno;
        }

        public void WriteInfo()
        {
            Console.WriteLine(
                $"Грузовой Самолет Возраст:{Age}, Объем двигаетля:{ObyomDvigatelya}, Цвет:{Svet}, Крылья:{Krilya}, Руль:{Rule}, Балон : {Balon},Сиденья {Sidenya}, Окна: {Okno}");
        }
    }

    class LegkovoySamolyot : Samolyot
    {
        public bool Sidenya { get; set; }
        public bool Okno { get; set; }

        public LegkovoySamolyot(bool sidenya, bool okno, int krilya, int rule, int balon, int age, int obyomDvigatelya,
            string svet) : base(krilya, rule, balon, age,
            obyomDvigatelya, svet)
        {
            Sidenya = sidenya;
            Okno = okno;
        }

        public void WriteInfo()
        {
            Console.WriteLine(
                $"Легковой Самолет: Возраст:{Age}, Объем двигаетля:{ObyomDvigatelya}, Цвет:{Svet}, Крылья:{Krilya}, Руль:{Rule}, Балон : {Balon},Сиденья {Sidenya}, Окна: {Okno}");
        }
    }
}