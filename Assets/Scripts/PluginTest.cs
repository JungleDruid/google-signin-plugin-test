using UnityEngine;

public class PluginTest : MonoBehaviour
{
    private void Start()
    {
        var jc = new AndroidJavaClass("com.unity3d.player.UnityPlayer");
        var activity = jc.GetStatic<AndroidJavaObject>("currentActivity");
        var signin = new AndroidJavaObject("com.omnibit.loginmodule.GoogleSignInFragment");
        signin.SetStatic("UnityGameObjectName", name);
        signin.CallStatic("SignIn", activity, "CLIENT_ID");
    }

    public void UnityGoogleSignInSuccessCallback(string e)
    {
        Debug.Log("Sign In Success");
        Debug.LogWarning(e);
    }

    public void UnityGoogleSignInErrorCallback(string e)
    {
        Debug.Log("Sign In Failed");
        Debug.LogError(e);
    }
}
