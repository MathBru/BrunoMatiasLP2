using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Viagem
{
    class Carro1
    {
        public string _modelo;
        public string _marca;
        public string _placa;
        public int _capacidadeDePassageiros;
        public int _id = 0;

        public void SetModelo(string modelo)
        {
            _modelo = modelo;
        }

        public string GetModelo()
        {
            return _modelo;
        }

        public void SetMarca(string marca)
        {
            _marca = marca;
        }

        public string GetMarca()
        {
            return _marca;
        }

        public void SetPlaca(string placa)
        {
            _placa = placa;
        }

        public string GetPlaca()
        {
            return _placa;
        }

        public void SetCapacidadePassageiros(int capcPassageiros)
        {
            _capacidadeDePassageiros = capcPassageiros;
        }

        public int GetCapacidadePassageiros()
        {
            return _capacidadeDePassageiros;
        }

        public void SetValueToId()
        {
            _id += 1;
        }

        public int GetId()
        {
            return _id;
        }
    }
}
