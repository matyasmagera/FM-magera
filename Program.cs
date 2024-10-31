namespace Program{
    class Program{
        public static void Main(String[] args){
            Zvire medved = Zvire.zvireMedved();
            Console.WriteLine(medved.vypis());
            Zvire slon = Zvire.zvireSlon();
            Console.WriteLine(slon.vypis());
            Zvire kun = Zvire.zvireKun();
            Console.WriteLine(kun.vypis());
        }
    }
}