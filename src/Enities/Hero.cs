namespace src.Enities
{
    public abstract class Hero
    {
        public Hero(string Name, int level, string HeroType)
        {
            this.Name= Name;
            this.Level = level;
            this.HeroType= HeroType;

        }
        public Hero(){}

        public string Name;
        public int Level;
        public string HeroType;

        public override string ToString()
        {
            return this.Name +" " + this.Level+ this.HeroType;
        } 
        public virtual string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }
        public string Attack(int Bonus)
        {
            if(Bonus>6)
            {
                return this.Name + " Lançou magia super efetiva com bonus de" + Bonus ;
            }else
            {
                return this.Name + "Lançou uma magia com força fraca com bonus de" + Bonus ;
                
            }                
        }
    }
}