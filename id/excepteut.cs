using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MouseHover : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the mouse is over a UI element
        if (EventSystem.current.IsPointerOverGameObject())
        {
            // Perform a raycast to detect the UI element
            PointerEventData pointerData = new PointerEventData(EventSystem.current)
            {
                position = Input.mousePosition
            };

            var results = new System.Collections.Generic.List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerData, results);

            foreach (var result in results)
            {
                Debug.Log("Mouse is over: " + result.gameObject.name);
                // If it's a List item, perform additional checks
                if (result.gameObject.GetComponentInParent<VerticalLayoutGroup>() || result.gameObject.GetComponentInParent<HorizontalLayoutGroup>())
                {
                    int index = result.gameObject.transform.GetSiblingIndex();
                    Debug.Log("Item position: " + index);
                }
            }
        }
    }
}
