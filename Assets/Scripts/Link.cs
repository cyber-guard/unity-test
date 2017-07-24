using UnityEngine;
using System.Runtime.InteropServices;
using UnityEngine.UI;

public class Link : MonoBehaviour 
{

	public InputField Field;

	public void OpenLink()
	{
		Application.OpenURL(Field.text);
	}

	public void OpenLinkJS()
	{
		Application.ExternalEval("alert(document.cookie);");
	}

	public void OpenLinkJSPlugin()
	{
		#if !UNITY_EDITOR
		openWindow(Field.text);
		#endif
	}

    void Start() {
        getCookie();
    }

	[DllImport("__Internal")]
	private static extern void openWindow(string url);

	[DllImport("__Internal")]
	private static extern void getCookie();

}
