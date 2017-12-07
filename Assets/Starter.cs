using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ExitGames.Client.Photon;
namespace ExitGames.Demos.DemoPunVoice
{
    public class Starter : MonoBehaviour
    {

        private PhotonVoiceRecorder rec;

        void OnEnable()
        {
            CharacterInstantiation.CharacterInstantiated += CharacterInstantiation_CharacterInstantiated;
        }

        private void CharacterInstantiation_CharacterInstantiated(GameObject character)
        {
            rec = character.GetComponent<PhotonVoiceRecorder>();
            rec.enabled = true;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}