using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    //https://www.stdio.vn/giai-thuat-lap-trinh/thuat-giai-a-DVnHj

    //https://viblo.asia/p/a-pathfinding-nwmkyEjlkoW

    // positon one : (-1.5,-1.5,0)
    // position 2: (1.5,1.5,0)
    public int blocksPerLine = 10;
   //1 Open: tập các trạng thái đã được sinh ra nhưng chưa được xét đến.
    public List<GameObject> Openlist = new List<GameObject>();
    //2 Close: tập các trạng thái đã được xét đến
    public List<GameObject> Closelist = new List<GameObject>();


    // xac dinh vi tri ban dau va ket thúc
    public  Vector3 A;
    public  Vector3 B;
    GameObject Astart;
    
    GameObject Bend;

    // change color
    public Material Material1;
    void Start()
    {
        Astart.transform.position = A;
        Bend.transform.position = B;
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
                //  GameController.Instance.Openlist.Add(blockObject);
                //  Openlist.Add(blockObject);
                //blockObject.GetComponent<MeshRenderer>().material = Material1;
            } 
        }

        Camera.main.orthographicSize = blocksPerLine * .55f;
    }
    void InPositionBlock()
    {
        foreach(GameObject a in Openlist)
        {
            Debug.LogError(a.transform.position.x);
        }    
    }
    private void Update()
    {
        InPositionBlock();
    }
    //3Cost(p, q) : là khoảng cách giữa p, q.
    // 5 h(p): giá trị được lượng giá từ trạng thái hiện tại đến trạng thái đích.
    private float distacePandQ(Transform P, Transform Q)
    {
        float distacePandQ = Vector3.Distance(P.position, Q.position);

        return distacePandQ;
    }
    //4 g(p): khoảng cách từ trạng thái đầu đến trạng thái hiện tại p.
    private float g(GameObject all,Transform Q)
    {
        float distance=0.4f;
        return distance;
    }
    //6 f(p) = g(p) + h(p)
    private void AstarPathfinding()
    {
        //b1: 
        Closelist.Add(Astart);
        // b2: Sau đó add tất cả các ô vuông lân cận của vị trí hiện tại vào Open list
        
        while (Openlist !=null)
        {
            //  Chọn trạng thái(đỉnh) tốt nhất p trong Open(xóa p khỏi Open).
            // Nếu p là trạng thái kết thúc thì thoát. 
            //Chuyển p qua Close và tạo ra các trạng thái kế tiếp q sau p.
            //  Nếu q đã có trong Open
                       

        }
    }    

}