using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class EditorButtonBehavior : MonoBehaviour , ISelectHandler {

	public ScrollRect scrollRect;
	public GameObject prefab;

	float scrollRectOrigin;
	float scrollRectHalfWidth;
	float buttonHalfWidth;
	float totalWidth;

	private void Awake(){
		//Setting values
		scrollRectHalfWidth = ((RectTransform)scrollRect.transform).rect.width / 2f;
		scrollRectOrigin = ((RectTransform)scrollRect.transform).position.x;
		buttonHalfWidth = GetComponent<RectTransform> ().rect.width / 2f;
		totalWidth = buttonHalfWidth * 2 * scrollRect.content.transform.childCount - scrollRectHalfWidth * 2; //Total width of the content hidden outside the mask ( w = * =» *******[000000]*** )
		GetComponent<Button>().onClick.AddListener(delegate {GameObject.FindWithTag("EditorController").GetComponent<EditorBehavior>().selectPrefab(prefab);});
	}

	public void OnSelect(BaseEventData eventData) {
		float x = GetComponent<Transform> ().position.x;
		if (x - buttonHalfWidth - 10< scrollRectOrigin - scrollRectHalfWidth) {
			//Button is clipping left side
			float gap = (transform.GetSiblingIndex () - 1) * buttonHalfWidth * 2; //Width of the gap between the left side of the content and the left side of the mask ( w = * =» *******[000000]000 )
			scrollRect.horizontalNormalizedPosition = gap / totalWidth;
		} else if (scrollRectOrigin + scrollRectHalfWidth < x + buttonHalfWidth + 10) {
			//Button is clipping right side
			float gap = (transform.GetSiblingIndex () + 2) * buttonHalfWidth * 2 - (scrollRectHalfWidth * 2); //Same as above, but this time we have to substract the mask's width
			scrollRect.horizontalNormalizedPosition = gap / totalWidth;
		}
	}
}
