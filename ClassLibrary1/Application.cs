using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    class Application
    {
        private Application application { get; set; }
        private List<TaskList> taskLists{ get; set; }

        /// <summary>
        /// 
        /// </summary>
        private Application()
        {

        }

        /// <summary>
        /// возвращает ссылку на экземпляр приложения, а в его отсутствие создает экземпляр
        /// </summary>
        /// <returns></returns>
        public Application GetApplication()
        {

        }
    }

    
}
