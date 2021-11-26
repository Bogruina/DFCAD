using System;
using System.Runtime.InteropServices;
using KompasAPI7;
using Kompas6Constants;
using Kompas6Constants3D;
using Kompas6API5;
using FlaskWurthzBLL.Service;

namespace FlaskWurthzBLL
{
    class KompasWrapper
    {
        private KompasObject _kompasObject;

        public KompasObject KompasObject { get; }

        public ksPart Part { get; set; }

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
        /// Метод для создания нового компонента в Компас3D.
        /// </summary>
        public void GetNewPart()
        {
            var ksDoc = (ksDocument3D)KompasObject.Document3D();
            ksDoc.Create(false, true);
            Part = (ksPart)ksDoc.GetPart((short)Part_Type.pTop_Part);
        }
    }
}

