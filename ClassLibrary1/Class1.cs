using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
            //se declara el reward por que marcá error en el códgio sino está
            string reward;

            //se crean los jugadores que usarán los métodos
            //estos son creados con el constructor por defecto
            Class1 payerWinner= new Class1();
            Class1 playerNoFinish = new Class1();
            //y este es creado con el constructor que tiene los parámetros 
            Class1 payerlosser= new Class1("22001","Pedro",180,80.4f,"atacante","tirador");

            //se llama al método para calcular el score dependiendo de los datos que se manda
            //sus intentos, victorias, perdidas y si acabaron el juego 
            
            payerWinner.CalculateScore(out reward, 5,2,1,true);
            payerlosser.CalculateScore(out reward, 2,3,6, true);
            playerNoFinish.CalculateScore(out reward,6,1,7,false);
    }
}
