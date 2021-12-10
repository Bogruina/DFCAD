using System;
using System.Runtime.InteropServices;
using Kompas6Constants3D;
using Kompas6API5;
using FlaskWurthzKompasBuilder.Service;

namespace FlaskWurthzKompasBuilder
{
    /// <summary>
    /// Класс для взаимодействия с Kompas 3D
    /// </summary>
    internal class KompasWrapper
    {
        /// <summary>
        /// Объект интерфейса KompasObject для взимодействия с Kompas 3D
        /// </summary>
        public KompasObject KompasObject { get; }

        /// <summary>
        /// Объект интерфейса KsPart для взимодействия с компонентом Kompas 3D
        /// </summary>
        public ksPart Part { get; set; }

        /// <summary>
        /// Конструктор класса, выполняет запуск Kompas 3D
        /// </summary>
        public KompasWrapper()
        {
            var progId = "KOMPAS.Application.5";
            try
            {
                KompasObject = (KompasObject)Marshal2.GetActiveObject(progId);
            }
            catch (COMException)
            {
                KompasObject = (KompasObject)Activator.
                    CreateInstance(Type.GetTypeFromProgID(progId));
            }

            KompasObject.Visible = true;
            KompasObject.ActivateControllerAPI();
        }

        /// <summary>
        /// Метод для создания нового компонента в Kompas 3D.
        /// </summary>
        public void GetNewPart()
        {
            var ksDoc = (ksDocument3D)KompasObject.Document3D();
            ksDoc.Create(false, true);
            Part = (ksPart)ksDoc.GetPart((short)Part_Type.pTop_Part);
        }
    }
}

