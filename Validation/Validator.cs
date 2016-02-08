namespace Validation
{
    using System;   
    public class Validator
    {
        private const string TITLE_LENGTH_EXCEPTION_MESSAGE = "Invalid title length!";
        private const string PAGE_COUNT_EXCEPTION_MESSAGE = "Invalid page count!";
        private const string INVALID_PAGECOUNT_INPUT = "Invalid data for page count!";
        public void ValidateTitleLength(string title, int length)
        {
            if(title.Length <= length)
            {
                throw new ArgumentException(TITLE_LENGTH_EXCEPTION_MESSAGE);
            }
        }
        public int TryParsePageCountInput(string pageCountInput)
        {
            int number;
            bool isParsesucceeded = int.TryParse(pageCountInput,out number);

            if (!isParsesucceeded)
            {
                throw new ArgumentException(INVALID_PAGECOUNT_INPUT);
            }

            return number;
        }
        public void ValidatePageCount(int pageCount, int minPageCount, int maxPageCount)
        {
            if(pageCount < minPageCount || pageCount > maxPageCount)
            {
                throw new ArgumentOutOfRangeException(PAGE_COUNT_EXCEPTION_MESSAGE);
            }
        } 
    }
}
