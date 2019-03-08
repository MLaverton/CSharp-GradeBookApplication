using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;

    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted):base(name, isWeighted)
        {
            Type = GradeBookType.Standard;
            isWeighted = isWeighted;
        }
    }
}
