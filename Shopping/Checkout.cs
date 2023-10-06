namespace Shopping
{
    public class Checkout : ICollectionOfArticles
    {
        #region private attributes
        private List<Article> _articles = new List<Article>();
        private float _balance = 0f;
        #endregion private attributes

        #region public methods
        public void Add(List<Article> articles)
        {
            foreach (var article in articles)
            {
                _articles.Add(article);
                _balance += article.Price;
            }
        }

        public List<Article> Remove(Boolean empty = false)
        {
            List<Article> articlesReadyToCheckout = new List<Article>();
            if (empty)
            {
                articlesReadyToCheckout.AddRange(_articles);
                _articles.Clear();
            }
            else
            {
                articlesReadyToCheckout.Add(_articles[_articles.Count - 1]);
                _articles.RemoveAt(_articles.Count - 1);
            }
            UpdateBalance();
            return articlesReadyToCheckout;
        }

        public List<Article> Articles
        {
            get
            {
                return _articles;
            }
        }

        public float Balance
        {
            get
            {
                return _balance;
            }
        }

        public void StartCashingProcess()
        {
            throw new NotImplementedException();
        }
        #endregion public methods

        #region private methods
        private void UpdateBalance()
        {
            {
                _balance = _articles.Count * _balance;
            }
        }
        #endregion private methods
    }
}
