using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    public class Validator
    {
        private const string TITLE_LENGTH_EXCEPTION_MESSAGE = "Invalid title length!";
        private const string PAGE_COUNT_EXCEPTION_MESSAGE = "Invalid page count!";
       public void ValidateTitleLength(string title, int length)
        {
            if(title.Length <= length)
            {
                throw new ArgumentException(TITLE_LENGTH_EXCEPTION_MESSAGE);
            }
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
