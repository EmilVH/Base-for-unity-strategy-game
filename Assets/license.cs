using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class license : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject input;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void get()
    {
        var inn = input.GetComponent<InputField>();
        if (inn.text == "1SADAHd73gds123fGDAFSF362123")
        {
            input.SetActive(false);
            GameObject.Destroy(gameObject);
        }
        
    }
}
