using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

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

        public void Remove(List<CartItem> cartItemsToRemove = null)
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
                foreach (CartItem cartIem in _articleItems)
                {
                    _result += cartIem.Article.Price * cartIem.Quantity;
                }
                return _result;
            }
        }

        public bool DoesExist(int articleId)
        {
            foreach (CartItem cartIem in _articleItems)
            {
                if (cartIem.Article.Id == articleId)
                {
                    return true;
                }
            }
            return false;
        }

        public int Cheapest()
        {
            int _index = 0;
            float _minPrice = _articleItems[0].Article.Price;
            
            foreach (CartItem cartIem in _articleItems)
            {
                if (cartIem.Article.Price <= _minPrice)
                {
                    _minPrice = cartIem.Article.Price;
                    _index = cartIem.Article.Id;
                }
            }
            
            return _index;
        }

        public int MostExpensive()
        {
            int _index = 0;
            float _maxPrice = _articleItems[0].Article.Price;

            foreach (CartItem cartIem in _articleItems)
            {
                if (cartIem.Article.Price >= _maxPrice)
                {
                    _maxPrice = cartIem.Article.Price;
                    _index = cartIem.Article.Id;
                }
            }

            return _index;
        }
        #endregion public methods
        public class CartException : Exception { }
    }
}
