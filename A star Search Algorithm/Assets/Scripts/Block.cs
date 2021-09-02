using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{

    public static Block Instance;
    private bool isSelected = false;

    private Vector2[] adjacentDirections = new Vector2[] { Vector2.up, Vector2.down, Vector2.left, Vector2.right };  // mảng vector2 chiều
    private static Block previousSelected = null;
    private SpriteRenderer render;
    void Awake()
    {
        Instance = this;

    }
    private void Select()
    {
        isSelected = true;
   //     previousSelected = gameObject.GetComponent<Block>();

    }

    private void Deselect()
    {
        isSelected = false;
    //    previousSelected = null;
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
    private GameObject GetAdjacent(Vector2 castDir)
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, castDir);
        if (hit.collider != null)
        {
            return hit.collider.gameObject;
        }
        return null;
    }
    public List<GameObject> GetAllAdjacentTiles()
    {
        List<GameObject> adjacentTiles = new List<GameObject>();
        for (int i = 0; i < adjacentDirections.Length; i++)
        {
            adjacentTiles.Add(GetAdjacent(adjacentDirections[i]));
        }
        return adjacentTiles;
    }


    //if (GetAllAdjacentTiles().Contains(previousSelected.gameObject))
				//{ // 1
				//	SwapSprite(previousSelected.render); // 2
    //previousSelected.ClearAllMatches();
				//	previousSelected.Deselect();
				

				//}

   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
