namespace DolgozatProject
{
    public class Dolgozat
    {
        public List<int> pontok;

        public Dolgozat()
        {
            pontok = new List<int>();
        }

        public void PontFelvisz(int x)
        {
            if(x > 100 || x < -1)
            {
                throw new ArgumentException();
            } else
            {
                pontok.Add(x);
            }
        }

        public bool MindenkiMegirta()
        {
            if(pontok.Any(x=>x == -1))
            {
                return false;
            }
            return true;
        }

        public int Bukas { get { return pontok.Count(x => x > -1 && x < 50); } }
        public int Elegseges { get { return pontok.Count(x=>x >= 50 && x <= 60); } }
        public int Kozepes { get { return pontok.Count(x=>x >= 61 && x <= 70); } }
        public int Jo { get { return pontok.Count(x=>x >= 71 && x <= 80); } }
        public int Jeles { get { return pontok.Count(x=>x >= 81); } }

        public bool Gyanus(int kivalok)
        {
            if (kivalok < 0)
            {
                throw new ArgumentException();
            }

            if(this.Jeles > kivalok)
            {
                return true;
            }
            return false;
        }

        public bool Ervenytelen { get { return pontok.Count(x => x == -1) > (pontok.Count() / 2); } }
    }
}
