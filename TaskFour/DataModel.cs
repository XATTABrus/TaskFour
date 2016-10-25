using System.Collections.Generic;

namespace TaskFour
{
    public class DataModel : IObservable
    {
        #region Realization IObservable

        readonly List<IObserver> _observers;

        public DataModel(List<IObserver> observers)
        {
            _observers = observers;
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        #endregion

        private readonly Table<int> _table;

        public DataModel()
        {
            _table = new Table<int>(2, 2);
        }

        /// <summary>
        /// Помещает значение в соответствующую ячейку
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        public void Put(int row, int column, int value)
        {
            _table[row, column] = value;

            NotifyObserver();
        }

        /// <summary>
        /// Добавляет пустую строку по указанному индексу
        /// </summary>
        /// <param name="rowIndex"></param>
        public void InsertRow(int rowIndex)
        {
            _table.InsertEmptyRow(rowIndex);

            NotifyObserver();
        }

        /// <summary>
        /// Добавляет пустой столбец по указанному индексу
        /// </summary>
        /// <param name="columnIndex"></param>
        public void InsertColumn(int columnIndex)
        {
            _table.InsertEmptyColumn(columnIndex);

            NotifyObserver();
        }

        /// <summary>
        /// Возвращает хранимое в таблице значение
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        public int Get(int row, int column)
        {
            return _table[row, column];
        }
    }
}