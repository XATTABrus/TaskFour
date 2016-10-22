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

        /// <summary>
        /// Помещает значение в соответствующую ячейку
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <param name="value"></param>
        void Put(int row, int column, int value)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Добавляет пустую строку по указанному индексу
        /// </summary>
        /// <param name="rowIndex"></param>
        void InsertRow(int rowIndex)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Добавляет пустой столбец по указанному индексу
        /// </summary>
        /// <param name="columnIndex"></param>
        void InsertColumn(int columnIndex)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Возвращает хранимое в таблице значение
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        object Get(int row, int column)
        {
            throw new System.NotImplementedException();
        }
    }
}