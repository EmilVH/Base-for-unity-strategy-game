using Clicks;
using UnityEngine;

namespace InGameObjects.Units
{
   public class Killer : Unit
   {
      public int AttackStrength;
      public int AttackRange;
      protected override bool ClickHandler()
      {
         //Debug.Log("Trying to attack");
         var now = ClickManager.GetInstance();
         var currClick = now.action;
         if (currClick.Type == "action_click")
         {
            //Debug.Log("Started to attack");
            returnClick();
            AttackClick attack = new AttackClick();
            attack.strength = AttackStrength;
            attack.MaxDist = AttackRange;
            attack.Blank = false;
            attack.From = this;
            now.action = attack;
            //Debug.Log(now.action.Type);
            return true;
         }
         else
         {
            return false;
         }
      }
   }
}
