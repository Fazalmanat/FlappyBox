using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class why : MonoBehaviour
{
    public Rigidbody2D rigid2D;
    public float flap;
    public logicscript logic;
    public bool birdalive = true;
    public audiooo audiop;
    // Start is called before the first frame update
    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
        audiop= GameObject.FindGameObjectWithTag("audio").GetComponent<audiooo>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)==true && birdalive == true)
        {
            rigid2D.velocity = Vector2.up * flap;
            audiop.playsfx(audiop.jump);
        }
 
        if((transform.position.y > 26 || transform.position.y < -27|| transform.position.x < -45)&&(birdalive == true))
        {
            logic.Game0ver();
            birdalive = false;
 
        }
    }
    
}
