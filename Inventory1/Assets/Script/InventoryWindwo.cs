using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InventoryWindwo : MonoBehaviour {

    public int startingPosX;
    public int startingPosY;
    public int slotCntPerPage;
    public int soltCntLenght;
    public GameObject itemSlotPreFab;
    public ToggleGroup itemSlotToggleGroup;

    private int xPos;
    private int yPos;
    private GameObject itemSlot;
    private int itemSlotCnt;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void CreateInventorySoltsInWindow()
    {
        xPos = startingPosX;
        xPos = startingPosY;
        for(int i = 0; i < slotCntPerPage; i++)
        {
            itemSlot = (GameObject)Instantiate(itemSlotPreFab);
            itemSlot.name = "Empty";
            itemSlot.GetComponent<Toggle>().group = itemSlotToggleGroup;
            itemSlot.transform.SetParent(this.gameObject.transform);
            itemSlot.GetComponent<RectTransform>().localPosition = new Vector3(xPos, yPos, 0);
            xPos += (int)itemSlot.GetComponent<RectTransform>().rect.width;
            if (itemSlotCnt % soltCntLenght == 0)
            {
               
            }
        }
    }
}
