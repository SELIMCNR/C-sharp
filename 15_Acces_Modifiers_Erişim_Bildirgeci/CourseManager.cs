using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Acces_Modifiers_Erişim_Bildirgeci
{
    internal class CourseManager
    {
        public void Add()
        {
            //internal bir bildergeç ve aynı assembly aynı projede
            Course course = new Course();
        }
    }

}
