using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDropElement : MonoBehaviour , IBeginDragHandler , IDragHandler, IEndDragHandler
{
    public Image image;
    [HideInInspector] public Transform parentAfterDrag;

    //images on the panel are not counting as drag targets, no time to fix
    public void OnBeginDrag(PointerEventData eventData)
    {
        
        parentAfterDrag = transform.parent;

        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        if (parentAfterDrag.GetComponent<DragAndDropSlot>().Duplicate)
        {
            // the duplicate of the dragged element is doubled in size. no time to fix
            Instantiate(gameObject).transform.SetParent(parentAfterDrag);
        }


        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (parentAfterDrag == transform.root)
        {
            Destroy(gameObject);
            return;
        }
        if (parentAfterDrag.childCount > 0 )
        {
            if (parentAfterDrag.GetComponent<DragAndDropSlot>().Duplicate)
            {
                Destroy(gameObject);
            }
            else 
            {
                Destroy(parentAfterDrag.GetChild(0).gameObject);
            }
        }
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = false;
    }


}
