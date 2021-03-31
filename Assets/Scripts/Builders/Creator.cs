using GameEngineUsage;
using InGameObjects.Units;

namespace Builders
{
    public class Creator
    {
        private UnitBuilder _builder;
        private Unit _unit;
        private UnityGameObjectCreator _unityGameObjectCreator;
        public int HealerHp = 0;
        public int HealerSpeed = 0;
        public int HealerDistance = 0;
        public int HealerStrength = 0;
        public int KillerHp = 0;
        public int KillerSpeed = 0;
        public int KillerDistance = 0;
        public int KillerStrength = 0;
        private void PreBuilding(int speed, int hp)
        {
            _unityGameObjectCreator = UnityGameObjectCreator.GetInstance();
            //Debug.Log("i have got object creator");
            //Debug.Log(_unityGameObjectCreator == null);
            _builder.SetUp();
            _builder.SetHP(hp);
            _builder.SetSpeed(speed);
        }

        public Killer GetKiller(int style)
        {
            //Debug.Log("I started creating killer");
            _builder = new KillerBuilder();
            PreBuilding(KillerSpeed, KillerHp);
            var killerbuilder = (KillerBuilder) (_builder);
            killerbuilder.SetAttackRange(KillerDistance);
            killerbuilder.SetAttackStrength(KillerStrength);
            Killer result = killerbuilder.GetRes();
            var obj = _unityGameObjectCreator.GetKillerObject(style);
            EngineInformation engineInformation = obj.GetComponent<EngineInformation>();
            result.Bridge = engineInformation;
            engineInformation.unit = result;
            obj.SetActive(true);
            return result;
        }

        public Healer GetHealer(int style)
        {
            _builder = new HealerBuilder();
            PreBuilding(HealerSpeed, HealerHp);
            var healerbuilder = (HealerBuilder) (_builder);
            healerbuilder.SetHealRange(HealerDistance);
            healerbuilder.SetHealStrength(HealerStrength);
            Healer result = healerbuilder.GetRes();
            var obj = _unityGameObjectCreator.GetHealerObject(style);
            EngineInformation engineInformation = obj.GetComponent<EngineInformation>();
            result.Bridge = engineInformation;
            engineInformation.unit = result;
            obj.SetActive(true);
            return result;
        }
    }
}