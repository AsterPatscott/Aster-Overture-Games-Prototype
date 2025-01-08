using UnityEngine;
using UnityEngine.EventSystems;


public class DragAndDropSlot : MonoBehaviour, IDropHandler
{
    public bool Duplicate = false;
    public void OnDrop(PointerEventData eventData)
    {
        GameObject dropped = eventData.pointerDrag;
        DragAndDropElement draggable = dropped.GetComponent<DragAndDropElement>();
        draggable.parentAfterDrag = transform;
    }

}
