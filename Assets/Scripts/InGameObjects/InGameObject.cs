using GameEngineUsage;

namespace InGameObjects
{
    public class InGameObject
    {
        public int Id;
        public MyVector3 pos = new MyVector3(0,-10000,0);
        public int user;
        public EngineInformation Bridge;

        public virtual void OnClick()
        {
            
        }
        public void moveTo(MyVector3 newPos)
        {
            //Debug.Log("In logical object");
            pos = newPos;
            Bridge.MoveTo(newPos);
        }
       /* public virtual void StartSelf()
        {
           InitiateTime();
        }
        public virtual void UpdateSelf()
        {
            DeltaTime = GetTimeDelta();
            
            UpdateTime();
        }

        public virtual void OnClicked()
        {
            
        }

        protected void InitiateTime()
        {
            _timeOfLastFrame = _bridge.getTime();
        }

        protected float GetTimeDelta()
        {
            var currTime = _bridge.getTime();
            return currTime - _timeOfLastFrame;
        }

        protected void UpdateTime()
        {
            _timeOfLastFrame = _bridge.getTime();
        }

        protected virtual void InitiateAnimation()
        {
            //Будет когда-нибудь
        }*/
    }
}