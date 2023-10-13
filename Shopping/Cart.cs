using System;
using System.Net.Http.Headers;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _cartItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> cartItems)
        {
            throw new NotImplementedException();
        }

        public void Remove(List<CartItem> cartItemsToRemove = null)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public float Price
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Cheapest()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
        public class CartException : Exception { }
    }
}
