namespace Wrestling
{
     
    public class Player
    {
        //declaracion de variables
        int height;
        string playerId;
        string role="defender";
        int score;
        float weight;

        //constructor por defecto 
        public Player() { }

        //constructor con parametros
        public Player(string playerId, string name, int height, float weight, string[] role)
        {
            this.height = height;
            this.playerId = playerId;
            this.height = height;
            this.weight = weight;

        }

        //metodo que asigna el premio que se da segun el valor del score
        string determineReward()
        {
             //dependiendo del socore, se aginará un premio diferente 
            if(score>=50 && score<1000)
            return "!your reward is coupons!";

           else if (score >= 1000 && score < 2500)
                return " your reward is Extra chance";

            else if (score >= 2500)
                return "!your reward is Cash coupon!";

            //sino coincide ningun valor, no se asignará recompensa
            return "sorry no reward, retry for the next time :)";
        }


        //metodo para calcular el score 
        public void CalculateScore(out string reward, int noOfHits, int noOfMisses, int noOfRetries = 3, bool complete = true)
        {
            //si el juego se completó se calculará el score y se regresará la recompensa que se asigna en el metodo anterior
            if (complete)
            {
                score = (noOfHits * 100) - (noOfMisses * 25) - (noOfRetries * 50);
                reward = determineReward();

                //sino es completado, su reward será de NA
            } else { 
            Console.WriteLine("unfinished game");
            reward = "NA";
            }

        }


       

    }
}
