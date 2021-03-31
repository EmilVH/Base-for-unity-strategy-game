using System.Runtime.InteropServices;
using Clicks;
using UnityEngine;

namespace InGameObjects.Units
{
    public class Unit : InGameObject
    {
        public int Player;
        public int Hp;
        public int Speed;

        public override void OnClick()
        {
            var now = ClickManager.GetInstance();
            var currClick = now.action;
            if (!ClickHandler())
            {
                //Debug.Log("I cannot attack");
                switch (currClick.Type)
                {
                    case "attack_click":
                        getDamaged();
                        break;
                    case "heal_click":
                        getHealed();
                        break;
                    case "action_click":
                        returnClick();
                        break;
                }
            }
        }


        protected void returnClick()
        {
            var now = ClickManager.GetInstance();
            MoveClick move = new MoveClick();
            move.From = this;
            move.MaxDist = Speed;
            now.movement = move;
            now.action = new ActionClick();
        }

        private void getDamaged()
        {
            //Debug.Log("I am attacked");
            var now = ClickManager.GetInstance();
            var click = (AttackClick) now.action;
            if (checkValid(click))
            {
                Hp -= click.strength;
                if (Hp <= 0)
                {
                    Bridge.Destroy();
                }
            }

            now.movement = new MoveClick();
            now.action = new ActionClick();
        }

        public bool checkValid(ObjClick click)
        {
            //return click.
            //Debug.Log("Started to check maximum dist");
            return click.From.pos.GetSquareDist(pos) <= click.MaxDist * click.MaxDist;
        }

        private void getHealed()
        {
            //Debug.Log("I am healed");
            var now = ClickManager.GetInstance();
            var click = (HealClick) now.action;
            if (checkValid(click))
            {
                Hp += click.strength;
            }

            now.movement = new MoveClick();
            now.action = new ActionClick();
        }

        protected virtual bool ClickHandler()
        {
            return true;
        }

        //private MyVector3 _target = new MyVector3(15,0,15);
    }
}