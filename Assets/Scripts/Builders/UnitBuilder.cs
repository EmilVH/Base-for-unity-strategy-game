using InGameObjects.Units;

namespace Builders
{
    public class UnitBuilder
    {
        protected Unit _unit;

        public virtual void SetUp()
        {
            _unit = new Unit();
        }
        public virtual void SetHP(int HP)
        {
            _unit.Hp = HP;
        }

        public virtual void SetSpeed(int Speed)
        {
            _unit.Speed = Speed;
        }

        public virtual Unit GetRes()
        {
            return _unit;
        }

    }
}