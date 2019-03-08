using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;

    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name):base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
