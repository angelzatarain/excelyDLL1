using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebaDLL3
{
    public class Class1
    {
        //Por interoperabilidad ya no haremos staticos sino una clase
        private int num1 = 5;
        private int num2 = 3;

        public void setNum1(int numero) {
            num1 = numero;
        }

        public void setNum2(int numero) {
            num2 = numero;
        }

        public int multiplica() {
            return num1 * num2;
        }
    }
}
