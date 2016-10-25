using System.Collections.Generic;

namespace TaskFour
{
    public class Table<T>
    {
        private readonly List<List<T>> _talbe;

        public Table()
        {
            _talbe = new List<List<T>>();
        }

        public T this[int x, int y]
        {
            get { return _talbe[x][y]; }
            set { _talbe[x][y] = value; }
        }

        public void InsertEmptyRow(int rowIndex)
        {
            
        }

        public void InsertEmptyColumn(int columnIndex)
        {
            
        }
    }
}