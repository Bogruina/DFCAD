using Kompas6Constants3D;
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
        /// Стиль линии: основная
        /// </summary>
        private const int MainLineStyle = 1;
        /// <summary>
        /// Стиль линии: вспомогательная
        /// </summary>
        private const int AuxiliaryLineStyle = 3;

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
                parameters.FlaskDiameter, parameters.NeckLength,parameters.NumberBends);

        }

        /// <summary>
        /// Метод для построения основания колбы
        /// </summary>
        /// <param name="flaskDiameter">Диаметр колбы</param>
        private void BuildFlask(double flaskDiameter)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            // Параметры дуги
            var radArc = flaskDiameter / 2;
            var arcCordСenter = new double[] {0, 0};
            var arcCord = new double[] {0, flaskDiameter / 2, 0, -flaskDiameter / 2};
            short direction = 1;
            // Построение дуги
            doc2d.ksArcByPoint(arcCordСenter[0], arcCordСenter[1], radArc, arcCord[0],
                arcCord[1], arcCord[2], arcCord[3], direction, MainLineStyle);
            // Параметры вспомогательного отрезка
            var auxiliaryLineX = new double[] {0, 0};
            var auxiliaryLineY = new double[] {-20, 20};
            // Построение вспомогательного отрезка
            doc2d.ksLineSeg(auxiliaryLineX[0], auxiliaryLineY[0],
                auxiliaryLineX[1], auxiliaryLineY[1], AuxiliaryLineStyle);
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
            //Параметры окружности для выдавливания горла
            var circleCenter = new double[] {0, 0};
            var circleRad = neckDiameter / 2;
            //Создание эскиза и построение в нем окружности
            var sketchDef = SketchAndDrawCircle(Obj3dType.o3d_planeXOY, 
                circleCenter[0], circleCenter[1], circleRad);
            //Параметры выдавливания
            var lengthExtrusion = neckLenght + flaskDiameter;
            CreateExtrusion(sketchDef, lengthExtrusion, side: true);
          
            //Создание отложенной плоскости
            var plane = CreateOffsetPlane(flaskDiameter + neckLenght,
                Obj3dType.o3d_planeXOY);
            var sketchOffset = CreateSketch(offsetPlane: plane);
            var doc2d = (ksDocument2D)sketchOffset.BeginEdit();
            //Параметры окружности для построения горлышка
            circleCenter = new double[] {0, 0};
            circleRad = neckDiameter / 2;
            doc2d.ksCircle(circleCenter[0], circleCenter[1], circleRad, 
                MainLineStyle);
            sketchOffset.EndEdit();
            //Параметры выдавливания
            lengthExtrusion = neckLenght / 10;
            CreateExtrusion(sketchOffset, lengthExtrusion, angle: 15);
        }

        /// <summary>
        /// Метод для построения отвода колбы
        /// </summary>
        /// <param name="bendLenght">Длина отвода</param>
        /// <param name="bendDiameter">Диаметр отвода</param>
        /// <param name="flaskDiameter">Диаметр колбы</param>
        /// <param name="neckLenght">Длина горла </param>
        private void BuildBend(double bendLenght, double bendDiameter,
            double flaskDiameter, double neckLenght, double numberBends)
        {
            //Параметры окружности для выдавливания отвода
            var cirleCenter = new double[] {(neckLenght / 2) + flaskDiameter / 2, 0};
            var circleRad = bendDiameter / 2;
            //Создание эскиза и построение в нем окружности
            var sketchDef = SketchAndDrawCircle(Obj3dType.o3d_planeYOZ,
                cirleCenter[0], cirleCenter[1], circleRad);
            //Параметры выдавливания
            var lengthExtrusion = bendLenght;
            CreateExtrusion(sketchDef, lengthExtrusion, side: true);

            if (numberBends > 1)
            {
                CreateExtrusion(sketchDef, lengthExtrusion, side: false);
            }

            if (!(numberBends > 2)) return;
            //Параметры окружности для выдавливания отвода
            cirleCenter = new double[] {0, (neckLenght / 2) + flaskDiameter / 2};
            circleRad = bendDiameter / 2;
            //Создание эскиза и построение в нем окружности
            sketchDef = SketchAndDrawCircle(Obj3dType.o3d_planeXOZ,
                cirleCenter[0], cirleCenter[1], circleRad);
            CreateExtrusion(sketchDef, lengthExtrusion, side: true);
            if (numberBends > 3)
            {
                CreateExtrusion(sketchDef, lengthExtrusion, side: false);
            }
        }

        /// <summary>
        /// Метод строит эскиз на заданной плоскости и рисует в нем
        /// окружность с заданным центром и радиусом
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="xc"></param>
        /// <param name="yc"></param>
        /// <param name="radiusCircle"></param>
        /// <returns></returns>
        private ksSketchDefinition SketchAndDrawCircle(Obj3dType obj, 
            double xc, double yc, double radiusCircle)
        {
            var sketchDef = CreateSketch(obj);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            doc2d.ksCircle(-xc, -yc, radiusCircle, MainLineStyle);
            sketchDef.EndEdit();

            return sketchDef;

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
            var angleRotation = 360;
            rotationDef.SetSideParam(true, angleRotation);
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

        /// <summary>
        /// Метод строит отложенную плоскость от
        /// одной из базовых с определенным отступом
        /// </summary>
        /// <param name="offset">Отступ отложенной плоскости</param>
        /// <param name="type">Одна из трех базовых плоскостей</param>
        /// <returns></returns>
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
