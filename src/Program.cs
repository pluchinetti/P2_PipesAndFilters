using System;
using CompAndDel.Filters.Pipes;
using CompAndDel.Filters;
using twitterPublisher;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider pictureProvider = new PictureProvider();
            IPicture picOrig = pictureProvider.GetPicture("Tero.jpg");

            FilterNegative negative = new FilterNegative();
            FilterBlurConvolution blurConvo = new FilterBlurConvolution();

            PipeNull pipeEnd = new PipeNull();
            PipeSerial pipe2 = new PipeSerial(negative,pipeEnd);
            PipeSerial pipe1 = new PipeSerial(blurConvo,pipe2);

            pictureProvider.SavePicture(pipe1.Send(picOrig),"TeroFiltrado.jpg"); 

            string consumerKey = "dtOgpyjBBXglAzMEjMMZtFf73";
            string consumerKeySecret = "Qzm0FxotJ9YyoXiGLJ4JI9IZFWmYvB4LWpteWPGVYofxSG4FnN";
            string accessToken = "1396065818-13uONd7FgFVXhW1xhUCQshKgGv4UOnKeDipg4cz";
            string accessTokenSecret = "HXtlP1SRnJCL5a37R98hFrIRlEIouZX3Ra4s6JuFOpXZF";
            
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            Console.WriteLine(twitter.PublishToTwitter("¿Cuál hay, G?",@"TeroFiltrado.jpg"));

        }
    }
}
