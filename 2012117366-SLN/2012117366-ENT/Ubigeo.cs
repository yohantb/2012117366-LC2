using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2012117366_ENT
{
    public class Ubigeo : Direccion
    {

        public int Ubigeoid { get; set; }

        int _departamentoid;
        public int Departamento { get { return Departamentoid; } }

        public int Departamentoid
        {
            get
            {
                return _departamentoid;
            }

            set
            {
                _departamentoid = value;
            }
        }

        int _Provinciaid;
        public int Provincia { get { return Provinciaid; } }

        public int Provinciaid
        {
            get
            {
                return _Provinciaid;
            }

            set
            {
                _Provinciaid = value;
            }
        }


        int _distritoid;
        public int Distrito { get { return Distritoid; } }

        public int Distritoid
        {
            get
            {
                return _distritoid;
            }

            set
            {
                _distritoid = value;
            }
        }

        public Ubigeo()
            : base() { }




    }
}
