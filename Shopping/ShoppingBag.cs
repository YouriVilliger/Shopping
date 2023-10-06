namespace Shopping
{
    public class ShoppingBag:ICollectionOfArticles
    {
        #region private attributes
        private List<Article> articles = new List<Article>();

        public List<Article> Articles => throw new NotImplementedException();

        public void Add(List<Article> articles)
        {
            foreach (var article in articles)
            {
                this.articles.Add(article);
            }
        }

        public List<Article> Remove(bool empty = false)
        {
            throw new NotImplementedException();
        }
        #endregion private attributes
    }
}
