using UnityEngine;

namespace Clicks
{
    public class ClickManager : MonoBehaviour
    {
        private static ClickManager _instance;
        public MoveClick movement = new MoveClick();
        public ActionClick action = new ActionClick();
        private void Start()
        {
            _instance = this;
        }

        public static ClickManager GetInstance()
        {
            return _instance;
        }
    }
}