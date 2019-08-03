using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConsumingWCFService.Repositories.Objects_Generics
{
    #region -- Bateau  --
    public class Generics
    {
        public void Add(Book book)
        {
            throw new NotImplementedException();
        }

        public Book this[int book]
        {
            get { throw new NotImplementedException(); }
        }
    }
    #endregion

    #region --  Recomanded  --
    public class GenericsList<T>
    {
        public void Add(T value)
        {
            
        }

        public T this[int book]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericsDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }       
    }

    // --  Generic avec contrainte  --
    // -- where T : IComparable  --
    // -- where T : Product  -- (Type Objet predefini)
    // -- where T : new()  -- (Type class avec un constructeur par defaut)
    class Utilities<T> where T: IComparable
    {
        // -- Basic  --
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        // --  --
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        // --   --
    }

    // -- where T : class  -- (Type class)
    public class DiscountCalculateur<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }
    
    // -- where T : struct  -- (Type valeur)
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {

        }

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
    #endregion

    public class Book : Product
    {
        public string Id { get; set; }
    }

    public class Product
    {
        public string Ref { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
