using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    using GradeBook.Enums;

    class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(string name):base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
