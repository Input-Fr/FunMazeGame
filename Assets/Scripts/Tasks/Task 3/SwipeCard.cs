using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SwipeCard : MonoBehaviour, IDragHandler
{
    // Start is called before the first frame update
    private Canvas _canvas;

    public void OnDrag(PointerEventData eventData){
        Vector2 pos;
        RectTransformUtility.ScreenPointToLocalPointInRectangle(
            _canvas.transform as RectTransform,
            eventData.position,
            _canvas.worldCamera,
            out pos);
        transform.position = _canvas.transform.TransformPoint(pos);
    }

    private void Awake(){
        _canvas = GetComponentInParent<Canvas>();
    }
}
