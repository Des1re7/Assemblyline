using System;
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
            try
            {
                Dictionary<string, double> matchPercent = new Dictionary<string, double>();
                Image<Bgr, Byte> imageBitmap = new Image<Bgr, Byte>(new Bitmap(image));

                if (!Directory.Exists("Templates"))
                {
                    figureName = "null";
                    figurePercent = 0;
                    return;
                }

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

            }
            catch (Exception ex)
            {
                figureName = "null";
                figurePercent = 0;
                ExceptionShower.ShowMsgBox(ex);
            }
        }
    }
}
    
