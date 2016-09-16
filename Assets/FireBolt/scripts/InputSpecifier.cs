using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.scripts
{
   
    public class InputSpecifier : MonoBehaviour
    {
        

        public InputField storyField;
        public InputField modelField;
        public InputField cameraField;

        void Start()
        {
            setNewDefaults();
        }

        public void StartFireBolt()
        {
            InputSet input = new InputSet();
            if (!string.IsNullOrEmpty(storyField.text))
            {
                input.StoryPlanPath = storyField.text;
            }

            if (!string.IsNullOrEmpty(modelField.text))
            {
                input.CinematicModelPath = modelField.text;
            }

            if (!string.IsNullOrEmpty(cameraField.text))
            {
                input.CameraPlanPath = cameraField.text;
            }

            ElPresidente.Instance.Init(false, input);
        }

        void setNewDefaults()
        {

            storyField.text = "MoreComplexStory.xml";
            modelField.text = "MoreComplexCinematic.xml";
            cameraField.text = "MoreComplexCamera.xml";
        }

        
    }
}
