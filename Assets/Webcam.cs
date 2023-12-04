using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Webcam : MonoBehaviour
{

    //[SerializeField]
    //private int m_width = 1920;
    //[SerializeField]
    //private int m_height = 1080;
    [SerializeField]
    private RawImage m_displayUI = null;

    private WebCamTexture m_webCamTexture = null;


    private IEnumerator Start()
    {
        if (WebCamTexture.devices.Length == 0)
        {
            yield break;
        }

        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);
        if (!Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            yield break;
        }
        for (int i = 0; i < WebCamTexture.devices.Length; i++)
        {
            if (!WebCamTexture.devices[i].isFrontFacing)
            {
                m_webCamTexture = new WebCamTexture(WebCamTexture.devices[i].name, Screen.width, Screen.height);
                break;
            }
        }

        if (m_webCamTexture == null)
        {
            yield break;
        }

        m_displayUI.texture = m_webCamTexture;

        m_webCamTexture.Play();
    }
}
