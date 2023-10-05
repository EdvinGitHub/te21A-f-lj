public class Fråger 
{
    public string text;
    public List<string> svar;
    public int rätt;
    public Fråger(string t, List<string> a, int r)
    {
    text = t;
    svar = a;
    rätt = r;
    }

    public bool fråga()
    {
        return true;
    }
}