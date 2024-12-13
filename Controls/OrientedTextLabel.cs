using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using UR_MTrack.Properties;
using System.Collections.Generic;

namespace UR_MTrack
{
    /// <summary>
    /// This is a lable, in which you can set the text in any direction/angle
    /// </summary>

    #region Orientation

    //Orientation of the text

    public enum Orientation
    {
        Circle,
        Arc,
        Rotate
    }

    public enum Direction
    {
        Clockwise,
        AntiClockwise
    }


    #endregion

    public class OrientedTextLabel : Label
    {

        #region Var

        double rotationAngle;
        string text;
        Orientation textOrientation;
        Direction textDirection;

        #endregion

        public OrientedTextLabel()
        {
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.SupportsTransparentBackColor |
                    ControlStyles.ResizeRedraw, true);
            UpdateStyles();
            rotationAngle = 0d;
            textOrientation = Orientation.Rotate;
            Font = new Font(Font.Name, 20); 
        }


        #region Override

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;


            #region Text

            Brush textBrush = new SolidBrush(ForeColor);

            //Getting the width and height of the text, which we are going to write
            float width = graphics.MeasureString(text, Font).Width;
            float height = graphics.MeasureString(text, Font).Height;

            //The radius is set to 0.9 of the width or height, b'cos not to 
            //hide and part of the text at any stage
            float radius = 0f;
            if (ClientRectangle.Width < ClientRectangle.Height)
            {
                radius = ClientRectangle.Width * 0.9f / 2;
            }
            else
            {
                radius = ClientRectangle.Height * 0.9f / 2;
            }

            //Setting the text according to the selection
            switch (textOrientation)
            {
                case Orientation.Arc:
                    {
                        //Arc angle must be get from the length of the text.
                        float arcAngle = (2 * width / radius) / text.Length;
                        if (textDirection == Direction.Clockwise)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {

                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos(arcAngle * i + rotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 - Math.Sin(arcAngle * i + rotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform((-90 + (float)rotationAngle + 180 * arcAngle * i / (float)Math.PI));
                                graphics.DrawString(text[i].ToString(), Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }
                        }
                        else
                        {
                            for (int i = 0; i < text.Length; i++)
                            {

                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos(arcAngle * i + rotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 + Math.Sin(arcAngle * i + rotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform((-90 - (float)rotationAngle - 180 * arcAngle * i / (float)Math.PI));
                                graphics.DrawString(text[i].ToString(), Font, textBrush, 0, 0);
                                graphics.ResetTransform();

                            }
                        }
                        break;
                    }
                case Orientation.Circle:
                    {
                        if (textDirection == Direction.Clockwise)
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos((2 * Math.PI / text.Length) * i + rotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 - Math.Sin((2 * Math.PI / text.Length) * i + rotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform(-90 + (float)rotationAngle + (360 / text.Length) * i);
                                graphics.DrawString(text[i].ToString(), Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }
                        }
                        else
                        {
                            for (int i = 0; i < text.Length; i++)
                            {
                                graphics.TranslateTransform(
                                    (float)(radius * (1 - Math.Cos((2 * Math.PI / text.Length) * i + rotationAngle / 180 * Math.PI))),
                                    (float)(radius * (1 + Math.Sin((2 * Math.PI / text.Length) * i + rotationAngle / 180 * Math.PI))));
                                graphics.RotateTransform(-90 - (float)rotationAngle - (360 / text.Length) * i);
                                graphics.DrawString(text[i].ToString(), Font, textBrush, 0, 0);
                                graphics.ResetTransform();
                            }

                        }
                        break;
                    }
                case Orientation.Rotate:
                    {
                        //For rotation, who about rotation?
                        double angle = (rotationAngle / 180) * Math.PI;
                        graphics.TranslateTransform(
                            (ClientRectangle.Width + (float)(height * Math.Sin(angle)) - (float)(width * Math.Cos(angle))) / 2,
                            (ClientRectangle.Height - (float)(height * Math.Cos(angle)) - (float)(width * Math.Sin(angle))) / 2);
                        graphics.RotateTransform((float)rotationAngle);
                        graphics.DrawString(text, Font, textBrush, 0, 0);
                        graphics.ResetTransform();

                        break;
                    }
            }
            #endregion

           
        }

        #endregion

        #region Properties

        #region Text
        [Description("Rotation Angle"), Category("Appearance")]
        public double RotationAngle
        {
            get
            {
                return rotationAngle;
            }
            set
            {

                rotationAngle = value;
                Invalidate();
            }
        }

        [Description("Kind of Text Orientation"), Category("Appearance")]
        public Orientation TextOrientation
        {
            get
            {
                return textOrientation;
            }
            set
            {

                textOrientation = value;
                Invalidate();
            }
        }

        [Description("Direction of the Text"), Category("Appearance")]
        public Direction TextDirection
        {
            get
            {
                return textDirection;
            }
            set
            {

                textDirection = value;
                Invalidate();
            }
        }

        [Description("Display Text"), Category("Appearance")]
        public override string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Invalidate();
            }
        }
        #endregion
             

        #endregion


        #region Method


        #endregion

    }
}
