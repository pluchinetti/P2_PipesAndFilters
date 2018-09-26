using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Diagnostics;
using System.Drawing;
using CognitiveCore;

namespace CompAndDel.Filters
{
    public class FilterCognitive : IFilter
    {
        /// <summary>
        /// Recibe una imagen y realiza el reconocimiento facial
        /// </summary>
        /// <param name="image">Imagen a la cual se la va a reconocer.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        
        
        public IPicture Filter(IPicture image)
        {
            PictureProvider pictureProvider = new PictureProvider();
            pictureProvider.SavePicture(image,"TempForFacialRecognition.jpg");

            CognitiveFace cog = new CognitiveFace("6cc93ca750fc4e0b9b716925f303dcc1", Color.GreenYellow);
            
            cog.Recognize(@"TempForFacialRecognition.jpg");

            if cog.FaceFound()
                return 
            return negativo;
        }
    }
}
