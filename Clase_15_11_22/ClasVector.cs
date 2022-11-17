using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Drawing;

namespace Clase_15_11_22
{
    class ClasVector
    {
        //atributo
        private float mPosX, mPosY;
        private float mCenX, mCenY;
        private float mMaxX, mMaxY;

        //costantes
        const float mScale = 10.00f; //factor_de_escala
                                     // entorno grafico
        private Graphics mGraph;
        private Pen mPenPlane;
        private Pen mPenVector;

        //get and set
        public float X { get => mPosX; set => mPosX = value; }
        public float Y { get => mPosY; set => mPosY = value; }

        //costructor
        public ClasVector(float x, float y)
        {
            this.mPosX = x;
            this.mPosY = y;
        }
       

        //metodos de graficar ejes
        public void DrawPlano(PictureBox picCanvas)
        {
            mGraph = picCanvas.CreateGraphics();
            mPenPlane = new Pen(Color.Black, 2);
            //para que aparesca una flecha al final
            mPenPlane.EndCap = LineCap.ArrowAnchor;
            mPenPlane.StartCap = LineCap.ArrowAnchor;
            mMaxX = picCanvas.Width;
            mMaxY = picCanvas.Height;
            mCenX = mMaxX / 2;
            mCenY = mMaxY / 2;
            //linea horizontal
            mGraph.DrawLine(mPenPlane, 0, mCenY, mMaxX, mCenY);
            //vertical
            mGraph.DrawLine(mPenPlane, mCenX, 0, mCenX, mMaxY);  
        }

        //para leer los datos con numericos
        public void ReadData(NumericUpDown numX, NumericUpDown numY)
        {
            //hay que transformarlos a flotantes ya que estan en enteros
            //son los puntos que se grafican
            //estos no son posiciones reales,
            mPosX = (float)numX.Value;
            mPosY = (float)numY.Value;
        }
        //funcion para transfomar los puntos que ingresaremos
        public PointF VectorPoint(float x, float y)
        {
            //para determinar la escala que usaremos
            PointF auxPoint = new PointF(0F, 0F);
            //transformamos los puntos por la escala
            auxPoint.X = mCenX + (x * mScale);
            auxPoint.Y = mCenX - (y * mScale);
            return (auxPoint);
        }
        public void DrawVector(ClasVector objVector, Color color, PictureBox picCanvas)
        {
            //los pasos del anterior
            mGraph = picCanvas.CreateGraphics();
            mPenVector = new Pen(Color.Blue);
            //para que se forme una bomba a su inicio
            mPenVector.StartCap = LineCap.RoundAnchor;
            //para que aparesca una flecha al final
            mPenVector.EndCap = LineCap.ArrowAnchor;
            mMaxX = picCanvas.Width;
            mMaxY = picCanvas.Height;
            //toca determinar que mismo puntos se graficar
            mGraph.DrawLine(mPenVector, VectorPoint(0, 0), VectorPoint(mPosX, mPosY));
        }
    }
}
