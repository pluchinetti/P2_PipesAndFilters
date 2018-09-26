using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompAndDel;

namespace CompAndDel.Filters.Pipes
{
    class PipeConditional : IPipe
    {
        protected IFilter filtro;
        protected IPipe nextPipeTrue;
        protected IPipe nextPipeFalse;
        
        /// <summary>
        /// La cañería recibe una imagen, le aplica un filtro y la envía a la siguiente cañería
        /// </summary>
        /// <param name="filtro">Filtro que se debe aplicar sobre la imagen</param>
        /// <param name="nextPipe">Siguiente cañería</param>
        public PipeConditional(IFilter filtro, IPipe nextPipeTrue, IPipe nextPipeFalse)
        {
            this.nextPipeTrue = nextPipeTrue;
            this.nextPipeFalse = nextPipeFalse;
            this.filtro = filtro;
        }
        /// <summary>
        /// Devuelve el proximo IPipe
        /// </summary>
        public IPipe Next
        {
            get { return this.nextPipe; }
        }
        /// <summary>
        /// Devuelve el IFilter que aplica este pipe
        /// </summary>
        public IFilter Filter
        {
            get { return this.filtro; }
        }
        /// <summary>
        /// Recibe una imagen, le aplica un filtro y la envía al siguiente Pipe
        /// </summary>
        /// <param name="picture">Imagen a la cual se debe aplicar el filtro</param>
        public IPicture Send(IPicture picture)
        {
            picture = this.filtro.Filter(picture);

            if (this.filtro.booleano)
                return this.nextPipeTrue.Send(picture);
            else
                return this.nextPipeFalse.Send(picture);
        }
    }
}
