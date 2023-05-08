Console.WriteLine ("JOGO DA AVIVINHAÇÃO");
Random r = new Random();
int num = r.Next(0,10);
int x = 1;
List<int> lista = new List<int>();
while (x==1){
    Console.WriteLine ("digite um número de um a dez:");
    int n = int.Parse(Console.ReadLine());
    while(!lista.Contains(n)){
        if(n == num){
            Thread.Sleep(5000);
            Console.Clear();
            Console.WriteLine ("parabéns");
            x = 0;
        }
        else{
            Thread.Sleep(2000);
            Console.Clear();
            Console.WriteLine ("tente de novo");
            lista.Add(n);
            lista.Sort();
            Console.WriteLine ("tente de novo");
            lista.ForEach(i => Console.Write($"{i},"));
            Thread.Sleep(3000);
            Console.Clear();
        }
    }
    Console.WriteLine ("vc já tentou esse número, tente de novo");
}
