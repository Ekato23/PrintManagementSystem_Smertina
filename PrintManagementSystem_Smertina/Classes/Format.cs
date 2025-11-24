using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintManagementSystem_Smertina.Classes
{
    public class Format
    {
        /// <summary> Код формата </summary>
        public int id { get; set; }

        /// <summary> Наименование формата </summary>
        public string format { get; set; }

        /// <summary> Описание формата </summary>
        public string description { get; set; }

        /// <summary> Конструктор для заполнения </summary>
        public Format(int _id, string _format, string _description)
        {
            this.id = _id;
            this.format = _format;
            this.description = _description;
        }

        public static List<Format> AllFormats()
        {
            List<Format> allFormat = new List<Format>();
            allFormat.Add(new Format(1, "А4", "")); // Добавляем формат
            allFormat.Add(new Format(2, "А3", "")); // Добавляем формат
            allFormat.Add(new Format(3, "А2", "")); // Добавляем формат
            allFormat.Add(new Format(4, "А1", "")); // Добавляем формат
            return allFormat;
        }
    }
}
