namespace Program{
    class Zvire{
        private string zvuk;
        private string rasa;  
        private int vek;

        private Zvire(string zvuk, string rasa, int vek){
            this.zvuk = zvuk;
            this.rasa = rasa;
            this.vek = vek;
        }

        public static Zvire zvireKocka(){
            Zvire kocka = new Zvire("meow without the t", "sphynx", 3);
            return kocka;
        }

        public static Zvire zvirePes(){
            Zvire pes = new Zvire("Haf", "Jack russel+Kníráč", 14);
            return pes;
        }

        public static Zvire zvireKrava(){
            Zvire krava = new Zvire("Moooooo", "Krava jersey", 1);
            return krava;
        }

        public static Zvire zvireZaba(){
            Zvire zaba = new Zvire("quak", "Skokan zelený", 4);
            return zaba;
        }

        public static Zvire zvireKun(){
            Zvire kun = new Zvire("hyaaaa", "Venom horse", 20);
            return kun;
        }

        public static Zvire zvireSlon(){
            Zvire slon = new Zvire("tůůůůůůůůů", "Slon indický", 12);
            return slon;
        }

        public static Zvire zvireHad(){
            Zvire had = new Zvire("SSSSSSSSSSSSSSSSSS", "zmije obecná", 1);
            return had;
        }

        public static Zvire zvireMedved(){
            Zvire medved = new Zvire("brum brum", "medvídek pů", 8);
            return medved;
        }

        public static Zvire zvireVosa(){
            Zvire vosa = new Zvire("bzzzzzzzzz", "vosa obecná", 9);
            return vosa;
        }

        public static Zvire zvireVcela(){
            Zvire vcela = new Zvire("bssssssss", "Včela medonosná", 5);
            return vcela;
        }

        public string zvukZvirete(){
            return zvuk;
        }

        public string rasaZvirete(){
            return rasa;
        }

        public string vekZvirete(){
            return vek.ToString();
        }

        public string vypis(){
            return $"zvuk:{zvuk}\nrasa:{rasa}\nvěk:{vek}\n*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*";
        }

    }
}