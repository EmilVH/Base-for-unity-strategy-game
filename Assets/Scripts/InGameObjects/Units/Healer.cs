using Clicks;
using UnityEngine;

namespace InGameObjects.Units
{
    public class Healer : Unit
    {
        public int HealStrength;
        public int HealRange;
        protected override bool ClickHandler()
        {
            Debug.Log("Trying to heal");
            var now = ClickManager.GetInstance();
            var currClick = now.action;
            if (currClick.Type == "action_click")
            {
                Debug.Log("Started to heal");
                returnClick();
                HealClick heal = new HealClick();
                heal.strength = HealStrength;
                heal.MaxDist = HealRange;
                heal.Blank = false;
                heal.From = this;
                now.action = heal;
                Debug.Log(now.action.Type);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}