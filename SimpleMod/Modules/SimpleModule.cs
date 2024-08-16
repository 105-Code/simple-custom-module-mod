using SFS.Parts;
using SFS.Parts.Modules;
using SFS.UI;
using SFS.Variables;
using SFS.World;
using System;
using UnityEngine;
using static SFS.World.Rocket;

namespace SimpleMod.Modules
{
    public class SimpleModule : MonoBehaviour
    {
        public string TestValue;

        private void Start()
        {
            if (GameManager.main == null)
            {
                base.enabled = false;
                return;
            }
            Debug.Log("Start function on SimpleModule");
        }

        public void ClickOnPart(UsePartData data)
        {
            Debug.Log("You click the part with SimpleModule component with the value: "+ TestValue);
        }

    }
}
