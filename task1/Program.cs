namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("welcome to islam's carpet cleaning");

            //menu for islam's carpet cleaning
            //S = sallary of clean carpet  , s = small , l = large

            Console.WriteLine("clean S_s_carpet = 25  ,  clean S_l_carpet = 35");
              
            Console.WriteLine("what is number of Small carpet and Large carpet you want to clean?");

            //input number of small and large carpets
            //N = number of carpets

                      Console.WriteLine($"N_s_carpet =  ");
                               int N_s_carpet = Convert.ToInt32(Console.ReadLine());
                      Console.WriteLine("N_l_carpet =  ");
                               int N_l_carpet    = Convert.ToInt32(Console.ReadLine());

            //cost of small and large carpets


                      int S_s_carpet = 25;
                      int S_l_carpet = 35;
            
            //calculate cost, tax and total cost
            
                      int cost = (N_s_carpet * S_s_carpet) + ( N_l_carpet * S_l_carpet   );
                      double tax = (cost * .06 );
                      double total_cost = cost + tax;
            
            //print cost, tax and total cost

            Console.WriteLine("cost = " + cost);
            Console.WriteLine("tax = " + tax);
            Console.WriteLine("total_cost = " + total_cost);

        }
    }
}
