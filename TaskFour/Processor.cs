using System;

namespace TaskFour
{
    public class Processor<TRequst, TEntity>
    {
        private readonly Func<TRequst, bool> _check;
        private readonly Func<TRequst, TEntity> _register;
        private readonly Action<TEntity> _save;

        protected Processor(Func<TRequst, bool> check, Func<TRequst, TEntity> register, Action<TEntity> save)
        {
            _check = check;
            _register = register;
            _save = save;
        }

        public TEntity Process(TRequst request)
        {
            if (!_check(request))
                throw new ArgumentException();
            var result = _register(request);
            _save(result);
            return result;
        }
    }
}