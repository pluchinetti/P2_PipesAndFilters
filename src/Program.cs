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
            FilterTwitterPublish twitterPublish = new FilterTwitterPublish();

            PipeNull pipeEnd = new PipeNull();
            PipeSerial pipe3 = new PipeSerial(twitterPublish,pipeEnd);
            PipeSerial pipe2 = new PipeSerial(negative,pipe3);
            PipeSerial pipe1 = new PipeSerial(blurConvo,pipe2);

            pictureProvider.SavePicture(pipe1.Send(picOrig),"TeroFiltrado.jpg"); 

        }
    }
}
