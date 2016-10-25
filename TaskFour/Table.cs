using System;

namespace TaskFour
{
    public class Table<T>
    {
        private T[,] _table;

        public Table(int amountRow, int amountColumn)
        {
            _table = new T[amountRow, amountColumn];
        }

        public T this[int x, int y]
        {
            get { return _table[x, y]; }
            set { _table[x, y] = value; }
        }

        public void InsertEmptyRow(int rowIndex)
        {
            var tempTable = new T[_table.GetLength(0), _table.GetLength(1) + 1];

            for (int i = 0; i < _table.GetLength(0); i++)
                for (int j = 0; j < _table.GetLength(1); j++)
                    if (j >= rowIndex)
                        tempTable[i, j + 1] = _table[i, j];
                    else
                        tempTable[i, j] = _table[i, j];

            _table = tempTable;
        }

        public void InsertEmptyColumn(int columnIndex)
        {
            var tempTable = new T[_table.GetLength(0) + 1, _table.GetLength(1)];

            for (int i = 0; i < _table.GetLength(0); i++)
                for (int j = 0; j < _table.GetLength(1); j++)
                    if(i >= columnIndex)
                        tempTable[i + 1, j] = _table[i, j];
                    else
                        tempTable[i, j] = _table[i, j];

            _table = tempTable;
        }
    }
}