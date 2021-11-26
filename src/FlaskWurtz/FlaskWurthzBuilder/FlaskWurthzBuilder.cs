using Kompas6Constants3D;
using Kompas6API5;
using FlaskWurthzSDK;

namespace FlaskWurthzBLL
{
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
            BuildNeck(parameters.NeckLenght, parameters.NeckDiameter, parameters.FlaskDiameter);
            BuildBend(parameters.BendLenght, parameters.BendDiameter, parameters.FlaskDiameter, parameters.NeckLenght);

        }

        /// <summary>
        /// Метод для построения основания колбы
        /// </summary>
        /// <param name="flaskDiameter">Диаметр колбы</param>
        private void BuildFlask(double flaskDiameter)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            doc2d.ksArcByPoint(0, 0, flaskDiameter / 2, 0, flaskDiameter / 2, 0, -flaskDiameter / 2, 1,1);
            doc2d.ksLineSeg(0, -20, 0, 20, 3);
            sketchDef.EndEdit();

            CreateRotation(sketchDef, flaskDiameter / 2, side:true);
        }

        /// <summary>
        /// Метод для построения горла колбы
        /// </summary>
        /// <param name="neckLenght">Длина горла колбы</param>
        /// <param name="neckDiameter">Диаметр горла колбы</param>
        /// <param name="flaskDiameter"></param>
        private void BuildNeck(double neckLenght, double neckDiameter, double flaskDiameter)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeXOY);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            doc2d.ksCircle(0,0,neckDiameter/2,1);
            sketchDef.EndEdit();

            CreateExtrusion(sketchDef, neckLenght+ flaskDiameter, side: true);
        }

        /// <summary>
        /// Метод для построения отвода колбы
        /// </summary>
        /// <param name="bendLenght">Длина отвода</param>
        /// <param name="bendDiameter">Диаметер отвода</param>
        /// <param name="flaskDiameter"></param>
        /// <param name="neckLenght"></param>
        private void BuildBend(double bendLenght, double bendDiameter, double flaskDiameter, double neckLenght)
        {
            var sketchDef = CreateSketch(Obj3dType.o3d_planeYOZ);
            var doc2d = (ksDocument2D)sketchDef.BeginEdit();
            var centerCircle = (neckLenght / 2) + flaskDiameter/2;
            doc2d.ksCircle(-centerCircle, 0, bendDiameter / 2, 1);
            sketchDef.EndEdit();

            CreateExtrusion(sketchDef, bendLenght, side: true);
        }

        /// <summary>
        /// Метод для создания элемента вращения
        /// </summary>
        /// <param name="sketchDef">Эскиз по которому будет построен элемент вращения</param>
        /// <param name="radius">Радиус элемента вращения</param>
        /// <param name="side"></param>
        private void CreateRotation(ksSketchDefinition sketchDef, double radius,
            bool side = true)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossRotated;
            var rotationEntity = (ksEntity)_wrapper.Part.NewEntity((short)type);
            var rotationDef = (ksBossRotatedDefinition)rotationEntity.GetDefinition();

            rotationDef.SetSideParam(true, 360);
            rotationDef.SetSketch(sketchDef);
            
            rotationEntity.Create();
        }

        /// <summary>
        /// Метод для выполнения выдавливания
        /// </summary>
        /// <param name="sketchDef">Эскиз по которому будет производиться выдавливание</param>
        /// <param name="lenght">Расстояние выдавливания</param>
        /// <param name="side"></param>
        private void CreateExtrusion(ksSketchDefinition sketchDef, double lenght,
            bool side = true, bool thin = true)
        {
            ksObj3dTypeEnum type = ksObj3dTypeEnum.o3d_bossExtrusion;
            var extrusionEntity = (ksEntity)_wrapper.Part.NewEntity((short)type);
            var extrusionDef = (ksBossExtrusionDefinition)extrusionEntity.GetDefinition();
           
            extrusionDef.SetSideParam(side, (short)End_Type.etBlind,lenght);
            extrusionDef.directionType = side ?
                (short)Direction_Type.dtNormal : (short)Direction_Type.dtReverse;
            extrusionDef.SetThinParam(thin, (short)Direction_Type.dtNormal, 0.5, 1);
            extrusionDef.SetSketch(sketchDef);
            
            extrusionEntity.Create();
        }

        /// <summary>
        /// Метод для создания эскиза
        /// </summary>
        /// <param name="planeType">Плоскость эскиза</param>
        /// <returns></returns>
        private ksSketchDefinition CreateSketch(Obj3dType planeType)
        {
            var plane = (ksEntity)_wrapper.Part.GetDefaultEntity((short)planeType);
            var sketch = (ksEntity)_wrapper.Part.NewEntity((short)Obj3dType.o3d_sketch);
            ksSketchDefinition ksSketch = (ksSketchDefinition)sketch.GetDefinition();

            ksSketch.SetPlane(plane);
            sketch.Create();

            return ksSketch;
        }

    }
}
