using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintManagementSystem_Smertina.Classes
{
    public class TypeOperation
    {
        /// <summary> Код операции </summary>
        public int id { get; set; }

        /// <summary> Имя операции </summary>
        public string name { get; set; }

        /// <summary> Описание </summary>
        public string description { get; set; }

        /// <summary> Конструктор для заполнения </summary>
        public TypeOperation(int _id, string _name, string _description)
        {
            this.id = _id;
            this.name = _name;
            this.description = _description;
        }

        /// <summary> Операции </summary>
        public static List<TypeOperation> AllTypeOperation()
        {
            List<TypeOperation> allTypeOperation = new List<TypeOperation>();
            allTypeOperation.Add(new TypeOperation(1, "Печать", "")); // Добавляем операцию
            allTypeOperation.Add(new TypeOperation(2, "Копия", "")); // Добавляем операцию
            allTypeOperation.Add(new TypeOperation(3, "Сканирование", "")); // Добавляем операцию
            allTypeOperation.Add(new TypeOperation(4, "Ризограф", "")); // Добавляем операцию
            return allTypeOperation;
        }
    }
}