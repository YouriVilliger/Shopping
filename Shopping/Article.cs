﻿namespace Shopping
{
    public class Article
    {
        #region private attributes
        private int _id;
        private string _description = "";
        private float _price = 0f;
        #endregion private attributes

        #region public methods
        public Article(int id, string description, float price)
        {
            _id = id;
            _description = description;
            _price = price;
        }


        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                if (value.Contains('!') || value.Contains('*') || value.Contains('+') || value.Contains('/'))
                {
                    throw new SpecialCharInDescriptionException();
                }else if (!value.Contains(' '))
                {
                    throw new TooShortDescriptionException();
                }
                else if (value.Length > 50)
                {
                    throw new TooLongDescriptionException();
                }
                else
                {
                    _description = value;
                }
            }
        }

        public float Price
        {
            get
            {
                return _price;
            }
        }
        #endregion public methods

        public class ArticleException : Exception { }
        public class TooShortDescriptionException : ArticleException { }
        public class SpecialCharInDescriptionException : ArticleException { }
        public class TooLongDescriptionException : ArticleException { }
    }
}
