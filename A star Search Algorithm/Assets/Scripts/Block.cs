using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
   
    private bool isSelected = false;

    private SpriteRenderer render;
    void Awake()
    {
      

    }
    private void Select()
    {
        isSelected = true;
      
        
    }

    private void Deselect()
    {
        isSelected = false;
       
    }

	// Start is called before the first frame update
	void OnMouseDown()
	{
	    if(isSelected==false)
        {
            Select();
            Debug.Log("x,y"+transform.position.x+transform.position.y);
        }    
	}
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
