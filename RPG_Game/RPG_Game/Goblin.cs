namespace RPG_Game
{
    public class Goblin : Enemy
    {
        public Goblin() : base("Гоблін", 40, 8, 30)
        {
            AddLoot(new HealthPotion());
        }

        public override void Attack(Character target)
        {
            var damage = Strength;
            Console.WriteLine($"{Name} б'є кинджалом і завдає {damage}");
            target.TakeDamage(damage);
        }
    }
}
