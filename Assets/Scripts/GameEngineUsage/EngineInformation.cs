using InGameObjects;
using UnityEngine;

namespace GameEngineUsage
{
    public class EngineInformation : MonoBehaviour
    {
        // Start is called before the first frame update
        public InGameObject unit;
        private Transform _transform;
        private Rigidbody _rigidbody;


        void Start()    
        {
            _transform = GetComponent<Transform>();
            _rigidbody = GetComponent<Rigidbody>();
            unit.Bridge = this;
        }

        // Update is called once per frame
        void Update()
        {
            //unit.UpdateSelf();
        }

        public void Destroy()
        {
            GameObject.Destroy(gameObject);
        }
        public float getTime()
        {
            return Time.time;
        }

        public MyVector3 getPosition()
        {
            return new MyVector3(_transform.position);
        }
        private void OnMouseDown()
        {
            unit.OnClick();
        }

        public void MoveTo(MyVector3 targ)
        {
            if (_transform == null)
            {
                _transform = GetComponent<Transform>();
            }
            /*var deltaX = targ.x - _transform.position.x;
        var deltaZ = targ.z - _transform.position.z;
        float angleX = deltaX / (Math.Abs(deltaX) + Math.Abs(deltaZ));
        float angleZ = deltaZ / (Math.Abs(deltaX) + Math.Abs(deltaZ));
        Vector3 movement = new Vector3(angleX, 0.0f, angleZ);
        //Debug.Log(angleX + " " + angleZ); 
        _rigidbody.AddForce(movement * (speed * delta));*/
            _transform.position = targ.GetUnityVector();
        }
    }
}