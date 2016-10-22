using System;

namespace TaskFour
{
    public class TransactionProcessor
    {
        private readonly Func<TransactionRequest, bool> _check;
        private readonly Func<TransactionRequest, Transaction> _register;
        private readonly Action<Transaction> _save;

        protected TransactionProcessor(Func<TransactionRequest, bool> check, Func<TransactionRequest, Transaction> register, Action<Transaction> save)
        {
            _check = check;
            _register = register;
            _save = save;
        }

        public Transaction Process(TransactionRequest request)
        {
            if (!_check(request))
                throw new ArgumentException();
            var result = _register(request);
            _save(result);
            return result;
        }
    }
}