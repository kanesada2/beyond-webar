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

        WebCamDevice userCameraDevice = WebCamTexture.devices[0];
        m_webCamTexture = new WebCamTexture(userCameraDevice.name, Screen.width, Screen.height);

        m_displayUI.texture = m_webCamTexture;

        m_webCamTexture.Play();
    }
}
