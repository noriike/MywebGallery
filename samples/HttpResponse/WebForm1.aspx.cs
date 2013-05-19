﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebGallery.samples.HttpResponse
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Set the page's content type to JPEG files
            // and clear all response headers.
            Response.ContentType = "image/jpeg";
            Response.Clear();

            // Buffer response so that page is sent
            // after processing is complete.
            Response.BufferOutput = true;

            // Create a font style.
            Font rectangleFont = new System.Drawing.Font(
                "Arial", 10, FontStyle.Bold);

            // Create integer variables.
            int height = 100;
            int width = 200;

            // Create a random number generator and create
            // variable values based on it.
            Random r = new Random();
            int x = r.Next(75);
            int a = r.Next(155);
            int x1 = r.Next(100);

            // Create a bitmap and use it to create a
            // Graphics object.
            Bitmap bmp = new Bitmap(
                width, height, PixelFormat.Format24bppRgb);
            Graphics g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.LightGray);

            // Use the Graphics object to draw three rectangles.
            g.DrawRectangle(Pens.White, 1, 1, width - 3, height - 3);
            g.DrawRectangle(Pens.Aquamarine, 2, 2, width - 3, height - 3);
            g.DrawRectangle(Pens.Black, 0, 0, width, height);

            // Use the Graphics object to write a string
            // on the rectangles.
            g.DrawString(
                "ASP.NET Samples", rectangleFont,
                SystemBrushes.WindowText, new PointF(10, 40));

            // Apply color to two of the rectangles.
            g.FillRectangle(
                new SolidBrush(
                    Color.FromArgb(a, 255, 128, 255)),
                x, 20, 100, 50);

            g.FillRectangle(
                new LinearGradientBrush(
                    new Point(x, 10),
                    new Point(x1 + 75, 50 + 30),
                    Color.FromArgb(128, 0, 0, 128),
                    Color.FromArgb(255, 255, 255, 240)),
                x1, 50, 75, 30);

            // Save the bitmap to the response stream and
            // convert it to JPEG format.
            bmp.Save(Response.OutputStream, ImageFormat.Jpeg);

            // Release memory used by the Graphics object
            // and the bitmap.
            g.Dispose();
            bmp.Dispose();

            // Send the output to the client.
            Response.Flush();
        }
    }
}