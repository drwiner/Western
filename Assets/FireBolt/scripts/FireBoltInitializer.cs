using UnityEngine;
using System.Collections;
using System;
using Mono;

namespace Assets.scripts
{

    public class FireBoltInitializer : MonoBehaviour
    {
        private static readonly char encodingDelimiter = ':';
        // Use this for initialization
        void Start()
        {
            bool logDebug = false;
            InputSet inputFiles = new InputSet();

          //  Profiler.maxNumberOfSamplesPerFrame = -1;
            inputFiles.CameraPlanPath = "cameraPlans/defaultCamera.xml";
            inputFiles.CinematicModelPath = "cinematicModels/defaultModel.xml";
            inputFiles.StoryPlanPath = "storyPlans/defaultStory.xml";

            ElPresidente.Instance.Init(logDebug, inputFiles, false, false, false, false, "statfile.txt");
        }
    }
}