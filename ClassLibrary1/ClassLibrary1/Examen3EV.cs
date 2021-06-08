using System.Collections.Generic;

namespace Examen3EV_NS
{
    public class EstadisticasNotas  // esta clase nos calcula las estadísticas de un conjunto de notas 
    {
        private int suspenso;  // Suspensos 
        private int aprobado;  // Aprobados
        private int notable;  // Notables
        private int sobresaliente;  // Sobresalientes

        private double notamedia; // Nota media

        public int Suspenso {
            get {  return this.suspenso; }
            set { suspenso = value; }
        }

        public int Aprobado {
            get { return this.aprobado; }
            set { aprobado = value; }
        }
        
        public int Notable {
            get { return this.notable; }
            set { notable = value; }
        }

        public int Sobresaliente {
            get { return this.sobresaliente; }
            set { sobresaliente = value; }
        }

        public double Notamedia {
            get { return this.notamedia; }
            set { notamedia = value; }
        }
                                    
        // Constructor vacío
        public EstadisticasNotas()
        {
            Suspenso = Aprobado = Notable = Sobresaliente = 0;  // inicializamos las variables
            Notamedia = 0.0;
        }

        // Constructor a partir de un array, calcula las estadísticas al crear el objeto
        public EstadisticasNotas(List<int> listnot)
        {


            Notamedia = 0.0;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) Suspenso++;              // Por debajo de 5 suspenso
                else if (listnot[i] > 5 && listnot[i] < 7) Aprobado++;// Nota para aprobar: 5
                else if (listnot[i] > 7 && listnot[i] < 9) Notable++;// Nota para notable: 7
                else if (listnot[i] > 9) Sobresaliente++;         // Nota para sobresaliente: 9

                Notamedia = Notamedia + listnot[i];
            }

            Notamedia = Notamedia / listnot.Count;
        }





        // Para un conjunto de listnot, calculamos las estadísticas
        // calcula la media y el número de suspensos/aprobados/notables/sobresalientes
        //
        // El método devuelve -1 si ha habido algún problema, la media en caso contrario	
        public double CalculaEstadisticas(List<int> listnot)
        {                                 
            Notamedia = 0.0;

            // TODO: hay que modificar el tratamiento de errores para generar excepciones
            //
            if (listnot.Count <= 0)  // Si la lista no contiene elementos, devolvemos un error
                return -1;

            for (int i=0;i<10;i++)
                if (listnot[i] < 0 || listnot[i] > 10)      // comprobamos que las not están entre 0 y 10 (mínimo y máximo), si no, error
                return -1;

            for (int i = 0; i < listnot.Count; i++)
            {
                if (listnot[i] < 5) Suspenso++;              // Por debajo de 5 suspenso
                else if (listnot[i] >= 5 && listnot[i] < 7) Aprobado++;// Nota para aprobar: 5
                else if (listnot[i] >= 7 && listnot[i] < 9) Notable++;// Nota para notable: 7
                else if (listnot[i] > 9) Sobresaliente++;         // Nota para sobresaliente: 9

                Notamedia = Notamedia + listnot[i];
            }

            Notamedia = Notamedia / listnot.Count;

            return Notamedia;
        }
    }
}
