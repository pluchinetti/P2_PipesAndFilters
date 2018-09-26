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
            IPicture picOrig = pictureProvider.GetPicture("jac.jpg");

            FilterNegative negative = new FilterNegative();
            //https://twitter.com/POOUCU?lang=en&lang=en
            FilterTwitterPublish twitterPublish = new FilterTwitterPublish();
            FilterCognitive faceRecog = new FilterCognitive();
           
            IConvolutionMatrix matrix = new BlurConvolutionMatrix();
            FilterConvolution blurConvo = new FilterConvolution(matrix);

            PipeNull pipeEnd = new PipeNull();
            //PipeSerial pipe32 = new PipeSerial(negative,pipeEnd);
            PipeSerial pipe22 = new PipeSerial(negative,pipeEnd);
            PipeSerial pipe21 = new PipeSerial(twitterPublish,pipeEnd);
            PipeConditional pipe1 = new PipeConditional(faceRecog,pipe21,pipe22);

            pictureProvider.SavePicture(pipe1.Send(picOrig),"jacFiltrado.jpg"); 

        }
    }
}
