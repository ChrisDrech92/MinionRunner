using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RegisterStudent : MonoBehaviour
{
    public InputField email;
    public InputField password;

    public string FirstLevelName;

    public void Register()
    {
        if (email.text != "" && password.text != "")
        {
            string e = email.text;
            string p = password.text; 
            DataBaseManager.registerStudent(e, p, FirstLevelName);
        }
    }

	
}
