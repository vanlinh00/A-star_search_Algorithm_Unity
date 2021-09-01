using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public static GameController Instance;
    
    public List<Block> CloseList = new List<Block>();

    void Start()
    {
        Instance = this;
    }

    public void DistanceAandB()
    {
        //Openlist[1].transform.position.x;
       // Debug.LogError(Openlist[1].transform.position.x);
      //   float a=Mathf.Sqrt(Openlist[1].transform.position.x-)
    }    
    // Update is called once per frame
    void Update()
    {
      
    }
}
