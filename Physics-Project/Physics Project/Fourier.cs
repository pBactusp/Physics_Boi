using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Physics_Project
{
    public class complex
    {
        public float real = 0f;
        public float imag = 0f;
        //Empty constructor
        public complex()
        {
        }
        public complex(float real, float im)
        {
            this.real = real;
            this.imag = im;
        }
        override public string ToString()
        {
            string data = real.ToString() + " " + imag.ToString() + "i";
            return data;
        }
        //Convert from polar to rectangular
        public static complex from_polar(double r, double radians)
        {
            complex data = new complex((float)(r * Math.Cos(radians)), (float)(r * Math.Sin(radians)));
            return data;
        }
        //Override addition operator
        public static complex operator +(complex a, complex b)
        {
            complex data = new complex(a.real + b.real, a.imag + b.imag);
            return data;
        }
        //Override subtraction operator
        public static complex operator -(complex a, complex b)
        {
            complex data = new complex(a.real - b.real, a.imag - b.imag);
            return data;
        }
        //Override multiplication operator
        public static complex operator *(complex a, complex b)
        {
            complex data = new complex((a.real * b.real) - (a.imag * b.imag),
           (a.real * b.imag) + (a.imag * b.real));
            return data;
        }
        //Return magnitude of complex number
        public float magnitude
        {
            get
            {
                return (float)(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2)));
            }
        }
        public float phase
        {
            get
            {
                return (float)(Math.Atan(imag / real));
            }
        }
    }

    public static class fourierTransform
    {
        public static complex[] NamedListToComplex(NamedList x, NamedList y)
        {
            complex[] X = new complex[x.Count];
            for (int i = 0; i < X.Length - 1; i++)
                X[i] = new complex(x[i], y[i]);
            if (X.Length % 2 == 0)
                X[X.Length - 1] = new complex(x[X.Length - 1], y[X.Length - 1]);
            return X;
        }

        public static DataSet ComplexToNamedList(complex[] X, string nameX, string nameY)
        {
            DataSet ret = new DataSet();
            ret.DataX = new NamedList(nameX);
            ret.DataY = new NamedList(nameY);

            for (int i = 0; i < X.Length; i++)
            {
                ret.DataX.Add(X[i].real);
                ret.DataY.Add(X[i].imag);
            }


            return ret;
        }

        public static complex[] FFT(complex[] x)
        {
            int N = x.Length;
            complex[] X = new complex[N];
            complex[] d, D, e, E;
            if (N == 1)
            {
                X[0] = x[0];
                return X;
            }
            int k;
            e = new complex[N / 2];
            d = new complex[N / 2];
            for (k = 0; k < N / 2; k++)
            {
                e[k] = x[2 * k];
                d[k] = x[2 * k + 1];
            }
            D = FFT(d);
            E = FFT(e);
            for (k = 0; k < N / 2; k++)
            {
                complex temp = complex.from_polar(1, -2 * Math.PI * k / N);
                D[k] *= temp;
            }
            for (k = 0; k < N / 2; k++)
            {
                X[k] = E[k] + D[k];
                X[k + N / 2] = E[k] - D[k];
            }
            return X;
        }

        public static DataSet FFTcomplete(DataSet dataset)
        {
            return ComplexToNamedList(FFT(NamedListToComplex(dataset.DataX, dataset.DataY)), dataset.DataX.Name, dataset.DataY.Name);
        }
    }
}
