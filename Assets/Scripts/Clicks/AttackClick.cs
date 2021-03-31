using InGameObjects.Units;

namespace Clicks
{
    public class AttackClick : ActionClick
    {
        public int strength;
        //public string 

        public AttackClick()
        {
            Type = "attack_click";
        }
    }
}