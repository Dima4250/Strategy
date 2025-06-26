using System;

// Интерфейс стратегии Strategy
public interface ISortStrategy
{
    void Sort(int[] dataset);
}

// Конкретные реализации ConcreteStrategy для сортировок
public class BubbleSort : ISortStrategy
{
    public void Sort(int[] dataset)
    {
        Console.WriteLine("Сортировка пузырьком");
    }
}

public class QuickSort : ISortStrategy
{
    public void Sort(int[] dataset)
    {
        Console.WriteLine("Быстрая сортировка");
    }
}

// Класс, использующий стратегию Context
public class Sorter
{
    private ISortStrategy _strategy; // Экхемпляр strategy класса стретигий

    public Sorter(ISortStrategy strategy) // конструктор который принимает одну из
    {
        _strategy = strategy;
    }

    public void SetStrategy(ISortStrategy strategy) // Метод для изменения стратегии во время выполнения
    {
        _strategy = strategy;
    }

    public void ExecuteSort(int[] data) // // Метод для выполнения сортировки с текущей стратегией
    {
        _strategy.Sort(data);
    }
}

class Program
{
    static void Main()
    {
        var dataset = new int[] { 5, 2, 4, 1, 3 };

        var sorter = new Sorter(new BubbleSort()); // создал пузырек
        sorter.ExecuteSort(dataset); // выполнил сортировку

        sorter.SetStrategy(new QuickSort()); // поменял сортировку на быструю
        sorter.ExecuteSort(dataset); // выполнил измененную сортировку
    }
}