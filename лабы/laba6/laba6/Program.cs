namespace laba6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Candy candy1 = new Candy(7, 543, "Maximus", "Victorius");
            Cake cake = new Cake(15, 2000, "Комунарка", "Медовик");
            Candy candy2 = new Candy(10, 321, "Maximus", "Genesis");


            Pastry[] products = { candy1, cake, candy2 };

            Gift gift = new Gift();

            foreach (var i in products)
            {
                gift.addPastry(i);
            }

            checked
            {
                try
                {
                    int test = 0;
                    Logger logger = new Logger();
                    logger.FileLoggerWriteLine("Log-файл успешно создан");
                    try
                    {
                        Gift test1 = new Gift();


                        Cake cake2 = new Cake(15, 2000, "Комунарка", "Медовик");

                        for (int i = 0; i < 10; i++)
                        {
                            test1.addPastry(cake2);
                        }

                        throw new NullCollectionException("Пустая коллекция");

                        //test1.removePastry(-1);

                        //products[10].ToString();

                        //int value = 780000000;
                        //int square = value * value;
                        //Console.WriteLine("{0} ^ 2 = {1}", value, square);

                        //int test2 = 0;
                        //test2 /= 0;
                        //Debug.Assert(test <= 1 && test >= 0, "Значение testpr может быть только 0 или 1");
                    }
                    catch (DivideByZeroException exception) when (test != 1)
                    {
                        logger.FileLoggerWriteError("Error NullReferenceException", exception.Message, exception.StackTrace);
                        logger.ConsoleLoggerError("Error NullReferenceException", exception.Message, exception.StackTrace);
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Попытка поднлить на ноль");
                    }
                    catch (NullCollectionException exception)
                    {
                        Console.WriteLine($"Произошла ошибка: {exception.Message}");
                    }
                    catch (OverflowException exception) when (test != 1)
                    {
                        logger.FileLoggerWriteError("Error Class MaxCollection", exception.Message, exception.StackTrace);
                        logger.ConsoleLoggerError("Error class MaxCollections", exception.Message, exception.StackTrace);
                    }
                    catch (OverflowException exception)
                    {
                        Console.WriteLine($"Произошла ошибка: {exception.Message}");
                    }
                    catch (DeleteNullObject exception)
                    {
                        Console.WriteLine($"Произошла ошибка: {exception.Message}");
                    }
                    catch
                    {
                        Console.WriteLine("Поиск возможной причины исключения");
                        throw;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Попытка обращения к несуществующему элементу");
                }
                catch
                {
                    Console.WriteLine("Исключение необработано");
                }
                finally
                {
                    Console.WriteLine("Тест закончился");
                }
            }
        }
    }
}