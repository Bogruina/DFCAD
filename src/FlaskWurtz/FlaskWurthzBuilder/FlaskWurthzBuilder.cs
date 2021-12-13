﻿using Kompas6Constants3D;
using Kompas6API5;
using FlaskWurthzSDK;
using KompasAPI7;

namespace FlaskWurthzKompasBuilder
{
    /// <summary>
    /// Класс хранит поля и методы для построения 3D модели Колбы Вюрца
    /// </summary>
    public class FlaskWurthzBuilder
    {
        /// <summary>
        /// Объект класса KompasWrapper
        /// </summary>
        private KompasWrapper _wrapper;

        /// <summary>
        /// Метод для постоения модели Колбы Вюрца
        /// </summary>
        /// <param name="parameters">Параметры колбы</param>
        public void Assembly(FlaskWurthzParameters parameters)
        {
            _wrapper = new KompasWrapper();
            _wrapper.GetNewPart();
            BuildFlask(parameters.FlaskDiameter);
            BuildNeck(parameters.NeckLength, parameters.NeckDiameter,
                parameters.FlaskDiameter);
            BuildBend(parameters.BendLength, parameters.BendDiameter,
                parameters.FlaskDiameter, parameters.NeckLength);

        }

        /// <summary>
        /// Метод для построения основания колбы
        /// </summary>
        /// <param name="flaskDiameter">Диаметр колбы</param>
        private void BuildFlask(double flaskDiameter)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            doc2d.ksArcByPoint(0, 0, flaskDiameter / 2, 0,
                flaskDiameter / 2, 0, -flaskDiameter / 2, 1, 1);
            doc2d.ksLineSeg(0, -20, 0, 20, 3);
            sketchDef.EndEdit();

            CreateRotation(sketchDef);
        }

        /// <summary>
        /// Метод для построения горла колбы
        /// </summary>
        /// <param name="neckLenght">Длина горла колбы</param>
        /// <param name="neckDiameter">Диаметр горла колбы</param>
        /// <param name="flaskDiameter">Диаметр колбы</param>
        private void BuildNeck(double neckLenght, double neckDiameter,
            double flaskDiameter)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOY);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            doc2d.ksCircle(0, 0, neckDiameter / 2, 1);
            sketchDef.EndEdit();

            CreateExtrusion(sketchDef, neckLenght + flaskDiameter,
                side: true);

            var plane = CreateOffsetPlane(flaskDiameter + neckLenght,
                Obj3dType.o3d_planeXOY);
            var sketchOffset = CreateSketch(offsetPlane: plane);
            doc2d = (ksDocument2D)sketchOffset.BeginEdit();
            doc2d.ksCircle(0, 0, neckDiameter / 2, 1);
            sketchOffset.EndEdit();
            CreateExtrusion(sketchOffset, 10, angle: 15);
        }

        /// <summary>
        /// Метод для построения отвода колбы
        /// </summary>
        /// <param name="bendLenght">Длина отвода</param>
        /// <param name="bendDiameter">Диаметр отвода</param>
        /// <param name="flaskDiameter">Диаметр колбы</param>
        /// <param name="neckLenght">Длина горла </param>
        private void BuildBend(double bendLenght, double bendDiameter,
            double flaskDiameter, double neckLenght)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeYOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            var centerCircle = (neckLenght / 2) + flaskDiameter / 2;
            doc2d.ksCircle(-centerCircle, 0, bendDiameter / 2, 1);
            sketchDef.EndEdit();

            CreateExtrusion(sketchDef, bendLenght, side: true);
        }

        /// <summary>
        /// Метод для создания элемента вращения
        /// </summary>
        /// <param name="sketchDef">Эскиз по которому будет построен 
        /// элемент вращения</param>
        private void CreateRotation(ksSketchDefinition sketchDef)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossRotated;
            var rotationEntity = (ksEntity)_wrapper.Part.
                NewEntity((short)type);
            var rotationDef = (ksBossRotatedDefinition)
                rotationEntity.GetDefinition();

            rotationDef.SetSideParam(true, 360);
            rotationDef.SetSketch(sketchDef);

            rotationEntity.Create();
        }

        /// <summary>
        /// Метод для выполнения выдавливания
        /// </summary>
        /// <param name="sketchDef">Эскиз по которому будет
        /// производиться выдавливание</param>
        /// <param name="lenght">Расстояние выдавливания</param>
        /// <param name="side">Направление выдавливания</param>
        private void CreateExtrusion(ksSketchDefinition sketchDef,
            double lenght, bool side = true, bool thin = true, double angle = 0)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion;
            var extrusionEntity = (ksEntity)_wrapper.Part.
                NewEntity((short)type);
            var extrusionDef = (ksBossExtrusionDefinition)
                extrusionEntity.GetDefinition();

            extrusionDef.SetSideParam(side,
                (short)End_Type.etBlind, lenght, angle, false);
            extrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal :
                (short)Direction_Type.dtReverse;
            extrusionDef.SetThinParam(thin,
                (short)Direction_Type.dtNormal, 0.5, 1);
            extrusionDef.SetSketch(sketchDef);
            extrusionEntity.Create();
        }

        /// <summary>
        /// Метод для создания эскиза на выбранной плоскости
        /// </summary>
        /// <param name="planeType">Плоскость эскиза</param>
        /// <returns></returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType
            = Obj3dType.o3d_planeXOY,
            ksPlaneOffsetDefinition offsetPlane = null)
        {
            var plane = (ksEntity)_wrapper.Part.GetDefaultEntity((short)planeType);

            var sketch = (ksEntity)_wrapper.Part.
                NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition ksSketch = (ksSketchDefinition)sketch.
                GetDefinition();

            if (offsetPlane != null)
            {
                ksSketch.SetPlane(offsetPlane);
                sketch.Create();

                return ksSketch;
            }

            ksSketch.SetPlane(plane);
            sketch.Create();
            return ksSketch;
        }

        private ksPlaneOffsetDefinition CreateOffsetPlane(double offset, Obj3dType type)
        {
            var plane = (ksEntity)_wrapper.Part.GetDefaultEntity((short)type);
            var newEntity = (ksEntity)
                _wrapper.Part.NewEntity((short)Obj3dType.o3d_planeOffset);
            ksPlaneOffsetDefinition offsetPlane = (ksPlaneOffsetDefinition)newEntity.GetDefinition();
            offsetPlane.SetPlane(plane);
            offsetPlane.offset = offset;
            newEntity.Create();

            return offsetPlane;
        }
    }
}
