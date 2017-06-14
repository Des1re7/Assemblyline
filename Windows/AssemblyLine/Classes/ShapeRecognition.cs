﻿using System;
using System.Collections.Generic;

using System.Drawing;
using System.IO;

using Emgu.CV.Structure;
using Emgu.CV;

namespace AssemblyLine.Classes
{
    class ShapeRecognition
    {
        public void DetectObject(Image image, string templatesFolder, out string figureName, out double figurePercent)
        {
            Dictionary<string, double> matchPercent = new Dictionary<string, double>();
            Image<Bgr, Byte> imageBitmap = new Image<Bgr, Byte>(new Bitmap(image));

            List<string> templatesFolders = new List<string>(Directory.EnumerateDirectories(templatesFolder));

            foreach (var tmpFld in templatesFolders)
            {
                matchPercent.Add(tmpFld, 0);

                List<string> tempates = new List<string>(Directory.EnumerateFiles(tmpFld, "*.jpg"));
                foreach (var tmp in tempates)
                {
                    Image<Bgr, Byte> tmpImage = new Image<Bgr, Byte>(tmp);

                    using (Image<Gray, float> result = imageBitmap.MatchTemplate(tmpImage, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed))
                    {
                        double[] minValues, maxValues;
                        Point[] minLocations, maxLocations;
                        result.MinMax(out minValues, out maxValues, out minLocations, out maxLocations);
                        matchPercent[tmpFld] = maxValues[0];
                    }
                }
            }

            double bigger = 0;
            string tmpFigureName = string.Empty;
            double tmpFigurePercent = 0;
            foreach (var match in matchPercent)
            {
                if (match.Value > bigger)
                {
                    bigger = match.Value;
                    tmpFigureName = new DirectoryInfo(match.Key).Name;
                    tmpFigurePercent = match.Value;
                }
            }

            figureName = tmpFigureName;
            figurePercent = tmpFigurePercent;


            // Скейлим шаблон
            //template = template.Resize(Convert.ToInt32(template.Width * scale), Convert.ToInt32(template.Height * scale), Inter.Linear);
            //template = template.Rotate(45, new Bgr(100,100,100));

            //picResult.Image = imageToShow.Bitmap;
        }
    }
}
    