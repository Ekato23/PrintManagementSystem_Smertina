using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintManagementSystem_Smertina.Classes
{
    public class TypeOperationsWindow
    {
        /// <summary> Текстовый тип операции </summary>
        public string typeOperationText { get; set; }

        /// <summary> Формат операции </summary>
        public string formatText { get; set; }

        /// <summary> Цвет операции </summary>
        public string colorText { get; set; }

        /// <summary> Тип операции </summary>
        public int typeOperation { get; set; }

        /// <summary> Формат операции </summary>
        public int format { get; set; }

        /// <summary> Кол-во сторон </summary>
        public int side { get; set; }

        /// <summary> Цветная печать </summary>
        public bool color { get; set; }

        /// <summary> Прозрачность 50% </summary>
        public bool occupancy { get; set; }

        /// <summary> Кол-во страниц </summary>
        public int count { get; set; }

        /// <summary> Цена печати </summary>
        public float price { get; set; }
    }
}