using System;


namespace FormMultidimensional
{
    internal class Multidim : Matriz
    {
        float[,] A;
        public Multidim (int M, int N)
        {
            this.M = M; 
            this.N = N; 
            A = new float[this.M,this.N];

        }

        public static Multidim Leer (string A)
        {
            //Matriz A
            // 1,2;3,4 Matriz ingresada Ejemplo
            string[] renglones =   A.Split (';');  //Caracter que se coloque, se va a separar la cadena

            // renglones [0]=1,2
            // RENGLONES [1]=3,4

            string[] columnas = renglones [0].Split (',');

            Multidim m1 = new Multidim(renglones.Length, columnas.Length);
            
            for (int i = 0;i< m1.M; i++)
            {
                columnas= renglones[i].Split(','); 

                for (int j = 0;j< m1.N;j++)
                {
                    m1.A[i, j] = float.Parse(columnas[j]);
                }
            }
            return m1;
            
        }

        public static Multidim operator +(Multidim m1, Multidim m2) 
        {
            Multidim m3 = new Multidim(m1.M, m1.N);
            for (int i=0;i< m1.M; i++)
            {
                for ( int j= 0; j< m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }
            return m3;
        }
        public static Multidim operator -(Multidim m1, Multidim m2)
        {
            Multidim m3 = new Multidim(m1.M, m1.N);
            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] - m2.A[i, j];
                }
            }
            return m3;
        }

        public static Multidim operator *(Multidim m1, Multidim m2)
        {
            Multidim m3 = new Multidim(m1.M, m1.N);
            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = 0;
                    
                    for (int z = 0; z < m1.N; z++)
                    {
                        // Multiplicamos y sumamos resultado
                        //sum += A[i][j] * matrizB[j][a];
                        m3.A[i, j] +=  m1.A[i,z] * m2.A[z,j];

                    }
                    // Lo acomodamos dentro del producto
                }
            }
            return m3;
        }


        public override string ToString()
        {
            // 1 2
            // 3 4

            string A = "";
            for (int i = 0; i < M; i++)
            {
                for (int j=0; j < N; j++)
                {
                    A = A + "  " + this.A[i,j].ToString();
                }
                A += "\n";
            }
            return A;
        }

    }
}
