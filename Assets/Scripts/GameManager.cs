using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float renderScreenScaleModifier = 0.9f;
    private void SetUpCamera(Camera camera, int index, RenderTexture renderTexture = null)
    {
        camera.depth = -index;
        camera.cullingMask = index;
        camera.targetTexture = renderTexture;
    }

    private void SetUpRenderScreen(GameObject renderScreen, int index, RenderTexture renderTexture = null)
    {
        // Z coordinate is 2 - index in order to get correct layering when rendering.
        renderScreen.transform.position = new Vector3(0.0f, 0.0f, (2 - index));
        renderScreen.transform.localScale *= renderScreenScaleModifier;

        if (renderTexture != null)
        {
            renderScreen.GetComponent<Material>().mainTexture = renderTexture;
        }
    }
}
