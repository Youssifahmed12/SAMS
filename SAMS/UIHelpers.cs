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




        private class DimBackground : Form
        {
            public DimBackground(Form owner)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.BackColor = Color.Black;
                this.Opacity = 0.5;
                this.ShowInTaskbar = false;
                this.StartPosition = FormStartPosition.Manual;
                this.Bounds = owner.Bounds; // full main form bounds
                this.Owner = owner;
            }
        }

        private static void ApplyFadeInForPopUpForm(Form form, int interval = 3, double step = 0.05)
        {
            form.Opacity = 0;
            Timer fadeTimer = new Timer { Interval = interval };
            fadeTimer.Tick += (s, e) =>
            {
                if (form.Opacity < 1)
                    form.Opacity += step;
                else
                    fadeTimer.Stop();
            };
            fadeTimer.Start();
        }

        public static void ApplySmoothRoundedCornersForPopUpForm(Form form, int radius)
        {
            form.FormBorderStyle = FormBorderStyle.None;


            form.Region = GetRoundedRegionForForm(form.Width, form.Height, radius);

            form.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                using (GraphicsPath path = GetRoundedPathForForm(form.ClientRectangle, radius))
                using (Pen pen = new Pen(Color.FromArgb(30, Color.Black), 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };

            form.Resize += (s, e) =>
            {
                form.Region = GetRoundedRegionForForm(form.Width, form.Height, radius);
                form.Invalidate();
            };
        }

        private static Region GetRoundedRegionForForm(int width, int height, int radius)
        {
            using (GraphicsPath path = GetRoundedPathForForm(new Rectangle(0, 0, width, height), radius))
            {
                return new Region(path);
            }
        }

        private static GraphicsPath GetRoundedPathForForm(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.AddArc(rect.Left, rect.Top, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        public static DialogResult ShowDialogWithDim(Form mainForm, Form popupForm, bool applyEffects = true)
        {
            using (var dim = new DimBackground(mainForm))
            {
                dim.Show(mainForm); // Show dim background

                // Position popup centered on main form
                popupForm.StartPosition = FormStartPosition.Manual;
                popupForm.Location = new Point(
                    mainForm.Location.X + (mainForm.Width - popupForm.Width) / 2,
                    mainForm.Location.Y + (mainForm.Height - popupForm.Height) / 2);

                if (applyEffects)
                {
                    ApplyFadeInForPopUpForm(popupForm);
                    ApplySmoothRoundedCornersForPopUpForm(popupForm, 20);
                }

                var result = popupForm.ShowDialog(mainForm);

                dim.Close();

                return result;
            }
        }
    }

}
