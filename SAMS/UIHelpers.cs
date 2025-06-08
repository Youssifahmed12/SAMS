using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace StudentAttendanceSystem
{

    public static class UIHelpers
    {
        // Dictionary to store state if you want per-button, or just use tag
        private enum ButtonState { Normal, Hovered, Pressed }

        public static void ApplyRoundedStyle(Button btn, int radius = 20)
        {
            btn.Tag = ButtonState.Normal;
            btn.MouseEnter += (s, e) => { btn.Tag = ButtonState.Hovered; btn.Invalidate(); };
            btn.MouseLeave += (s, e) => { btn.Tag = ButtonState.Normal; btn.Invalidate(); };
            btn.MouseDown += (s, e) => { btn.Tag = ButtonState.Pressed; btn.Invalidate(); };
            btn.MouseUp += (s, e) => { btn.Tag = ButtonState.Hovered; btn.Invalidate(); };

            btn.Paint += (s, e) => PaintRoundedButton(s as Button, e, radius);
            btn.Resize += (s, e) => btn.Invalidate();

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }


        private static void PaintRoundedButton(Button btn, PaintEventArgs e, int radius)
        {
            if (btn == null) return;

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.Clear(btn.Parent.BackColor);

            Rectangle rect = btn.ClientRectangle;
            var state = btn.Tag is ButtonState bs ? bs : ButtonState.Normal;

            Color bgColor = btn.BackColor;

            // You can customize these however you like
            switch (state)
            {
                case ButtonState.Hovered:
                    bgColor = ControlPaint.Light(btn.BackColor, 0.1f); // subtle light
                    break;
                case ButtonState.Pressed:
                    bgColor = ControlPaint.Dark(btn.BackColor, 0.1f); // subtle dark
                    break;
            }

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius, 0, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(0, rect.Height - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(bgColor))
                    e.Graphics.FillPath(brush, path);

                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, rect, btn.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }
        }
    }

}
