using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SampleNameSpace
{

    public class SimpleScripts : MonoBehaviour
    {
        private string username;
        public string userName
        {
            get { return username; }
            set 
            {
                var s = "";
                foreach (var c in value)
                {
                    if (char.IsUpper(c))
                        s += char.ToLower(c);
                    else if (char.IsLower(c))
                        s += c;
                    else
                        Debug.LogError("Username Not Accept special Character");
                }
                username = s;
            }
        }

        private void OnGUI()
        {
            GUI.Label(new Rect(50,100,100,30),userName);
        }
    }
}