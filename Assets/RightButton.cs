using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    [SerializeField]
    private DragonMove dm;
    private bool isHold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isHold) dm.MoveRight();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        isHold = true;
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        isHold = false;
    }
    
    public void OnPointerExit(PointerEventData eventData)
    {
        isHold = false;
    }
}
