using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Diagnostics;
using System.Drawing;
using CognitiveCore;

namespace CompAndDel.Filters
{
    public class FilterCognitive : IFilterBool
    {
        /// <summary>
        /// Recibe una imagen y realiza el reconocimiento facial
        /// </summary>
        /// <param name="image">Imagen a la cual se la va a reconocer.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        
        CognitiveFace cog = new CognitiveFace("6cc93ca750fc4e0b9b716925f303dcc1", Color.GreenYellow);
        public bool Boolean {get; set;}
        PictureProvider pictureProvider = new PictureProvider();
        
        public IPicture Filter(IPicture image)
        {          
            pictureProvider.SavePicture(image,"TempForFacialRecognition.jpg");
            
            cog.Recognize(@"TempForFacialRecognition.jpg");

            Boolean = cog.FaceFound;

            IPicture picOrig = pictureProvider.GetPicture("tmpFace.jpg");
            return picOrig;
        }
    }
}
