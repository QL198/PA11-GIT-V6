using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionScript : MonoBehaviour
{
    public Text Score_Txt;
    public float Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            
            Score++;
            Score_Txt.text = "Score : " + Score;
            Destroy(collision.gameObject);
        }
    }
}
