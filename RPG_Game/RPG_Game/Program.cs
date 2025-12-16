namespace RPG_Game
{
    public class WoodenSword : Weapon
    {
        public WoodenSword() : base("Дерев'яний меч", "+5 до атаки", 5)
        {
        }
    }

    public class HealthPotion : Item
    {
        private int _healAmount;

        public HealthPotion() : base("Зілля здоров'я", "Відновлює 40 HP")
        {
            _healAmount = 40;
        }

        public override void Use(Player player)
        {
            Console.WriteLine($"{player.Name} використовує {Name}");
            player.Heal(_healAmount);
        }
    }

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

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
