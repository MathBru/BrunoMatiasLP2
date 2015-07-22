using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_14_07_15
{

   
    class Cachorro
    {
        
    
        public double _tamanhoCm;
        public string _nome;
        public double _peso;
        

        public void SetNome(string nome)
        {
            _nome = nome;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetPeso(double peso)
        {
            _peso = peso;
        }

        public double GetPeso()
        {
            return _peso;
        }

        public void SetTamanhoCm(double tamanhoCm)
        {
            _tamanhoCm = tamanhoCm / 100;
        }
        public double GetTamanhoCm()
        {
            return _tamanhoCm;
        }


        public double RacaoDiariaKg()
        {
            return (0.1 * _peso) / (_tamanhoCm * _tamanhoCm);
        }

    
}
}
