using System;
using System.Collections.Generic;
using System.Text;
using CompAndDel;
using System.Drawing;
using System.Diagnostics;
using twitterPublisher;

namespace CompAndDel.Filters
{
    public class FilterTwitterPublish : IFilter
    {
        /// <summary>
        /// Recibe una imagen y la retorna con un filtro del tipo negativo aplicado
        /// </summary>
        /// <param name="image">Imagen a la cual se le va a plicar el filtro.</param>
        /// <returns>Imagen con el filtro aplicado</returns>
        public IPicture Filter(IPicture image)
        {
            string consumerKey = "dtOgpyjBBXglAzMEjMMZtFf73";
            string consumerKeySecret = "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN";
            string accessToken = "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz";
            string accessTokenSecret = "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF";
            
            PictureProvider pictureProvider = new PictureProvider();
            pictureProvider.SavePicture(image,"TeroATwitter.jpg");
            // new pictureProvider.SavePicture(image,"TeroATwitter.jpg"); // Esta línea es igual a las anteriores. Resulta
            // conveniente ya que se utiliza para un método puntual y no interesa quedarse con la referencia al objeto.

            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("Seguimos llenado de imágenes...",@"TeroATwitter.jpg"));

            return image;
        }
    }
}
