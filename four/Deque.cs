using System.Collections;
using System.Collections.Generic;

namespace four
{
    public interface Deque<T> : IEnumerable<T>
    {
        /// <summary>
        /// Добавление элемента в голову
        /// </summary>
        /// <param name="data"></param>
        void AddFirst(T data);
        
        /// <summary>
        /// Добавление элемента в хвост
        /// </summary>
        /// <param name="data"></param>
        void AddLast(T data);

        /// <summary>
        /// Удаление первого элемента
        /// </summary>
        /// <param name="data"></param>
        T DeleteFirst();
        
        /// <summary>
        /// Удаление последнего элемента
        /// </summary>
        /// <param name="data"></param>
        T DeleteLast();

        /// <summary>
        /// Первый элемент
        /// </summary>
        T First { get; }
        
        /// <summary>
        /// Последний элемент
        /// </summary>
        T Last { get; }
        
        /// <summary>
        /// Общее количество элементов
        /// </summary>
        int Count { get; }
        
        /// <summary>
        /// Пустой ли 
        /// </summary>
        bool IsEmpty { get; }
        
        void Clear();
        
        bool Contains(T data);

        /// <summary>
        /// Добавить в очередь
        /// </summary>
        /// <param name="data"></param>
        void Enqueue(T data);
        
        /// <summary>
        /// Убрать из очереди. Толкнуть очередь
        /// </summary>
        /// <returns></returns>
        T Dequeue();
    }
}