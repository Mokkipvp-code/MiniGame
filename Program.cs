namespace MiniGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int delayInMilliseconds = 10;
            string приветсвие = "Ты проснулся в команте и пытаешься вспомнить как тебя зовут, твоё имя --> ";

            foreach (char character in приветсвие)
            {
                Console.Write(character);
                Thread.Sleep(delayInMilliseconds);
            }

            string игрок = Console.ReadLine(); Console.WriteLine("");

            string обзор = "Ты осматриваешься и видишь вокруг себя следующие возможности:";

            int артефакты = 0;
            int отмычка = 0;
            int ключ = 0;
            int конец = 0;
            int вентиляция = 0;
            int событие_кровать = 0;
            int событие_тумочка = 0;
            int событие_статуя = 0;

            foreach (char character in обзор)
            {
                Console.Write(character);
                Thread.Sleep(delayInMilliseconds);
            }
            Console.WriteLine();
            Console.WriteLine();

            while (конец == 0)
            {
                string[] message = { "1 Открыть дверь", "2 Заглянуть под кровать", "3 Открыть ящик в углу комнаты", "4 Открыть вентиляцию", "5 Взглянуть на тумбочку", "6 Взглянуть на статую рядом с дверью" };

                foreach (string stroke in message)
                {
                    foreach (char character in stroke)
                    {
                        Console.Write(character);
                        Thread.Sleep(delayInMilliseconds);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                string предложение_игры1 = "Что ты хочешь сделать? введи пожалуйста цифру --> ";
                string количество_артефактов = $"Твоё количество артефактов --> {артефакты}";

                foreach (char character in количество_артефактов)
                {
                    Console.Write(character);
                    Thread.Sleep(delayInMilliseconds);
                }
                Console.WriteLine();

                foreach (char character in предложение_игры1)
                {
                    Console.Write(character);
                    Thread.Sleep(delayInMilliseconds);
                }
                int выбор_игрока1 = int.Parse(Console.ReadLine()); Console.WriteLine("");

                switch (выбор_игрока1)
                {
                    case 1:
                        if (отмычка == 0)
                        {
                            Console.WriteLine("Для того чтобы открыть дверь, вам нужна отмычка, найди её :) P.s Попробуй посомтреть в ящике");
                            Console.WriteLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Поздавляю ты сбежал! Игра кокончена");
                            Console.WriteLine();
                            конец += 1;
                            break;
                        }

                    case 2:
                        if (событие_кровать == 0)
                        {
                            Console.WriteLine($"{игрок}, вы нашли артефакт!");
                            артефакты += 1;
                            событие_кровать += 1;
                            Console.WriteLine();
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Здесь больше ничего нет");
                            break;
                        }

                    case 3:

                        if (ключ == 0)
                        {
                            Console.WriteLine("Чтобы открыть ящик вам нужен ключ, осмотрите статую");
                            Console.WriteLine();
                            break;
                        }

                        if (ключ == 1)
                        {
                            Console.WriteLine($"{игрок}, вы нашли отмычку!");
                            Console.WriteLine();
                            отмычка += 1;
                            ключ += 1;
                            break;
                        }

                        else 
                        {
                            Console.WriteLine("Вы уже открыли ящик, найдите применение отмычки");
                            break;
                        }
                    case 4:
                        if (вентиляция == 0)
                        {
                            Console.WriteLine("Вы тяните крышку вентиляции, но она не поддаётся с первого раза");
                            Console.WriteLine();
                            вентиляция += 1;
                            break;
                        }

                        if (вентиляция == 1)
                        {
                            Console.WriteLine("Вы тяните крышку вентиляции, она поддаётся, но только наполовину и вы видите артефакт");
                            Console.WriteLine();
                            вентиляция += 1;
                            break;
                        }
                        if (вентиляция == 2)
                        {
                            Console.WriteLine("На третий раз вы смогли полностью снять крышку вентиляции и подбираете артефакт");
                            Console.WriteLine();
                            вентиляция += 1;
                            артефакты += 1;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Здесь больше ничего нет");
                            break;
                        }

                    case 5:
                        if (событие_тумочка == 0)
                        {
                            Console.WriteLine("Вы осматриваете тумбочку и находите там артефакт");
                            артефакты += 1;
                            событие_тумочка += 1;
                            break;
                        }

                        else
                        {
                            Console.WriteLine("Здесь больше ничего нет");
                            break;
                        }

                    case 6:
                        {
                            if (событие_статуя == 0) 
                            {
                                if (артефакты != 3)
                                {
                                    Console.WriteLine("Вы осматриваете статую рядом с дверью и видите 3 углубления под артефакты");
                                    Console.WriteLine();
                                    break;
                                }

                                if (артефакты == 3)
                                {
                                    Console.WriteLine("Вы вставляете 3 артефакта в углубления, статуя поварачивается и вы получаете ключ");
                                    Console.WriteLine();
                                    ключ += 1;
                                    событие_статуя += 1;
                                    break;
                                }
                                break;
                            }

                            else
                            {
                                Console.WriteLine("Здесь больше ничего нет");
                                break;
                            }
                        }
                }
            }
        }
    }
}
