using Clicks;
using GameEngineUsage;

namespace InGameObjects
{
    public class Tile : InGameObject
    {
        public override void OnClick()
        {
            var now = ClickManager.GetInstance();
            var currClick = now.movement;
            if (currClick.Type == "move_click")
            {
                if (currClick.From.pos.GetSquareDist(pos) <= currClick.From.Speed * currClick.From.Speed)
                {
                    currClick.From.moveTo(new MyVector3(pos.x, currClick.From.pos.y, pos.z));
                }
            }

            now.movement = new MoveClick();
            now.action = new ActionClick();
        }
    }
}