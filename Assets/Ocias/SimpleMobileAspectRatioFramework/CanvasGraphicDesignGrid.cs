// ---
// CanvasGraphicDesignGrid: Pop this baby on a canvas and it'll draw you a design grid so you can line up your UI to match your reference design
// by Alexander Ocias
// https://ocias.com
// ---

using UnityEngine;
public class CanvasGraphicDesignGrid : MonoBehaviour {
	[SerializeField] int gridSize = 5;
	//[SerializeField] int lineHeight = 25;

	void OnDrawGizmos () {

		Canvas canvas = GetComponent<Canvas>();
		if (canvas == null) {
			Debug.Log("Canvas Graphic Design Grid should go on an object with a canvas!!");
			return;
		}

		float canvasWidth = canvas.GetComponent<RectTransform>().rect.xMax - canvas.GetComponent<RectTransform>().rect.xMin;
		float canvasHeight = canvas.GetComponent<RectTransform>().rect.yMax - canvas.GetComponent<RectTransform>().rect.yMin;
		float canvasScale = canvas.GetComponent<RectTransform>().localScale.x;

		
		for (int i = 0; i < canvasHeight / 2; i += gridSize) {
			if (i % 4 == 0) {
				Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
			} else {
				Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 0.125f);
			}
			
			Gizmos.DrawLine(new Vector3(0, i + canvasHeight / 2, 0) * canvasScale, new Vector3(canvasWidth, i + canvasHeight / 2, 0) * canvasScale);
			Gizmos.DrawLine(new Vector3(0, -i + canvasHeight / 2, 0) * canvasScale, new Vector3(canvasWidth, -i + canvasHeight / 2, 0) * canvasScale);
			if (i > 2000) {
				break;
			}
		}
		for (int i = 0; i < canvasWidth / 2; i += gridSize) {
			if (i % 4 == 0) {
				Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
			} else {
				Gizmos.color = new Color(0.5f, 0.5f, 0.5f, 0.125f);
			}
			Gizmos.DrawLine(new Vector3(i + canvasWidth / 2, 0, 0) * canvasScale, new Vector3(i + canvasWidth / 2, canvasHeight, 0) * canvasScale);
			Gizmos.DrawLine(new Vector3(-i + canvasWidth / 2, 0, 0) * canvasScale, new Vector3(-i + canvasWidth / 2, canvasHeight, 0) * canvasScale);
			if (i > 2000) {
				break;
			}
		}

		// Gizmos.color = new Color(1f, 1f, 0.0f, 0.5f);
		// for (float i = canvasHeight; i > 0; i -= lineHeight) {
		// 	Gizmos.DrawLine(new Vector3(0, i, 0) * canvasScale, new Vector3(canvasWidth, i, 0) * canvasScale);
		// }

//		for (int i = 0; i < lines; i++) {
//			float lineY = canvasHeight / lines * i;
//			Gizmos.DrawLine(new Vector3(0, lineY, 0), new Vector3(canvasWidth, lineY, 0));
//		}
//
//		Gizmos.color = Color.green;
//		int numberOfGutters = columns - 1;
//		if (outerGutters) {
//			numberOfGutters += 2;
//		}
//		float calculatedColumnWidth = (1 - numberOfGutters * gutterSize) / columns * canvasWidth;
//		for (int i = 0; i < columns; i++) {
//			// Left line
//			float lineX = (calculatedColumnWidth + gutterSize * canvasWidth) * i;
//			if (outerGutters) {
//				lineX += gutterSize * canvasWidth;
//			}
//			Gizmos.DrawLine(new Vector3(lineX, canvasHeight, 0), new Vector3(lineX, 0, 0));
//			// Right line
//			lineX += calculatedColumnWidth;
//			Gizmos.DrawLine(new Vector3(lineX, canvasHeight, 0), new Vector3(lineX, 0, 0));
//		}
	}
}
