using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace tsukasa_starter
{
    // 三角形ボタン
    // http://truthfullscore.hatenablog.com/entry/2014/01/29/120529
    public partial class ButtonBGTriangle : System.Windows.Forms.Button
    {
        //三角形の方向指定用列挙体
        public enum TriangleDirection
        {
            Up = 1,
            Down = 2,
            Left = 4,
            Right = 8,
        }

        //三角形の方向指定プロパティ
        private TriangleDirection TRIANGLE_DIRECTION = TriangleDirection.Left;
        public TriangleDirection Direction
        {
            get { return this.TRIANGLE_DIRECTION; }
            set
            {
                this.TRIANGLE_DIRECTION = value;
                this.Invalidate();
            }
        }

        //三角形の塗りつぶし色プロパティ
        private Color TRIANGLE_COLOR = System.Drawing.SystemColors.ControlText;
        public Color TriangleColor
        {
            get { return this.TRIANGLE_COLOR; }
            set
            {
                this.TRIANGLE_COLOR = value;
                this.Invalidate();
            }
        }

        public ButtonBGTriangle()
        {
            this.Text = "";
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            //テキストを空に変更し無効化
            this.Text = "";
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            PointF[] drawPoint = new PointF[3];

            //TRIANGLE_DIRECTIONに応じて三角形を描画
            switch (TRIANGLE_DIRECTION)
            {
                case TriangleDirection.Up:
                    drawPoint[0] = new PointF((this.ClientSize.Width - 1.0f) / 2.0f, (this.ClientSize.Height - 1.0f) / 4.0f);
                    drawPoint[1] = new PointF((this.ClientSize.Width - 1.0f) / 6.0f, (this.ClientSize.Height - 1.0f) * 3.0f / 4.0f);
                    drawPoint[2] = new PointF((this.ClientSize.Width - 1.0f) * 5.0f / 6.0f, (this.ClientSize.Height - 1.0f) * 3.0f / 4.0f);
                    g.FillPolygon(new SolidBrush(TRIANGLE_COLOR), drawPoint);
                    break;
                case TriangleDirection.Down:
                    drawPoint[0] = new PointF((this.ClientSize.Width - 1.0f) / 2.0f, (this.ClientSize.Height - 1.0f) * 3.0f / 4.0f);
                    drawPoint[1] = new PointF((this.ClientSize.Width - 1.0f) / 6.0f, (this.ClientSize.Height - 1.0f) / 4.0f);
                    drawPoint[2] = new PointF((this.ClientSize.Width - 1.0f) * 5.0f / 6.0f, (this.ClientSize.Height - 1.0f) / 4.0f);
                    g.FillPolygon(new SolidBrush(TRIANGLE_COLOR), drawPoint);
                    break;
                case TriangleDirection.Left:
                    drawPoint[0] = new PointF((this.ClientSize.Width - 1.0f) * 3.0f / 4.0f, (this.ClientSize.Height - 1.0f) / 6.0f);
                    drawPoint[1] = new PointF((this.ClientSize.Width - 1.0f) * 3.0f / 4.0f, (this.ClientSize.Height - 1.0f) * 5.0f / 6.0f);
                    drawPoint[2] = new PointF((this.ClientSize.Width - 1.0f) / 4.0f, (this.ClientSize.Height - 1.0f) / 2.0f);
                    g.FillPolygon(new SolidBrush(TRIANGLE_COLOR), drawPoint);
                    break;
                case TriangleDirection.Right:
                    drawPoint[0] = new PointF((this.ClientSize.Width - 1.0f) / 4.0f, (this.ClientSize.Height - 1.0f) / 6.0f);
                    drawPoint[1] = new PointF((this.ClientSize.Width - 1.0f) / 4.0f, (this.ClientSize.Height - 1.0f) * 5.0f / 6.0f);
                    drawPoint[2] = new PointF((this.ClientSize.Width - 1.0f) * 3.0f / 4.0f, (this.ClientSize.Height - 1.0f) / 2.0f);
                    g.FillPolygon(new SolidBrush(TRIANGLE_COLOR), drawPoint);
                    break;
            }
        }
    }
}
