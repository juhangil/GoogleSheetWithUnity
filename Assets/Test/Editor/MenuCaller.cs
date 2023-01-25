using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Cockatoo.Test {
    public class MenuCaller : MonoBehaviour {
        [MenuItem("Test/Path Call")]
        public static void PathCall() {
            Debug.Log(Application.dataPath);
        }
    }
}