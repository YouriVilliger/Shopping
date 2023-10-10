using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

namespace Shopping
{
    public class Cart
    {
        #region private attributes
        private List<CartItem> _articleItems = new List<CartItem>();
        #endregion private attributes

        #region public methods
        public void Add(List<CartItem> articleItems)
        {
            foreach (CartItem articleToAdd in articleItems)
            {
                 _articleItems.Add(articleToAdd);
            }
        }

        public List<CartItem> Remove(Boolean clearCart = false)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> Remove(CartItem cartItemToRemove)
        {
            throw new NotImplementedException();
        }

        public void Release()
        {
            throw new NotImplementedException();
        }

        public void Remove(List<CartItem> cartItemsToRemove)
        {
            throw new NotImplementedException();
        }

        public List<CartItem> CartItems
        {
            get
            {
                return _articleItems;
            }
        }

        public float Price
        {
            get
            {
                float _result = 0.00f;
                foreach (CartItem item in _articleItems)
                {
                    _result += item.Article.Price * item.Quantity;
                }
                return _result;
            }
        }
        #endregion public methods
    }
}
