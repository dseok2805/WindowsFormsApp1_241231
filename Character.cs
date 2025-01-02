namespace WindowsFormsApp1_241231
{
    public abstract class Character
    // 모든 캐릭터의 공통 속성과 메서드를 정의하는 추상 클래스
    // User, Monster는 각각 Character를 상속하며, Wizard, Warrior, Orc, Slime은 이를 다시 세분화한 구체 클래스
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int AttackPower { get; set; }

        public Character(string name, int hp, int attackPower)
        {
            Name = name;
            HP = hp;
            AttackPower = attackPower;
        }

        public abstract void Attack();

        public virtual void Talk()
        {
            System.Windows.Forms.MessageBox.Show($"{Name} says: Hello!");
            // 캐릭터별로 인사하는 Talk() 메소드를 생성함
        }
    }

}
