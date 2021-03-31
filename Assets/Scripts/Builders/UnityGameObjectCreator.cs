using UnityEngine;

namespace Builders
{
    public class UnityGameObjectCreator : MonoBehaviour
    {
        private static UnityGameObjectCreator instance;
        public GameObject RedKillerTemplate;
        public GameObject RedHealerTemplate;
        public GameObject BlueKillerTemplate;
        public GameObject BlueHealerTemplate;
        private void Start()
        {
            //Debug.Log("i created instance");
            instance = this;
        }

        public static UnityGameObjectCreator GetInstance()
        {
            //Debug.Log(instance == null);
            return instance;
        }


        public GameObject GetKillerObject(int ID)
        {
            GameObject killer;
            if (ID == 1)
            {
                killer = Instantiate(RedKillerTemplate);
            }
            else
            {
                killer = Instantiate(BlueKillerTemplate);
            }
             
            return killer;
        }

        public GameObject GetHealerObject(int ID)
        {
            GameObject healer;
            if (ID == 1)
            {
                healer = Instantiate(RedHealerTemplate);
            }
            else
            {
                healer = Instantiate(BlueHealerTemplate);
            }
             
            return healer;
        }
    }
}