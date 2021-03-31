using InGameObjects.Units;

namespace Builders
{
    public class HealerBuilder : UnitBuilder
    {
        private Healer _healer;
        public override void SetUp()
        {
            _unit = new Healer();
            _healer = (Healer) _unit;
        }
        
        public void SetHealStrength(int healStrength)
        {
            _healer.HealStrength = healStrength;
        }

        public void SetHealRange(int healRange)
        {
            _healer.HealRange = healRange;
        }

        public Healer GetRes()
        {
            return _healer;
        }
    }
}