using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : MonoBehaviour
{

    public int blocksPerLine = 10;
    
    void Start()
    {
        CreatePuzzle();
    }

    void CreatePuzzle()
    {
        for (int y = 0; y < blocksPerLine; y++)
        {
            for (int x = 0; x < blocksPerLine; x++)
            {
                GameObject blockObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
                blockObject.transform.position = -Vector2.one * (blocksPerLine - 1) * .5f + new Vector2(x, y);
                blockObject.transform.parent = transform;
                //  Debug.Log(" BlockObject Parent" + blockObject.transform.parent.position.x);
                Block block = blockObject.AddComponent<Block>();
                GameController.Instance.Openlist.Add(block);
            } 
        }

        Camera.main.orthographicSize = blocksPerLine * .55f;
    }
}