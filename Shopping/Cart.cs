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

        public bool DoesExist(int temp)
        {
            throw new NotImplementedException();
        }

        public int Cheapest()
        {
            throw new NotImplementedException();
        }
        #endregion public methods
        public class CartException : Exception { }
    }
}
