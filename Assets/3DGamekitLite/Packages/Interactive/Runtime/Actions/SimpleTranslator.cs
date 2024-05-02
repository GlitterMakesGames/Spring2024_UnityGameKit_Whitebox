using System;
using Unity.VisualScripting;
using UnityEngine;

namespace Gamekit3D.GameCommands
{
    public class SimpleTranslator : SimpleTransformer
    {
        public new Rigidbody rigidbody;
        public Vector3 start = -Vector3.forward;
        public Vector3 end = Vector3.forward;
        private bool firstTime = true;

        public override void PerformTransform(float position)
        {

            var curvePosition = accelCurve.Evaluate(position);
            var pos = transform.TransformPoint(Vector3.Lerp(start, end, curvePosition));
            Vector3 deltaPosition = pos - rigidbody.position;
            if (Application.isEditor && !Application.isPlaying)
                rigidbody.transform.position = pos;
            rigidbody.MovePosition(pos);

            if (m_Platform != null)
                m_Platform.MoveCharacterController(deltaPosition);
        }

        // THE FOLLOWING CODE WAS ADDED BY DELAINA HARDWICK
        // --------------------------------------------------------------//
        // --------------------------------------------------------------//

        private void Update()
        {
            if (activate == true && firstTime == true)
            {
                firstTime = false;
                if (this.name == "Door C2")
                {
                    Debug.Log("The code I wrote works! #1");
                    GameObject Key_F = GameObject.Find("Key F");
                    Transform receptor = Key_F.transform.Find("KeyReceptor");
                    receptor.position = new Vector3(receptor.position.x, 1, receptor.position.z);
                }
                else if (this.name == "Door F")
                {
                    Debug.Log("The code I wrote works! #2");
                    GameObject Key_G = GameObject.Find("Key G");
                    Transform receptor = Key_G.transform.Find("KeyReceptor");
                    receptor.position = new Vector3(receptor.position.x, 1, receptor.position.z);
                }
            }
        }
    }
}