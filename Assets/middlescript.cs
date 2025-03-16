using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middlescript : MonoBehaviour
{
    public logicscript logic;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicscript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {   
        if(collision.gameObject.layer == 3)
        logic.addscore(1);
    }
}
