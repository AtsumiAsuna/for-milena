using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        double roomLenght; //длина комнаты
        double roomWidth; //ширина комнаты

        public double RoomLenght
        {
          get { return roomLenght; }
          set { roomLenght = value; }
        }
        public double RoomWidht
        {
            get { return roomWidth; }
            set { roomWidth = value; }
        }
        /// <summary>
        /// метод вычисляет периметр комнаты
        /// </summary>
        /// <returns>возвращает значение периметра</returns>
        public double RoomPerimeter()
        {
            return 2 * (roomLenght + roomWidth);
        }
        /// <summary>
        /// метод вычисляет площадь комнаты
        /// </summary>
        /// <returns>вовзращает значение площади</returns>
        public double RoomArea()
        {
            return roomLenght * roomWidth;
        }
        /// <summary>
        /// метод вычисляет число квадратных метров
        /// на одного человека
        /// </summary>
        /// <param name="np">число человек</param>
        /// <returns>возвращает число квадратных метров</returns>
        public double PersonArea(int np)
        {
            return RoomArea() / np;
        }
    }
}
