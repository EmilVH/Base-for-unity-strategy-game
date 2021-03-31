using InGameObjects.Units;

namespace Builders
{
    public class KillerBuilder : UnitBuilder
    {
        private Killer _killer;
        public override void SetUp()
        {
            _unit = new Killer();
            _killer = (Killer) _unit;
        }
        
        public void SetAttackStrength(int AttackStrength)
        {
            ((Killer)_unit).AttackStrength = AttackStrength;
        }

        public void SetAttackRange(int AttackRange)
        {
            ((Killer)_unit).AttackRange = AttackRange;
        }

        public Killer GetRes()
        {
            return _killer;
        }
    }
}