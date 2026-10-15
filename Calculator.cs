class Calcul
{
    public double FirstNum;
    public double SecondNum;
     public  Calcul(double fist, double second)
    {
        FirstNum=fist;
        SecondNum=second;
    }
    public double Sum()
    {
        return FirstNum+SecondNum;
    }
    public double Subst()
    {
        return FirstNum-SecondNum;
    }
        public double Multi()
    {
        return FirstNum*SecondNum;
    }
    public double Division()
    {
        return FirstNum/SecondNum;
    }
    
}